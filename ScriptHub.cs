using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace RoHaxxBlocks
{

    public partial class ScriptHub : Form
    {
        ExploitAPI module = new ExploitAPI();
        public ScriptHub()
        {
            InitializeComponent();
        }
        Point lastPoint;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoHaxxBlocks rhb = new RoHaxxBlocks();
            this.Hide();
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Arsenal_Click(object sender, EventArgs e)
        {
            if (module.isAPIAttached() == true)
            {
                WebClient wb = new WebClient();
                string Script = wb.DownloadString("https://raw.githubusercontent.com/DaCreeperGuy/RoHaxxBlocks/master/Script/Arsenal.lua");
                module.SendLuaScript(Script);
            }
        }

        private void BreakingPoint_Click(object sender, EventArgs e)
        {
            if (module.isAPIAttached() == true)
            {
                WebClient wb = new WebClient();
                string Script = wb.DownloadString("https://raw.githubusercontent.com/DaCreeperGuy/RoHaxxBlocks/master/Script/BreakingPoint.lua");
                module.SendLuaScript(Script);
            }
    }

        private void Bloxburg_Click(object sender, EventArgs e)
        {
            if (module.isAPIAttached() == true)
            {
                WebClient wb = new WebClient();
                string Script = wb.DownloadString("https://raw.githubusercontent.com/DaCreeperGuy/RoHaxxBlocks/master/Script/Bloxburg.lua");
                module.SendLuaScript(Script);
            }
        }

        private void PrisonLife_Click(object sender, EventArgs e)
        {
            if (module.isAPIAttached() == true)
            {
                WebClient wb = new WebClient();
                string Script = wb.DownloadString("https://raw.githubusercontent.com/DaCreeperGuy/RoHaxxBlocks/master/Script/PrisonLife.lua");
                module.SendLuaScript(Script);
            }
        }
    }
}
