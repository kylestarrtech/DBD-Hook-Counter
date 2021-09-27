using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HookCounter;
using System.IO;
using System.Collections.Generic;

class Program : Form {

    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private static LowLevelKeyboardProc _proc = HookCallback;
    private static IntPtr _hookID = IntPtr.Zero;
    private FlowLayoutPanel flowLayoutPanel1;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private static MainForm form;
    private static GlobalVars vars;
    private static Keys[] hookKeys = new Keys[7];
    
    public static void Main() {
        vars = new GlobalVars();
        LoadKeybinds();

        _hookID = SetHook(_proc);
        form = new MainForm(vars);
        Application.Run(form);
        UnhookWindowsHookEx(_hookID);
    }

    private static void LoadKeybinds()
    {
        try
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter";
            string path = directory + @"\Keybinds.txt";

            if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
            if (!File.Exists(path))
            {
                string[] defaultKeybinds = {"SurvivorOneKey=NumPad1", "SurvivorTwoKey=NumPad2",
                    "SurvivorThreeKey=NumPad3", "SurvivorFourKey=NumPad4",
                    "ResetAllSurvivors=NumPad0", "Exit=NumPad7",
                    "Help=NumPad9"};

                File.WriteAllLines(path, defaultKeybinds);
            }

            string[] rawKeybinds = File.ReadAllLines(path);
            string[,] keybinds = new string[rawKeybinds.Length, 2];

            for (int i = 0; i < rawKeybinds.Length; i++)
            {
                string[] splitSettings = rawKeybinds[i].Split('=');
                keybinds[i, 0] = splitSettings[0];
                keybinds[i, 1] = splitSettings[1];
            }

            hookKeys[0] = FindKeybind(keybinds, "SurvivorOneKey", rawKeybinds.Length);
            hookKeys[1] = FindKeybind(keybinds, "SurvivorTwoKey", rawKeybinds.Length);
            hookKeys[2] = FindKeybind(keybinds, "SurvivorThreeKey", rawKeybinds.Length);
            hookKeys[3] = FindKeybind(keybinds, "SurvivorFourKey", rawKeybinds.Length);
            hookKeys[4] = FindKeybind(keybinds, "ResetAllSurvivors", rawKeybinds.Length);
            hookKeys[5] = FindKeybind(keybinds, "Exit", rawKeybinds.Length);
            hookKeys[6] = FindKeybind(keybinds, "Help", rawKeybinds.Length);

            List<string> rawBindList = new List<string>();
            for (int i = 0; i < rawKeybinds.Length; i++) { rawBindList.Add(rawKeybinds[i]); }
            bool changedBindings = false;

            for (int i = 0; i < hookKeys.Length; i++)
            {
                if (hookKeys[i] == Keys.None)
                {
                    switch (i)
                    {
                        case 0:
                            rawBindList.Add("SurvivorOneKey=NumPad1");
                            break;
                        case 1:
                            rawBindList.Add("SurvivorTwoKey=NumPad2");
                            break;
                        case 2:
                            rawBindList.Add("SurvivorThreeKey=NumPad3");
                            break;
                        case 3:
                            rawBindList.Add("SurvivorFourKey=NumPad4");
                            break;
                        case 4:
                            rawBindList.Add("ResetAllSurvivors=NumPad0");
                            break;
                        case 5:
                            rawBindList.Add("Exit=NumPad7");
                            break;
                        case 6:
                            rawBindList.Add("Help=NumPad9");
                            break;
                    }
                    changedBindings = true;
                }
            }

            File.WriteAllLines(path, rawBindList.ToArray());

            if (changedBindings) { LoadKeybinds(); }

            /*for (int i = 0; i < keybinds.GetLength(0); i++)
            {
                string keyString = keybinds[i, 1];
                hookKeys[i] = (Keys)Enum.Parse(typeof(Keys), keyString);
            }*/
        }
        catch (Exception ex)
        {
            MessageBox.Show($"There was an error loading keybind settings! The program should still work as normal with default settings despite this. Here is the full error, take a screenshot of this!:\n{ex.Source} - {ex.TargetSite}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            throw;
        }
    }

    private static Keys FindKeybind(string[,] keybinds, string key, int length)
    {
        for (int i = 0; i < length; i++)
        {
            if (keybinds[i, 0] == key)
            {
                return (Keys)Enum.Parse(typeof(Keys), keybinds[i, 1]);
            }
        }
        return Keys.None;
    }

    private static IntPtr SetHook(LowLevelKeyboardProc proc) {
        using(Process curProcess = Process.GetCurrentProcess())
        using(ProcessModule curModule = curProcess.MainModule) {
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    private delegate IntPtr LowLevelKeyboardProc(
        int nCode, IntPtr wParam, IntPtr lParam);

    private static IntPtr HookCallback(
        int nCode, IntPtr wParam, IntPtr lParam) {
        if (vars.allowGlobalKeypress) {
            if(nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN) {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;
                if (key == hookKeys[0]) {
                    form.AddHook(0);
                }
                else if (key == hookKeys[1]) {
                    form.AddHook(1);
                }
                else if (key == hookKeys[2]) {
                    form.AddHook(2);
                }
                else if (key == hookKeys[3]) {
                    form.AddHook(3);
                }
                else if (key == hookKeys[4]) {
                    form.ResetHooks();
                }
                else if (key == hookKeys[5]) {
                    Application.Exit();
                }
                else if (key == hookKeys[6]) {
                    /*MessageBox.Show(
                        "Controls:\n" +
                        "The following are the default keybinds, you may access the Keybinds.txt file to change them." +
                        "Numpad 0: Reset ALL Survivor hook states.\n" +
                        "Numpad 1-4: Add 1 to a Survivor's hook state. Going past 3 resets to 0.\n" +
                        "Numpad 7: Exit the program.\n",
                        "Numpad 9: Get to this menu\n" +
                        "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    StartForm settings = new StartForm(form, vars);
                    settings.Show();
                }
            }
        }
        return CallNextHookEx(_hookID, nCode, wParam, lParam);
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook,
        LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
        IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    private void InitializeComponent()
    {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(235, 9);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(40, 120);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HookCounter.Properties.Resources.HookIcon_R;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HookCounter.Properties.Resources.HookIcon_R;
            this.pictureBox2.Location = new System.Drawing.Point(0, 40);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HookCounter.Properties.Resources.SacrificedIcon;
            this.pictureBox3.Location = new System.Drawing.Point(0, 80);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Program
            // 
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Program";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

    }
}