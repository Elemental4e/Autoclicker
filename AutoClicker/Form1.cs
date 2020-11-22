using System;
using MouseCommands;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Autoclicker : Form
    {
        private bool running = false;

        public Autoclicker()
        {
            InitializeComponent();
            HotKeyManager.RegisterHotKey(Keys.X, 0, 0);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);

        }

        private void BT_Start_Click(object sender, EventArgs e)
        {
            if (running)
            {
                running = false;
                TM_Clicktimer.Stop();
                BT_Start.Text = "Starten";
            }
            else
            {
                running = true;
                TM_Clicktimer.Start();
                BT_Start.Text = "Stoppen";
            }
        }

        private void TM_Clicktimer_Tick(object sender, EventArgs e)
        {
            TM_Clicktimer.Interval = (int)NUM_Secs.Value * 1000;

            if (RB_Linksklick.Checked)
            {
                Mouse.Click();
            }

            if (RB_Rechtsklick.Checked)
            {
                Mouse.RightClick();
            }
        }

        void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            BT_Start_Click(null, null);
        }
    }
}
