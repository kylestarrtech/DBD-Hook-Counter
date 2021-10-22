using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HookCounter {
    public partial class PanelName : Form {

        StartForm settingsForm;

        public PanelName(StartForm _settingsForm) {
            InitializeComponent();
            settingsForm = _settingsForm;
        }

        private void PanelName_Load(object sender, EventArgs e) {

        }

        private void setPanelNameLabel_Click(object sender, EventArgs e) {
            settingsForm.SetNewProfile(name.Text);
            settingsForm.Show();
            this.Close();
        }

        private void MouseEnterLabel(object sender, EventArgs e) {
            Label label = (Label)sender;
            Color lCol = label.BackColor;
            int r, g, b;
            if (lCol.R + 10 > 255) { r = 255; } else { r = lCol.R + 10; }
            if (lCol.G + 10 > 255) { g = 255; } else { g = lCol.G + 10; }
            if (lCol.B + 10 > 255) { b = 255; } else { b = lCol.B + 10; }
            label.BackColor = Color.FromArgb(r, g, b);
        }

        private void MouseLeaveLabel(object sender, EventArgs e) {
            Label label = (Label)sender;
            Color lCol = label.BackColor;
            int r, g, b;
            if (lCol.R - 10 < 0) { r = 0; } else { r = lCol.R - 10; }
            if (lCol.G - 10 < 0) { g = 0; } else { g = lCol.G - 10; }
            if (lCol.B - 10 < 0) { b = 0; } else { b = lCol.B - 10; }
            label.BackColor = Color.FromArgb(r, g, b);
        }

        private void FocusEnterTextbox(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            Color lCol = textBox.BackColor;
            int r, g, b;
            if (lCol.R + 10 > 255) { r = 255; } else { r = lCol.R + 10; }
            if (lCol.G + 10 > 255) { g = 255; } else { g = lCol.G + 10; }
            if (lCol.B + 10 > 255) { b = 255; } else { b = lCol.B + 10; }
            textBox.BackColor = Color.FromArgb(r, g, b);
        }

        private void FocusLeaveTextbox(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            Color lCol = textBox.BackColor;
            int r, g, b;
            if (lCol.R - 10 < 0) { r = 0; } else { r = lCol.R - 10; }
            if (lCol.G - 10 < 0) { g = 0; } else { g = lCol.G - 10; }
            if (lCol.B - 10 < 0) { b = 0; } else { b = lCol.B - 10; }
            textBox.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
