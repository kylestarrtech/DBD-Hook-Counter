namespace HookCounter {
    partial class PanelName {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.setPanelNameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.setPanelNameLabel);
            this.panel1.Controls.Add(this.profileNameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 95);
            this.panel1.TabIndex = 0;
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileNameLabel.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameLabel.ForeColor = System.Drawing.Color.White;
            this.profileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(296, 32);
            this.profileNameLabel.TabIndex = 0;
            this.profileNameLabel.Text = "Profile Name:";
            this.profileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setPanelNameLabel
            // 
            this.setPanelNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setPanelNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.setPanelNameLabel.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPanelNameLabel.ForeColor = System.Drawing.Color.White;
            this.setPanelNameLabel.Location = new System.Drawing.Point(3, 66);
            this.setPanelNameLabel.Name = "setPanelNameLabel";
            this.setPanelNameLabel.Size = new System.Drawing.Size(290, 26);
            this.setPanelNameLabel.TabIndex = 1;
            this.setPanelNameLabel.Text = "Set";
            this.setPanelNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setPanelNameLabel.Click += new System.EventHandler(this.setPanelNameLabel_Click);
            this.setPanelNameLabel.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.setPanelNameLabel.MouseLeave += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(3, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(290, 29);
            this.name.TabIndex = 2;
            this.name.Text = "{PROFILENAME}";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Enter += new System.EventHandler(this.FocusEnterTextbox);
            this.name.Leave += new System.EventHandler(this.FocusLeaveTextbox);
            // 
            // PanelName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelName";
            this.Text = "Select Panel Name";
            this.Load += new System.EventHandler(this.PanelName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label setPanelNameLabel;
        private System.Windows.Forms.Label profileNameLabel;
    }
}