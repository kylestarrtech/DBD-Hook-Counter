using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HookCounter
{
    public partial class StartForm : Form
    {
        public MainForm form;
        public GlobalVars vars;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public StartForm(MainForm _form, GlobalVars _vars)
        {
            InitializeComponent();
            form = _form;
            vars = _vars;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            vars.allowGlobalKeypress = false;
            LoadSettings();
        }

        public void RemoveNumericUpDownArrows(NumericUpDown num)
        {
            for (int i = 0; i < num.Controls.Count; i++)
            {
                Console.WriteLine(num.Controls[i]);
            }
            num.Controls[0].Hide();
            num.Controls[1].Width -= num.Controls[0].Width;
        }

        private void MouseEnterLabel(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Color lCol = label.BackColor;
            int r, g, b;
            if (lCol.R + 10 > 255) { r = 255; } else { r = lCol.R + 10; }
            if (lCol.G + 10 > 255) { g = 255; } else { g = lCol.G + 10; }
            if (lCol.B + 10 > 255) { b = 255; } else { b = lCol.B + 10; }
            label.BackColor = Color.FromArgb(r, g, b);
        }

        private void MouseLeaveLabel(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Color lCol = label.BackColor;
            int r, g, b;
            if (lCol.R - 10 < 0) { r = 0; } else { r = lCol.R - 10; }
            if (lCol.G - 10 < 0) { g = 0; } else { g = lCol.G - 10; }
            if (lCol.B - 10 < 0) { b = 0; } else { b = lCol.B - 10; }
            label.BackColor = Color.FromArgb(r, g, b);
        }

        private void FocusEnterTextbox(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Color lCol = textBox.BackColor;
            int r, g, b;
            if (lCol.R + 10 > 255) { r = 255; } else { r = lCol.R + 10; }
            if (lCol.G + 10 > 255) { g = 255; } else { g = lCol.G + 10; }
            if (lCol.B + 10 > 255) { b = 255; } else { b = lCol.B + 10; }
            textBox.BackColor = Color.FromArgb(r, g, b);
        }

        private void FocusLeaveTextbox(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Color lCol = textBox.BackColor;
            int r, g, b;
            if (lCol.R - 10 < 0) { r = 0; } else { r = lCol.R - 10; }
            if (lCol.G - 10 < 0) { g = 0; } else { g = lCol.G - 10; }
            if (lCol.B - 10 < 0) { b = 0; } else { b = lCol.B - 10; }
            textBox.BackColor = Color.FromArgb(r, g, b);
        }

        private void DraggableMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void LoadSettings()
        {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter\Settings.txt";
            string keysPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter\Keybinds.txt";

            try
            {
                string[] settings = File.ReadAllLines(savePath);
                string[,] splitSettings = new string[settings.Length, 2];

                for (int i = 0; i < settings.Length; i++)
                {
                    string[] newSplit = settings[i].Split('=');
                    splitSettings[i, 0] = newSplit[0];
                    splitSettings[i, 1] = newSplit[1];
                }

                hookIconX.Text = FindSetting(splitSettings, "OverridenHookSizeX", settings.Length);
                hookIconY.Text = FindSetting(splitSettings, "OverridenHookSizeY", settings.Length);
                survivorPadding.Text = FindSetting(splitSettings, "SurvivorPadding", settings.Length);
                chromaKeyR.Text = FindSetting(splitSettings, "ChromaR", settings.Length);
                chromaKeyG.Text = FindSetting(splitSettings, "ChromaG", settings.Length);
                chromaKeyB.Text = FindSetting(splitSettings, "ChromaB", settings.Length);

                string[] keybinds = File.ReadAllLines(keysPath);
                string[,] splitKeybinds = new string[keybinds.Length, 2];

                for (int i = 0; i < keybinds.Length; i++)
                {
                    string[] newSplit = keybinds[i].Split('=');
                    splitKeybinds[i, 0] = newSplit[0];
                    splitKeybinds[i, 1] = newSplit[1];
                }

                survivorHotkey1.Text = FindSetting(splitKeybinds, "SurvivorOneKey", keybinds.Length);
                survivorHotkey2.Text = FindSetting(splitKeybinds, "SurvivorTwoKey", keybinds.Length);
                survivorHotkey3.Text = FindSetting(splitKeybinds, "SurvivorThreeKey", keybinds.Length);
                survivorHotkey4.Text = FindSetting(splitKeybinds, "SurvivorFourKey", keybinds.Length);
                resetSurvivorsHotkey.Text = FindSetting(splitKeybinds, "ResetAllSurvivors", keybinds.Length);
                exitHotkey.Text = FindSetting(splitKeybinds, "Exit", keybinds.Length);
                settingsHotkey.Text = FindSetting(splitKeybinds, "Help", keybinds.Length);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error loading your settings! Here is the full error, take a screenshot of this!:\n{ex.Source} - {ex.TargetSite}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public string FindSetting(string[,] keybinds, string key, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (keybinds[i, 0] == key)
                {
                    return keybinds[i, 1];
                }
            }
            return "";
        }


        public void SaveUserSettings()
        {
            string savePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter\Settings.txt";
            string keysPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter\Keybinds.txt";

            List<string> saveSettings = new List<string>();

            saveSettings.Add($"OverridenHookSizeX={hookIconX.Text}");
            saveSettings.Add($"OverridenHookSizeY={hookIconY.Text}");
            saveSettings.Add($"SurvivorPadding={survivorPadding.Text}");
            saveSettings.Add($"ChromaR={chromaKeyR.Text}");
            saveSettings.Add($"ChromaG={chromaKeyG.Text}");
            saveSettings.Add($"ChromaB={chromaKeyB.Text}");

            File.WriteAllLines(savePath, saveSettings.ToArray());

            List<string> keybindSettings = new List<string>();

            keybindSettings.Add($"SurvivorOneKey={survivorHotkey1.Text}");
            keybindSettings.Add($"SurvivorTwoKey={survivorHotkey2.Text}");
            keybindSettings.Add($"SurvivorThreeKey={survivorHotkey3.Text}");
            keybindSettings.Add($"SurvivorFourKey={survivorHotkey4.Text}");
            keybindSettings.Add($"ResetAllSurvivors={resetSurvivorsHotkey.Text}");
            keybindSettings.Add($"Exit={exitHotkey.Text}");
            keybindSettings.Add($"Help={settingsHotkey.Text}");

            File.WriteAllLines(keysPath, keybindSettings);

            Application.Restart();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            vars.allowGlobalKeypress = true;
            this.Close();
        }

        private void CheckIfDigit(object sender, EventArgs e)
        {
            FocusLeaveTextbox(sender, e);
            int parsedValue;
            TextBox textBox = (TextBox)sender;
            if (!int.TryParse(textBox.Text, out parsedValue))
            {
                MessageBox.Show("The text in the textbox MUST be an integer, please write an integer here.", "Issue parsing textbox value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
        }

        private void SetKeyTextbox(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Clear();
            textBox.Text = e.KeyCode.ToString();
        }

        private void RGBTextChanged(object sender, EventArgs e)
        {
            if (IsDigit(chromaKeyR.Text) && IsDigit(chromaKeyG.Text) && IsDigit(chromaKeyB.Text)) {

                int r = ClampValue(int.Parse(chromaKeyR.Text), 0, 255);
                int g = ClampValue(int.Parse(chromaKeyG.Text), 0, 255);
                int b = ClampValue(int.Parse(chromaKeyB.Text), 0, 255);

                Color previewColor = Color.FromArgb(r, g, b);

                hookPreview1.BackColor = previewColor;
                hookPreview2.BackColor = previewColor;
                hookPreview3.BackColor = previewColor;
            } else
            {
                Console.WriteLine("NOT DIGIT");
            }
        }

        private int ClampValue(int value, int min, int max)
        {
            if (value > max) { value = max; }
            if (value < min) { value = min; }
            return value;
        }

        private bool IsDigit(string text)
        {
            int parsedResult;
            return int.TryParse(text, out parsedResult);
        }

        private void saveSettings_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SaveUserSettings();
            } else
            {
                string savePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter\Settings.txt";
                string keysPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter\Keybinds.txt";

                File.Delete(savePath);
                File.Delete(keysPath);

                Application.Restart();
            }
        }

        private void SetTextBoxToReadOnlyFalse(object sender, KeyEventArgs e)
        {

        }

        private void SetTextBoxToReadOnlyFalseAfterClick(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.ReadOnly) { textBox.ReadOnly = false; }
        }
    }
}
