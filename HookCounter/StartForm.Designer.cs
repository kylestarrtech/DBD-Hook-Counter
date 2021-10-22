namespace HookCounter
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleBar = new System.Windows.Forms.Label();
            this.saveSettings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hookIconX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hookIconY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.survivorPadding = new System.Windows.Forms.TextBox();
            this.survivorHotkey1Text = new System.Windows.Forms.Label();
            this.survivorHotkey1 = new System.Windows.Forms.TextBox();
            this.survivorHotkey3 = new System.Windows.Forms.TextBox();
            this.survivorHotkey3Text = new System.Windows.Forms.Label();
            this.survivorHotkey4 = new System.Windows.Forms.TextBox();
            this.survivorHotkey4Text = new System.Windows.Forms.Label();
            this.resetSurvivorsHotkey = new System.Windows.Forms.TextBox();
            this.resetSurvivorsHotkeyText = new System.Windows.Forms.Label();
            this.settingsHotkey = new System.Windows.Forms.TextBox();
            this.settingsHotkeyText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chromaKeyR = new System.Windows.Forms.TextBox();
            this.chromaKeyRText = new System.Windows.Forms.Label();
            this.chromaKeyG = new System.Windows.Forms.TextBox();
            this.chromaKeyGText = new System.Windows.Forms.Label();
            this.chromaKeyB = new System.Windows.Forms.TextBox();
            this.chromaKeyBText = new System.Windows.Forms.Label();
            this.creditsText = new System.Windows.Forms.Label();
            this.exitHotkey = new System.Windows.Forms.TextBox();
            this.exitHotkeyText = new System.Windows.Forms.Label();
            this.appVersionText = new System.Windows.Forms.Label();
            this.chromaKeyPreviewText = new System.Windows.Forms.Label();
            this.hookPreview1 = new System.Windows.Forms.PictureBox();
            this.hookPreview2 = new System.Windows.Forms.PictureBox();
            this.hookPreview3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveNewProfile = new System.Windows.Forms.Label();
            this.saveToProfile = new System.Windows.Forms.Label();
            this.deleteProfile = new System.Windows.Forms.Label();
            this.serverURLTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ServerHelpText = new System.Windows.Forms.Label();
            this.survivorHotkey2Text = new System.Windows.Forms.Label();
            this.survivorHotkey2 = new System.Windows.Forms.TextBox();
            this.sendDataHotkey = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.loadProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hookPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hookPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hookPreview3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TitleBar.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.Color.White;
            this.TitleBar.Location = new System.Drawing.Point(1, 1);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(598, 32);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Text = "Stream Hook Counter - Settings Menu";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggableMouseDown);
            this.TitleBar.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.TitleBar.MouseLeave += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.Color.Green;
            this.saveSettings.Font = new System.Drawing.Font("Roboto Cn", 11F);
            this.saveSettings.ForeColor = System.Drawing.Color.White;
            this.saveSettings.Location = new System.Drawing.Point(205, 330);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(226, 36);
            this.saveSettings.TabIndex = 2;
            this.saveSettings.Text = "LMB: Save Settings\r\nRMB: Reset to Default";
            this.saveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveSettings_MouseClick);
            this.saveSettings.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.saveSettings.MouseLeave += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hook Icon Size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hookIconX
            // 
            this.hookIconX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.hookIconX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hookIconX.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.hookIconX.ForeColor = System.Drawing.Color.White;
            this.hookIconX.Location = new System.Drawing.Point(259, 63);
            this.hookIconX.MaxLength = 3;
            this.hookIconX.Name = "hookIconX";
            this.hookIconX.ReadOnly = true;
            this.hookIconX.Size = new System.Drawing.Size(46, 20);
            this.hookIconX.TabIndex = 4;
            this.hookIconX.Text = "50";
            this.hookIconX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hookIconX.Click += new System.EventHandler(this.SetTextBoxToReadOnlyFalseAfterClick);
            this.hookIconX.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.hookIconX.Leave += new System.EventHandler(this.CheckIfDigit);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(309, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hookIconY
            // 
            this.hookIconY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.hookIconY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hookIconY.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.hookIconY.ForeColor = System.Drawing.Color.White;
            this.hookIconY.Location = new System.Drawing.Point(333, 62);
            this.hookIconY.MaxLength = 3;
            this.hookIconY.Name = "hookIconY";
            this.hookIconY.ReadOnly = true;
            this.hookIconY.Size = new System.Drawing.Size(46, 20);
            this.hookIconY.TabIndex = 6;
            this.hookIconY.Text = "102";
            this.hookIconY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hookIconY.Click += new System.EventHandler(this.SetTextBoxToReadOnlyFalseAfterClick);
            this.hookIconY.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.hookIconY.Leave += new System.EventHandler(this.CheckIfDigit);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Survivor Padding:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // survivorPadding
            // 
            this.survivorPadding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.survivorPadding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.survivorPadding.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.survivorPadding.ForeColor = System.Drawing.Color.White;
            this.survivorPadding.Location = new System.Drawing.Point(205, 119);
            this.survivorPadding.MaxLength = 3;
            this.survivorPadding.Name = "survivorPadding";
            this.survivorPadding.ReadOnly = true;
            this.survivorPadding.Size = new System.Drawing.Size(226, 20);
            this.survivorPadding.TabIndex = 8;
            this.survivorPadding.Text = "130";
            this.survivorPadding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.survivorPadding.Click += new System.EventHandler(this.SetTextBoxToReadOnlyFalseAfterClick);
            this.survivorPadding.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.survivorPadding.Leave += new System.EventHandler(this.CheckIfDigit);
            // 
            // survivorHotkey1Text
            // 
            this.survivorHotkey1Text.BackColor = System.Drawing.Color.Transparent;
            this.survivorHotkey1Text.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivorHotkey1Text.ForeColor = System.Drawing.Color.White;
            this.survivorHotkey1Text.Location = new System.Drawing.Point(445, 34);
            this.survivorHotkey1Text.Name = "survivorHotkey1Text";
            this.survivorHotkey1Text.Size = new System.Drawing.Size(151, 20);
            this.survivorHotkey1Text.TabIndex = 9;
            this.survivorHotkey1Text.Text = "Survivor #1 Hotkey:";
            this.survivorHotkey1Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // survivorHotkey1
            // 
            this.survivorHotkey1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.survivorHotkey1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.survivorHotkey1.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.survivorHotkey1.ForeColor = System.Drawing.Color.White;
            this.survivorHotkey1.Location = new System.Drawing.Point(449, 57);
            this.survivorHotkey1.MaxLength = 1000;
            this.survivorHotkey1.Name = "survivorHotkey1";
            this.survivorHotkey1.ReadOnly = true;
            this.survivorHotkey1.Size = new System.Drawing.Size(147, 20);
            this.survivorHotkey1.TabIndex = 10;
            this.survivorHotkey1.Text = "NumPad1";
            this.survivorHotkey1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.survivorHotkey1.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.survivorHotkey1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKeyTextbox);
            this.survivorHotkey1.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // survivorHotkey3
            // 
            this.survivorHotkey3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.survivorHotkey3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.survivorHotkey3.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.survivorHotkey3.ForeColor = System.Drawing.Color.White;
            this.survivorHotkey3.Location = new System.Drawing.Point(449, 151);
            this.survivorHotkey3.MaxLength = 1000;
            this.survivorHotkey3.Name = "survivorHotkey3";
            this.survivorHotkey3.Size = new System.Drawing.Size(147, 20);
            this.survivorHotkey3.TabIndex = 14;
            this.survivorHotkey3.Text = "NumPad3";
            this.survivorHotkey3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.survivorHotkey3.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.survivorHotkey3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKeyTextbox);
            this.survivorHotkey3.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // survivorHotkey3Text
            // 
            this.survivorHotkey3Text.BackColor = System.Drawing.Color.Transparent;
            this.survivorHotkey3Text.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivorHotkey3Text.ForeColor = System.Drawing.Color.White;
            this.survivorHotkey3Text.Location = new System.Drawing.Point(445, 126);
            this.survivorHotkey3Text.Name = "survivorHotkey3Text";
            this.survivorHotkey3Text.Size = new System.Drawing.Size(151, 20);
            this.survivorHotkey3Text.TabIndex = 13;
            this.survivorHotkey3Text.Text = "Survivor #3 Hotkey:";
            this.survivorHotkey3Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // survivorHotkey4
            // 
            this.survivorHotkey4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.survivorHotkey4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.survivorHotkey4.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.survivorHotkey4.ForeColor = System.Drawing.Color.White;
            this.survivorHotkey4.Location = new System.Drawing.Point(449, 197);
            this.survivorHotkey4.MaxLength = 1000;
            this.survivorHotkey4.Name = "survivorHotkey4";
            this.survivorHotkey4.Size = new System.Drawing.Size(147, 20);
            this.survivorHotkey4.TabIndex = 16;
            this.survivorHotkey4.Text = "NumPad4";
            this.survivorHotkey4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.survivorHotkey4.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.survivorHotkey4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKeyTextbox);
            this.survivorHotkey4.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // survivorHotkey4Text
            // 
            this.survivorHotkey4Text.BackColor = System.Drawing.Color.Transparent;
            this.survivorHotkey4Text.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivorHotkey4Text.ForeColor = System.Drawing.Color.White;
            this.survivorHotkey4Text.Location = new System.Drawing.Point(447, 174);
            this.survivorHotkey4Text.Name = "survivorHotkey4Text";
            this.survivorHotkey4Text.Size = new System.Drawing.Size(151, 20);
            this.survivorHotkey4Text.TabIndex = 15;
            this.survivorHotkey4Text.Text = "Survivor #4 Hotkey:";
            this.survivorHotkey4Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resetSurvivorsHotkey
            // 
            this.resetSurvivorsHotkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.resetSurvivorsHotkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resetSurvivorsHotkey.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.resetSurvivorsHotkey.ForeColor = System.Drawing.Color.White;
            this.resetSurvivorsHotkey.Location = new System.Drawing.Point(449, 243);
            this.resetSurvivorsHotkey.MaxLength = 1000;
            this.resetSurvivorsHotkey.Name = "resetSurvivorsHotkey";
            this.resetSurvivorsHotkey.Size = new System.Drawing.Size(147, 20);
            this.resetSurvivorsHotkey.TabIndex = 18;
            this.resetSurvivorsHotkey.Text = "NumPad0";
            this.resetSurvivorsHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetSurvivorsHotkey.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.resetSurvivorsHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKeyTextbox);
            this.resetSurvivorsHotkey.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // resetSurvivorsHotkeyText
            // 
            this.resetSurvivorsHotkeyText.BackColor = System.Drawing.Color.Transparent;
            this.resetSurvivorsHotkeyText.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetSurvivorsHotkeyText.ForeColor = System.Drawing.Color.White;
            this.resetSurvivorsHotkeyText.Location = new System.Drawing.Point(445, 220);
            this.resetSurvivorsHotkeyText.Name = "resetSurvivorsHotkeyText";
            this.resetSurvivorsHotkeyText.Size = new System.Drawing.Size(151, 20);
            this.resetSurvivorsHotkeyText.TabIndex = 17;
            this.resetSurvivorsHotkeyText.Text = "Reset Hotkey:";
            this.resetSurvivorsHotkeyText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsHotkey
            // 
            this.settingsHotkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settingsHotkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.settingsHotkey.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.settingsHotkey.ForeColor = System.Drawing.Color.White;
            this.settingsHotkey.Location = new System.Drawing.Point(449, 289);
            this.settingsHotkey.MaxLength = 1000;
            this.settingsHotkey.Name = "settingsHotkey";
            this.settingsHotkey.Size = new System.Drawing.Size(147, 20);
            this.settingsHotkey.TabIndex = 20;
            this.settingsHotkey.Text = "NumPad9";
            this.settingsHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.settingsHotkey.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.settingsHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKeyTextbox);
            this.settingsHotkey.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // settingsHotkeyText
            // 
            this.settingsHotkeyText.BackColor = System.Drawing.Color.Transparent;
            this.settingsHotkeyText.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsHotkeyText.ForeColor = System.Drawing.Color.White;
            this.settingsHotkeyText.Location = new System.Drawing.Point(445, 266);
            this.settingsHotkeyText.Name = "settingsHotkeyText";
            this.settingsHotkeyText.Size = new System.Drawing.Size(151, 20);
            this.settingsHotkeyText.TabIndex = 19;
            this.settingsHotkeyText.Text = "Settings Hotkey:";
            this.settingsHotkeyText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HookCounter.Properties.Resources.Divider;
            this.pictureBox1.Location = new System.Drawing.Point(440, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(203, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Chroma Key Color:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chromaKeyR
            // 
            this.chromaKeyR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chromaKeyR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chromaKeyR.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.chromaKeyR.ForeColor = System.Drawing.Color.White;
            this.chromaKeyR.Location = new System.Drawing.Point(227, 173);
            this.chromaKeyR.MaxLength = 3;
            this.chromaKeyR.Name = "chromaKeyR";
            this.chromaKeyR.ReadOnly = true;
            this.chromaKeyR.Size = new System.Drawing.Size(46, 20);
            this.chromaKeyR.TabIndex = 24;
            this.chromaKeyR.Text = "0";
            this.chromaKeyR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chromaKeyR.Click += new System.EventHandler(this.SetTextBoxToReadOnlyFalseAfterClick);
            this.chromaKeyR.TextChanged += new System.EventHandler(this.RGBTextChanged);
            this.chromaKeyR.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.chromaKeyR.Leave += new System.EventHandler(this.CheckIfDigit);
            // 
            // chromaKeyRText
            // 
            this.chromaKeyRText.BackColor = System.Drawing.Color.Transparent;
            this.chromaKeyRText.Font = new System.Drawing.Font("Roboto Lt", 10F);
            this.chromaKeyRText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chromaKeyRText.Location = new System.Drawing.Point(203, 171);
            this.chromaKeyRText.Name = "chromaKeyRText";
            this.chromaKeyRText.Size = new System.Drawing.Size(22, 25);
            this.chromaKeyRText.TabIndex = 23;
            this.chromaKeyRText.Text = "R:";
            this.chromaKeyRText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chromaKeyG
            // 
            this.chromaKeyG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chromaKeyG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chromaKeyG.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.chromaKeyG.ForeColor = System.Drawing.Color.White;
            this.chromaKeyG.Location = new System.Drawing.Point(303, 172);
            this.chromaKeyG.MaxLength = 3;
            this.chromaKeyG.Name = "chromaKeyG";
            this.chromaKeyG.ReadOnly = true;
            this.chromaKeyG.Size = new System.Drawing.Size(46, 20);
            this.chromaKeyG.TabIndex = 26;
            this.chromaKeyG.Text = "255";
            this.chromaKeyG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chromaKeyG.Click += new System.EventHandler(this.SetTextBoxToReadOnlyFalseAfterClick);
            this.chromaKeyG.TextChanged += new System.EventHandler(this.RGBTextChanged);
            this.chromaKeyG.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.chromaKeyG.Leave += new System.EventHandler(this.CheckIfDigit);
            // 
            // chromaKeyGText
            // 
            this.chromaKeyGText.BackColor = System.Drawing.Color.Transparent;
            this.chromaKeyGText.Font = new System.Drawing.Font("Roboto Lt", 10F);
            this.chromaKeyGText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chromaKeyGText.Location = new System.Drawing.Point(279, 170);
            this.chromaKeyGText.Name = "chromaKeyGText";
            this.chromaKeyGText.Size = new System.Drawing.Size(22, 25);
            this.chromaKeyGText.TabIndex = 25;
            this.chromaKeyGText.Text = "G:";
            this.chromaKeyGText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chromaKeyB
            // 
            this.chromaKeyB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chromaKeyB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chromaKeyB.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.chromaKeyB.ForeColor = System.Drawing.Color.White;
            this.chromaKeyB.Location = new System.Drawing.Point(379, 173);
            this.chromaKeyB.MaxLength = 3;
            this.chromaKeyB.Name = "chromaKeyB";
            this.chromaKeyB.ReadOnly = true;
            this.chromaKeyB.Size = new System.Drawing.Size(46, 20);
            this.chromaKeyB.TabIndex = 28;
            this.chromaKeyB.Text = "0";
            this.chromaKeyB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chromaKeyB.Click += new System.EventHandler(this.SetTextBoxToReadOnlyFalseAfterClick);
            this.chromaKeyB.TextChanged += new System.EventHandler(this.RGBTextChanged);
            this.chromaKeyB.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.chromaKeyB.Leave += new System.EventHandler(this.CheckIfDigit);
            // 
            // chromaKeyBText
            // 
            this.chromaKeyBText.BackColor = System.Drawing.Color.Transparent;
            this.chromaKeyBText.Font = new System.Drawing.Font("Roboto Lt", 10F);
            this.chromaKeyBText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chromaKeyBText.Location = new System.Drawing.Point(355, 171);
            this.chromaKeyBText.Name = "chromaKeyBText";
            this.chromaKeyBText.Size = new System.Drawing.Size(22, 25);
            this.chromaKeyBText.TabIndex = 27;
            this.chromaKeyBText.Text = "B:";
            this.chromaKeyBText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditsText
            // 
            this.creditsText.BackColor = System.Drawing.Color.Transparent;
            this.creditsText.Font = new System.Drawing.Font("Roboto Lt", 8F);
            this.creditsText.ForeColor = System.Drawing.Color.White;
            this.creditsText.Location = new System.Drawing.Point(9, 369);
            this.creditsText.Name = "creditsText";
            this.creditsText.Size = new System.Drawing.Size(180, 22);
            this.creditsText.TabIndex = 29;
            this.creditsText.Text = "Made by SHADERS and Vykri";
            this.creditsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitHotkey
            // 
            this.exitHotkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.exitHotkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exitHotkey.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.exitHotkey.ForeColor = System.Drawing.Color.White;
            this.exitHotkey.Location = new System.Drawing.Point(449, 335);
            this.exitHotkey.MaxLength = 1000;
            this.exitHotkey.Name = "exitHotkey";
            this.exitHotkey.Size = new System.Drawing.Size(147, 20);
            this.exitHotkey.TabIndex = 31;
            this.exitHotkey.Text = "NumPad7";
            this.exitHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitHotkey.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.exitHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKeyTextbox);
            this.exitHotkey.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // exitHotkeyText
            // 
            this.exitHotkeyText.BackColor = System.Drawing.Color.Transparent;
            this.exitHotkeyText.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitHotkeyText.ForeColor = System.Drawing.Color.White;
            this.exitHotkeyText.Location = new System.Drawing.Point(445, 312);
            this.exitHotkeyText.Name = "exitHotkeyText";
            this.exitHotkeyText.Size = new System.Drawing.Size(151, 20);
            this.exitHotkeyText.TabIndex = 30;
            this.exitHotkeyText.Text = "Exit Hotkey:";
            this.exitHotkeyText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // appVersionText
            // 
            this.appVersionText.BackColor = System.Drawing.Color.Transparent;
            this.appVersionText.Font = new System.Drawing.Font("Roboto Lt", 8F);
            this.appVersionText.ForeColor = System.Drawing.Color.White;
            this.appVersionText.Location = new System.Drawing.Point(9, 350);
            this.appVersionText.Name = "appVersionText";
            this.appVersionText.Size = new System.Drawing.Size(180, 16);
            this.appVersionText.TabIndex = 32;
            this.appVersionText.Text = "Application Version: v{VERSION}";
            this.appVersionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chromaKeyPreviewText
            // 
            this.chromaKeyPreviewText.BackColor = System.Drawing.Color.Transparent;
            this.chromaKeyPreviewText.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromaKeyPreviewText.ForeColor = System.Drawing.Color.White;
            this.chromaKeyPreviewText.Location = new System.Drawing.Point(201, 202);
            this.chromaKeyPreviewText.Name = "chromaKeyPreviewText";
            this.chromaKeyPreviewText.Size = new System.Drawing.Size(230, 25);
            this.chromaKeyPreviewText.TabIndex = 34;
            this.chromaKeyPreviewText.Text = "Chroma Key Preview:";
            this.chromaKeyPreviewText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hookPreview1
            // 
            this.hookPreview1.BackColor = System.Drawing.Color.Lime;
            this.hookPreview1.Image = global::HookCounter.Properties.Resources.HookIcon;
            this.hookPreview1.Location = new System.Drawing.Point(205, 227);
            this.hookPreview1.Name = "hookPreview1";
            this.hookPreview1.Size = new System.Drawing.Size(76, 40);
            this.hookPreview1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hookPreview1.TabIndex = 35;
            this.hookPreview1.TabStop = false;
            // 
            // hookPreview2
            // 
            this.hookPreview2.BackColor = System.Drawing.Color.Lime;
            this.hookPreview2.Image = global::HookCounter.Properties.Resources.HookIcon;
            this.hookPreview2.Location = new System.Drawing.Point(280, 227);
            this.hookPreview2.Name = "hookPreview2";
            this.hookPreview2.Size = new System.Drawing.Size(76, 40);
            this.hookPreview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hookPreview2.TabIndex = 36;
            this.hookPreview2.TabStop = false;
            // 
            // hookPreview3
            // 
            this.hookPreview3.BackColor = System.Drawing.Color.Lime;
            this.hookPreview3.Image = global::HookCounter.Properties.Resources.HookIcon;
            this.hookPreview3.Location = new System.Drawing.Point(355, 227);
            this.hookPreview3.Name = "hookPreview3";
            this.hookPreview3.Size = new System.Drawing.Size(76, 40);
            this.hookPreview3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hookPreview3.TabIndex = 37;
            this.hookPreview3.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Discard Changed Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.CloseForm);
            this.label1.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.label1.MouseLeave += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // profilePanel
            // 
            this.profilePanel.AutoScroll = true;
            this.profilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.profilePanel.Location = new System.Drawing.Point(5, 60);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(184, 170);
            this.profilePanel.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Profiles:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HookCounter.Properties.Resources.Divider;
            this.pictureBox2.Location = new System.Drawing.Point(195, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 349);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // saveNewProfile
            // 
            this.saveNewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveNewProfile.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.saveNewProfile.ForeColor = System.Drawing.Color.White;
            this.saveNewProfile.Location = new System.Drawing.Point(5, 261);
            this.saveNewProfile.Name = "saveNewProfile";
            this.saveNewProfile.Size = new System.Drawing.Size(184, 25);
            this.saveNewProfile.TabIndex = 43;
            this.saveNewProfile.Text = "Save as New Profile";
            this.saveNewProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveNewProfile.Click += new System.EventHandler(this.SaveAsNewProfile);
            this.saveNewProfile.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.saveNewProfile.MouseLeave += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // saveToProfile
            // 
            this.saveToProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveToProfile.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.saveToProfile.ForeColor = System.Drawing.Color.White;
            this.saveToProfile.Location = new System.Drawing.Point(5, 289);
            this.saveToProfile.Name = "saveToProfile";
            this.saveToProfile.Size = new System.Drawing.Size(184, 25);
            this.saveToProfile.TabIndex = 44;
            this.saveToProfile.Text = "Save to Selected Profile";
            this.saveToProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveToProfile.Click += new System.EventHandler(this.SaveToProfile);
            this.saveToProfile.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.saveToProfile.MouseLeave += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // deleteProfile
            // 
            this.deleteProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteProfile.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.deleteProfile.ForeColor = System.Drawing.Color.White;
            this.deleteProfile.Location = new System.Drawing.Point(5, 317);
            this.deleteProfile.Name = "deleteProfile";
            this.deleteProfile.Size = new System.Drawing.Size(184, 25);
            this.deleteProfile.TabIndex = 45;
            this.deleteProfile.Text = "Delete Selected Profile";
            this.deleteProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteProfile.Click += new System.EventHandler(this.DeleteProfile);
            this.deleteProfile.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.deleteProfile.MouseLeave += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // serverURLTextbox
            // 
            this.serverURLTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.serverURLTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverURLTextbox.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.serverURLTextbox.ForeColor = System.Drawing.Color.White;
            this.serverURLTextbox.Location = new System.Drawing.Point(205, 294);
            this.serverURLTextbox.MaxLength = 50;
            this.serverURLTextbox.Name = "serverURLTextbox";
            this.serverURLTextbox.Size = new System.Drawing.Size(226, 20);
            this.serverURLTextbox.TabIndex = 46;
            this.serverURLTextbox.Text = "http://localhost:3000";
            this.serverURLTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(205, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "Web Server URL:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerHelpText
            // 
            this.ServerHelpText.BackColor = System.Drawing.Color.Transparent;
            this.ServerHelpText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServerHelpText.Font = new System.Drawing.Font("Roboto Lt", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerHelpText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ServerHelpText.Location = new System.Drawing.Point(205, 314);
            this.ServerHelpText.Name = "ServerHelpText";
            this.ServerHelpText.Size = new System.Drawing.Size(228, 12);
            this.ServerHelpText.TabIndex = 48;
            this.ServerHelpText.Text = "What does this mean?";
            this.ServerHelpText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ServerHelpText.Click += new System.EventHandler(this.ServerHelpText_Click);
            // 
            // survivorHotkey2Text
            // 
            this.survivorHotkey2Text.BackColor = System.Drawing.Color.Transparent;
            this.survivorHotkey2Text.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivorHotkey2Text.ForeColor = System.Drawing.Color.White;
            this.survivorHotkey2Text.Location = new System.Drawing.Point(447, 80);
            this.survivorHotkey2Text.Name = "survivorHotkey2Text";
            this.survivorHotkey2Text.Size = new System.Drawing.Size(151, 20);
            this.survivorHotkey2Text.TabIndex = 11;
            this.survivorHotkey2Text.Text = "Survivor #2 Hotkey:";
            this.survivorHotkey2Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // survivorHotkey2
            // 
            this.survivorHotkey2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.survivorHotkey2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.survivorHotkey2.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.survivorHotkey2.ForeColor = System.Drawing.Color.White;
            this.survivorHotkey2.Location = new System.Drawing.Point(449, 103);
            this.survivorHotkey2.MaxLength = 1000;
            this.survivorHotkey2.Name = "survivorHotkey2";
            this.survivorHotkey2.Size = new System.Drawing.Size(147, 20);
            this.survivorHotkey2.TabIndex = 12;
            this.survivorHotkey2.Text = "NumPad2";
            this.survivorHotkey2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.survivorHotkey2.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.survivorHotkey2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKeyTextbox);
            this.survivorHotkey2.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // sendDataHotkey
            // 
            this.sendDataHotkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sendDataHotkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendDataHotkey.Font = new System.Drawing.Font("Roboto Lt", 12F);
            this.sendDataHotkey.ForeColor = System.Drawing.Color.White;
            this.sendDataHotkey.Location = new System.Drawing.Point(449, 381);
            this.sendDataHotkey.MaxLength = 1000;
            this.sendDataHotkey.Name = "sendDataHotkey";
            this.sendDataHotkey.Size = new System.Drawing.Size(147, 20);
            this.sendDataHotkey.TabIndex = 55;
            this.sendDataHotkey.Text = "NumPad8";
            this.sendDataHotkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sendDataHotkey.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.sendDataHotkey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SetKeyTextbox);
            this.sendDataHotkey.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(445, 358);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 20);
            this.label19.TabIndex = 54;
            this.label19.Text = "Send Data Hotkey:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loadProfile
            // 
            this.loadProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.loadProfile.Font = new System.Drawing.Font("Roboto Cn", 12F);
            this.loadProfile.ForeColor = System.Drawing.Color.White;
            this.loadProfile.Location = new System.Drawing.Point(5, 233);
            this.loadProfile.Name = "loadProfile";
            this.loadProfile.Size = new System.Drawing.Size(184, 25);
            this.loadProfile.TabIndex = 56;
            this.loadProfile.Text = "Load Selected Profile";
            this.loadProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadProfile.Click += new System.EventHandler(this.LoadProfile);
            this.loadProfile.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.loadProfile.MouseLeave += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.loadProfile);
            this.Controls.Add(this.sendDataHotkey);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ServerHelpText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.serverURLTextbox);
            this.Controls.Add(this.deleteProfile);
            this.Controls.Add(this.saveToProfile);
            this.Controls.Add(this.saveNewProfile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hookPreview3);
            this.Controls.Add(this.hookPreview2);
            this.Controls.Add(this.hookPreview1);
            this.Controls.Add(this.chromaKeyPreviewText);
            this.Controls.Add(this.appVersionText);
            this.Controls.Add(this.exitHotkey);
            this.Controls.Add(this.exitHotkeyText);
            this.Controls.Add(this.creditsText);
            this.Controls.Add(this.chromaKeyB);
            this.Controls.Add(this.chromaKeyBText);
            this.Controls.Add(this.chromaKeyG);
            this.Controls.Add(this.chromaKeyGText);
            this.Controls.Add(this.chromaKeyR);
            this.Controls.Add(this.chromaKeyRText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settingsHotkey);
            this.Controls.Add(this.settingsHotkeyText);
            this.Controls.Add(this.resetSurvivorsHotkey);
            this.Controls.Add(this.resetSurvivorsHotkeyText);
            this.Controls.Add(this.survivorHotkey4);
            this.Controls.Add(this.survivorHotkey4Text);
            this.Controls.Add(this.survivorHotkey3);
            this.Controls.Add(this.survivorHotkey3Text);
            this.Controls.Add(this.survivorHotkey2);
            this.Controls.Add(this.survivorHotkey2Text);
            this.Controls.Add(this.survivorHotkey1);
            this.Controls.Add(this.survivorHotkey1Text);
            this.Controls.Add(this.survivorPadding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hookIconY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hookIconX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "Hook Counter - Main Menu";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hookPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hookPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hookPreview3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleBar;
        private System.Windows.Forms.Label saveSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hookIconX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hookIconY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox survivorPadding;
        private System.Windows.Forms.Label survivorHotkey1Text;
        private System.Windows.Forms.TextBox survivorHotkey1;
        private System.Windows.Forms.TextBox survivorHotkey3;
        private System.Windows.Forms.Label survivorHotkey3Text;
        private System.Windows.Forms.TextBox survivorHotkey4;
        private System.Windows.Forms.Label survivorHotkey4Text;
        private System.Windows.Forms.TextBox resetSurvivorsHotkey;
        private System.Windows.Forms.Label resetSurvivorsHotkeyText;
        private System.Windows.Forms.TextBox settingsHotkey;
        private System.Windows.Forms.Label settingsHotkeyText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox chromaKeyR;
        private System.Windows.Forms.Label chromaKeyRText;
        private System.Windows.Forms.TextBox chromaKeyG;
        private System.Windows.Forms.Label chromaKeyGText;
        private System.Windows.Forms.TextBox chromaKeyB;
        private System.Windows.Forms.Label chromaKeyBText;
        private System.Windows.Forms.Label creditsText;
        private System.Windows.Forms.TextBox exitHotkey;
        private System.Windows.Forms.Label exitHotkeyText;
        private System.Windows.Forms.Label appVersionText;
        private System.Windows.Forms.Label chromaKeyPreviewText;
        private System.Windows.Forms.PictureBox hookPreview1;
        private System.Windows.Forms.PictureBox hookPreview2;
        private System.Windows.Forms.PictureBox hookPreview3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label saveNewProfile;
        private System.Windows.Forms.Label saveToProfile;
        private System.Windows.Forms.Label deleteProfile;
        private System.Windows.Forms.TextBox serverURLTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ServerHelpText;
        private System.Windows.Forms.Label survivorHotkey2Text;
        private System.Windows.Forms.TextBox survivorHotkey2;
        private System.Windows.Forms.TextBox sendDataHotkey;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label loadProfile;
    }
}