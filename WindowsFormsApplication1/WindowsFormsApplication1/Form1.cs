using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void CockpitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CockpitCombo.SelectedIndex)
            {
                case 0:
                    CockpitBox.Image = Properties.Resources.CockpitOne;
                    break;
                case 1:
                    CockpitBox.Image = Properties.Resources.CockpitTwo;
                    break;
                case 2:
                    CockpitBox.Image = Properties.Resources.CockpitThree;
                    break;
            }
        }

        private void ChassisCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChassisCombo.SelectedIndex)
            {
                case 0:
                    Chassisbox.Image = Properties.Resources.ChassisOne;
                    break;
                case 1:
                    Chassisbox.Image = Properties.Resources.ChassisTwo;
                    break;
                case 2:
                    Chassisbox.Image = Properties.Resources.ChassisThree;
                    break;
            }
        }

        private void LeftWingCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LeftWingCombo.SelectedIndex)
            {
                case 0:
                    LeftWingBox.Image = Properties.Resources.LeftWingOne;
                    break;
                case 1:
                    LeftWingBox.Image = Properties.Resources.LeftWingTwo;
                    break;
                case 2:
                    LeftWingBox.Image = Properties.Resources.LeftWingThree;
                    break;
            }
        }

        private void RightWingCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RightWingCombo.SelectedIndex)
            {
                case 0:
                    RightWingBox.Image = Properties.Resources.RightWingOne;
                    break;
                case 1:
                    RightWingBox.Image = Properties.Resources.RightWingTwo;
                    break;
                case 2:
                    RightWingBox.Image = Properties.Resources.RightWingThree;
                    break;
            }
        }

        private void ThrusterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ThrusterCombo.SelectedIndex)
            {
                case 0:
                    ThrusterBox.Image = Properties.Resources.Thruster;
                    break;
                case 1:
                    ThrusterBox.Image = Properties.Resources.ThrusterTwo;
                    break;
                case 2:
                    ThrusterBox.Image = Properties.Resources.ThrusterThree;
                    break;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
