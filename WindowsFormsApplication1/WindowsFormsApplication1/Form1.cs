using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        struct m_ship
        {
            public int cockpit ;
            public int Chassis ;
            public int LeftWing ;
            public int RightWing;
            public int Thrusters;
        }

        m_ship Current = new m_ship();

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
                    Current.cockpit = 0;
                    break;
                case 1:
                    CockpitBox.Image = Properties.Resources.CockpitTwo;
                    Current.cockpit = 1;
                    break;
                case 2:
                    CockpitBox.Image = Properties.Resources.CockpitThree;
                    Current.cockpit = 2;
                    break;
            }
        }

        private void ChassisCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChassisCombo.SelectedIndex)
            {
                case 0:
                    Chassisbox.Image = Properties.Resources.ChassisOne;
                    Current.Chassis = 0;
                    break;
                case 1:
                    Chassisbox.Image = Properties.Resources.ChassisTwo;
                    Current.Chassis = 1;
                    break;
                case 2:
                    Current.Chassis = 2;
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
                    Current.LeftWing = 0;
                    break;
                case 1:
                    LeftWingBox.Image = Properties.Resources.LeftWingTwo;
                    Current.LeftWing = 1;
                    break;
                case 2:
                    LeftWingBox.Image = Properties.Resources.LeftWingThree;
                    Current.LeftWing = 2;
                    break;
            }
        }

        private void RightWingCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RightWingCombo.SelectedIndex)
            {
                case 0:
                    RightWingBox.Image = Properties.Resources.RightWingOne;
                    Current.RightWing = 0;
                    break;
                case 1:
                    RightWingBox.Image = Properties.Resources.RightWingTwo;
                    Current.RightWing = 1;
                    break;
                case 2:
                    RightWingBox.Image = Properties.Resources.RightWingThree;
                    Current.RightWing = 2;
                    break;
            }
        }

        private void ThrusterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ThrusterCombo.SelectedIndex)
            {
                case 0:
                    ThrusterBox.Image = Properties.Resources.Thruster;
                    Current.Thrusters = 0;
                    break;
                case 1:
                    ThrusterBox.Image = Properties.Resources.ThrusterTwo;
                    Current.Thrusters = 1;
                    break;
                case 2:
                    ThrusterBox.Image = Properties.Resources.ThrusterThree;
                    Current.Thrusters = 2;
                    break;
            }
        }

        public void SaveFile()
        {
            FileStream fs = new FileStream("Ship.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(Current.cockpit);
            bw.Write(Current.Chassis);
            bw.Write(Current.LeftWing);
            bw.Write(Current.RightWing);
            bw.Write(Current.Thrusters);

            bw.Close();
            fs.Close();
        }

        public void LoadFile()
        {
            FileStream fs = new FileStream("Ship.bin",FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Current.cockpit = br.ReadInt32();
            Current.Chassis = br.ReadInt32();
            Current.LeftWing = br.ReadInt32();
            Current.RightWing = br.ReadInt32();
            Current.Thrusters = br.ReadInt32();

            br.Close();
            fs.Close();

            CockpitCombo.SelectedIndex = Current.cockpit;
            ChassisCombo.SelectedIndex = Current.Chassis;
            LeftWingCombo.SelectedIndex = Current.LeftWing;
            RightWingCombo.SelectedIndex = Current.RightWing;
            ThrusterCombo.SelectedIndex = Current.Thrusters;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadFile();

        }

    }
}
