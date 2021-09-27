using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace HookCounter {

    public class MainForm : Form {

        private List<Button> hookButtons = new List<Button>();
        private int[] hooks = new int[4];
        private Survivor[] survivors = new Survivor[4];
        private int SurvivorPadding = 130;
        private Size HookSize = new Size(50, 102);
        public GlobalVars vars;

        public MainForm(GlobalVars _vars) {

            vars = _vars;
            LoadUserSettings();

            Text = "Hook Counter";
            Size = new Size(HookSize.Width * 3, HookSize.Height * 4 + SurvivorPadding * 3);
            Console.WriteLine(HookSize.Width * 3);
            Console.WriteLine(Size);

            //TransparencyKey = Color.Lime;
            FormBorderStyle = FormBorderStyle.None;

            for (int i = 0; i < survivors.Length; i++)
            {
                survivors[i] = new Survivor(0, new Size(HookSize.Width, HookSize.Height));
                Controls.Add(survivors[i].hookPanel);
                survivors[i].InitializeHookPanel();
                survivors[i].hookPanel.Location = new Point(0, i * Size.Height / 4);
                survivors[i].hookPanel.Show();
                foreach(Control control in survivors[i].hookPanel.Controls)
                {
                    control.KeyDown += OnKeyDown;
                }
                Console.WriteLine($"{i} - {survivors[i].hookPanel.Location}");
            }

            /*for (int i=0;i<hooks.Length;i++) {
                Button button = new Button();
                button.Size = new Size(400, 100);
                button.Location = new Point(0, i * 100);
                button.Text = "Survivor " + (i + 1) + " | " + hooks[i];
                button.Click += new EventHandler(OnClick);

                hookButtons.Add(button);
                Controls.Add(button);
            }*/
        }

        public void LoadUserSettings()
        {
            try
            {
                string directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter";
                string path = directory + @"\Settings.txt";

                if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                if (!File.Exists(path))
                { 
                    string[] defaultSettings = {"OverridenHookSizeX=50", "OverridenHookSizeY=102", "SurvivorPadding=130", "ChromaR=0", "ChromaG=255", "ChromaB=0"};
                    File.WriteAllLines(path, defaultSettings);
                    MessageBox.Show("Hey there!\nIt seems it's your first time launching this hook counter, here's some hotkeys you can hit to get started!\n" +
                        "(These are the default hotkeys, read the README.txt file in the download folder to learn more about keybinds!:\n" +
                        "Numpad 0: Reset all Survivor's hook states.\n" +
                        "Numpad 1-4: Add one to a Survivor's hook state.\n" +
                        "F6: Credits\n" +
                        "Numpad 7: Quit Program\n" +
                        "Numpad 9: Settings Menu\n", "First Time Launch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string[] rawSettings = File.ReadAllLines(path);
                string[,] settings = new string[rawSettings.Length, 2];

                for (int i = 0; i < rawSettings.Length; i++)
                {
                    string[] splitSettings = rawSettings[i].Split('=');
                    settings[i, 0] = splitSettings[0];
                    settings[i, 1] = splitSettings[1];
                }

                string hookSizeX = FindSetting(settings, "OverridenHookSizeX", rawSettings.Length);
                string hookSizeY = FindSetting(settings, "OverridenHookSizeY", rawSettings.Length);
                string survPadding = FindSetting(settings, "SurvivorPadding", rawSettings.Length);
                string chromaKeyR = FindSetting(settings, "ChromaR", rawSettings.Length);
                string chromaKeyG = FindSetting(settings, "ChromaG", rawSettings.Length);
                string chromaKeyB = FindSetting(settings, "ChromaB", rawSettings.Length);

                List<string> rawSettingsList = new List<string>();
                for (int i = 0; i < rawSettings.Length; i++){ rawSettingsList.Add(rawSettings[i]); }
                bool changedSettings = false;

                if (hookSizeX == "") { rawSettingsList.Add("OverridenHookSizeX=50"); changedSettings = true; } else
                if (hookSizeY == "") { rawSettingsList.Add("OverridenHookSizeY=102"); changedSettings = true; } else
                if (survPadding == "") { rawSettingsList.Add("SurvivorPadding=130"); changedSettings = true; } else
                if (chromaKeyR == "") { rawSettingsList.Add("ChromaR=0"); changedSettings = true; } else
                if (chromaKeyG == "") { rawSettingsList.Add("ChromaG=255"); changedSettings = true; } else
                if (chromaKeyB == "") { rawSettingsList.Add("ChromaB=0"); changedSettings = true; }

                File.WriteAllLines(path, rawSettingsList.ToArray());

                if (changedSettings) { LoadUserSettings(); return; }

                HookSize = new Size(int.Parse(hookSizeX), int.Parse(hookSizeY));
                SurvivorPadding = int.Parse(survPadding);
                BackColor = Color.FromArgb(int.Parse(chromaKeyR), int.Parse(chromaKeyG), int.Parse(chromaKeyB));

                /*for (int i = 0; i < settings.GetLength(0); i++)
                {
                    if (settings[i, 0] == "OverrideHookSize" && settings[i, 1] == "true") {
                        int sizeX = int.Parse(settings[i + 1, 1]);
                        int sizeY = int.Parse(settings[i + 2, 1]);
                        HookSize = new Size(sizeX, sizeY);
                    } else if (settings[i, 0] == "SurvivorPadding") {
                        SurvivorPadding = int.Parse(settings[i, 1]);
                    }
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error loading user settings! The program should still work as normal with default settings despite this. Here is the full error, take a screenshot of this!:\n{ex.Source} - {ex.TargetSite}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                throw;
            }
        }

        private string FindSetting(string[,] settings, string setting, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (settings[i, 0] == setting)
                {
                    return settings[i, 1];
                }
            }
            return "";
        }

        public void OnClick(object sender, EventArgs e) {
            for(int i = 0; i < hookButtons.Count; i++) {
                if (sender == hookButtons[i]) {
                    AddHook(i);
                    break;
                }
            }
        }

        public void AddHook(int index) {
            survivors[index].hookStates++;
            if (survivors[index].hookStates > 3)
            {
                survivors[index].hookStates = 0;
            }
            UpdateCounts();
        }

        public void ResetHooks() {
            for (int i = 0; i < survivors.Length; i++)
            {
                survivors[i].hookStates = 0;
            }
            UpdateCounts();
        }

        public void UpdateCounts() {
            for(int i = 0; i < survivors.Length; i++) {
                survivors[i].UpdateVisuals();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Activated += new System.EventHandler(this.Active);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.ResumeLayout(false);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Active(object sender, EventArgs e)
        {
        }
    }
}