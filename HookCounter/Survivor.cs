using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HookCounter
{

    /// <summary>Simply a class that holds basic information about a Survivor, their hook states and manages the front end for it.</summary>
    public class Survivor
    {
        public int hookStates;
        public Size hookSize;
        public FlowLayoutPanel hookPanel;
        PictureBox[] hookImgs;


        /// <param name="_hookStates">The # of hook states applied to the Survivor. Set to 0 by default, but you may override this if need be.</param>
        /// <param name="_hookSize">The size of the hook icon, (40, 40) is usually preferred.</param>
        public Survivor(int _hookStates, Size _hookSize)
        {
            hookStates = _hookStates;
            hookSize = _hookSize;

            hookPanel = new FlowLayoutPanel();
            InitializeHookPanel();

            hookImgs = new PictureBox[3];
            for (int i = 0; i < hookImgs.Length; i++)
            {
                hookImgs[i] = new PictureBox();
                hookImgs[i].Size = new Size(hookSize.Width, hookSize.Height);
                hookImgs[i].SizeMode = PictureBoxSizeMode.Zoom;
                hookImgs[i].Image = HookCounter.Properties.Resources.HookIcon_Straight;
                hookImgs[i].Padding = new Padding(0);
                hookImgs[i].Margin = new Padding(0);
                hookPanel.Controls.Add(hookImgs[i]);
                hookImgs[i].Show();
                hookImgs[i].Visible = true;
            }
            UpdateVisuals();
        }

        public void UpdateVisuals()
        {
            foreach (PictureBox hook in hookImgs)
            {
                hook.Image.Dispose();
                hook.Image = HookCounter.Properties.Resources.HookIcon_Straight_Translucent;
            }
            for (int i = 0; i < hookStates; i++)
            {
                if (hookStates != 0)
                {
                    hookImgs[i].Image = HookCounter.Properties.Resources.HookIcon_Straight;
                }
            }
        }

        public void InitializeHookPanel()
        {
            hookPanel.Size = new Size(hookSize.Width*3, hookSize.Height);
            hookPanel.Padding = new Padding(0);
            hookPanel.Margin = new Padding(0);
            hookPanel.Show();
            hookPanel.Visible = true;
        }
    }
}
