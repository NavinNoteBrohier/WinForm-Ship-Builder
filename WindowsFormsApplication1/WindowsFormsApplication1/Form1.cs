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
    /// <contact>
    // Navin Brohier || AIE || navinnotebrohier.github.io || navin.brohier@gmail.com
    /// <contact>

    public partial class Form1 : Form
    {
        struct m_ship
        {
            public string name;
            public int cockpit;
            public int Chassis;
            public int LeftWing;
            public int RightWing;
            public int Thrusters;
        }

        struct PartListing
        {
            public int Cockpits;
            public int Chassis;
            public int LeftWings;
            public int RightWings;
            public int Thrusters;
            public int LeftWeapons;
            public int RightWeapons;
        }

        struct m_part
        {
            public string Name;
            public PartTypes type;
            public int HullPoints;
            public int WeaponDamage;
        }

        public enum PartTypes
        {
            cockpit,
            chassis,
            leftwing,
            rightwing,
            thruster,
            leftweapon,
            rightweapon,
            empty,
        }

       
        PartListing Parts = new PartListing();
        m_part Currentp = new m_part();
        m_ship Current = new m_ship();
        public string ShipFilePath = "";
        public string PartFilePath = "";
        

        public Form1()
        {
           InitializeComponent();
            try
            {
                FileStream fs = new FileStream("Settings.settings", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                ShipFilePath = br.ReadString();
                PartFilePath = br.ReadString();

                textBox1.Text = ShipFilePath;
                textBox2.Text = PartFilePath;
            }
            catch { };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //------------------------------ShipBuilder------------------------------
        private void CockpitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CockpitCombo.SelectedIndex)
            {
                case 0:
                //    CockpitBox.Image = Properties.Resources.CockpitOne;
                    Current.cockpit = 0;
                    break;
                case 1:
                //    CockpitBox.Image = Properties.Resources.CockpitTwo;
                    Current.cockpit = 1;
                    break;
                case 2:
                //    CockpitBox.Image = Properties.Resources.CockpitThree;
                    Current.cockpit = 2;
                    break;
            }
        }

        private void ChassisCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ChassisCombo.SelectedIndex)
            {
                case 0:
                //    Chassisbox.Image = Properties.Resources.ChassisOne;
                    Current.Chassis = 0;
                    break;
                case 1:
                 //   Chassisbox.Image = Properties.Resources.ChassisTwo;
                    Current.Chassis = 1;
                    break;
                case 2:
                    //   Chassisbox.Image = Properties.Resources.ChassisThree;
                    Current.Chassis = 2;
                    break;
            }
        }

        private void LeftWingCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LeftWingCombo.SelectedIndex)
            {
                case 0:
                //    LeftWingBox.Image = Properties.Resources.LeftWingOne;
                    Current.LeftWing = 0;
                    break;
                case 1:
                 //   LeftWingBox.Image = Properties.Resources.LeftWingTwo;
                    Current.LeftWing = 1;
                    break;
                case 2:
                //    LeftWingBox.Image = Properties.Resources.LeftWingThree;
                    Current.LeftWing = 2;
                    break;
            }
        }

        private void RightWingCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RightWingCombo.SelectedIndex)
            {
                case 0:
             //       RightWingBox.Image = Properties.Resources.RightWingOne;
                    Current.RightWing = 0;
                    break;
                case 1:
            //        RightWingBox.Image = Properties.Resources.RightWingTwo;
                    Current.RightWing = 1;
                    break;
                case 2:
            //        RightWingBox.Image = Properties.Resources.RightWingThree;
                    Current.RightWing = 2;
                    break;
            }
        }

        private void ThrusterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ThrusterCombo.SelectedIndex)
            {
                case 0:
            //        ThrusterBox.Image = Properties.Resources.Thruster;
                    Current.Thrusters = 0;
                    break;
                case 1:
            //        ThrusterBox.Image = Properties.Resources.ThrusterTwo;
                    Current.Thrusters = 1;
                    break;
                case 2:
           //         ThrusterBox.Image = Properties.Resources.ThrusterThree;
                    Current.Thrusters = 2;
                    break;
            }
        }

        private string FileName;

        public void SaveFile()
        {
            if (NameBox.Text != null) { FileName = NameBox.Text; }else { FileName = "Ship"; }
            FileStream fs = new FileStream(ShipFilePath + @"\" + FileName + ".ShipFile", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);


            bw.Write(NameBox.Text);
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
            try
            {
                if (NameBox.Text != null) { FileName = NameBox.Text; } else { FileName = "Ship"; }
                FileStream fs = new FileStream(ShipFilePath + @"\" + FileName + ".ShipFile", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                Current.name = br.ReadString();
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
                NameBox.Text = Current.name;
            }
            catch
            {
                MessageBox.Show("No file found");
                return;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
        //-----------------------------------------------------------------------


        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog1.ShowDialog();
            ShipFilePath = FolderBrowserDialog1.SelectedPath;
            textBox1.Text = ShipFilePath;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog1 = new FolderBrowserDialog();
            FolderBrowserDialog1.ShowDialog();
            PartFilePath = FolderBrowserDialog1.SelectedPath;
            textBox2.Text = PartFilePath ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Settings.settings", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(textBox1.Text);
            bw.Write(textBox2.Text);

            fs.Close();
            bw.Close();
        }

        public void LoadBrowse()
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.ShowDialog();
                FileStream fs = new FileStream(od.FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                Current.name = br.ReadString();
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
                NameBox.Text = Current.name;

            }

            catch
            {
                MessageBox.Show("Invalid File");
                return;
            }
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            LoadBrowse();
        }

        public void SavePartList()
        {
            FileStream fs = new FileStream("PartLib.atheneum", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(Parts.Cockpits);
            bw.Write(Parts.Chassis);
            bw.Write(Parts.LeftWings);
            bw.Write(Parts.RightWings);
            bw.Write(Parts.Thrusters);
            bw.Write(Parts.LeftWeapons);
            bw.Write(Parts.RightWeapons);
             
            fs.Close();
            bw.Close();
        }

        public void LoadPartList()
        {
            try
            {
                FileStream fs = new FileStream("Partlib.atheneum", FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                Parts.Cockpits = br.ReadInt32();
                Parts.Chassis = br.ReadInt32();
                Parts.LeftWings = br.ReadInt32();
                Parts.RightWings = br.ReadInt32();
                Parts.Thrusters = br.ReadInt32();
                Parts.LeftWeapons = br.ReadInt32();
                Parts.RightWeapons = br.ReadInt32();

                fs.Close();
                br.Close();
            }
            catch
            {
                MessageBox.Show("Missing or invalid file");
            }
        }
    
        public void SaveApart()
        {
            string FileNamePart;
            if (PartNameBox.Text != null) { FileNamePart = PartNameBox.Text; } else { FileNamePart = "part"; }
            FileStream fs = new FileStream(PartFilePath + @"\" + "00" + PartNameBox.Text + ".part",FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write((int)Currentp.type);
            bw.Write(Currentp.HullPoints);
            bw.Write(Currentp.WeaponDamage);
            bw.Write(Currentp.Name);

            fs.Close();
            bw.Close();
        }

        public void LoadApart()
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                od.ShowDialog();
                FileStream fs = new FileStream(od.FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);

                Currentp.type = (PartTypes)br.ReadInt32();
                Currentp.HullPoints = br.ReadInt32();
                Currentp.WeaponDamage = br.ReadInt32();
                Currentp.Name = br.ReadString();

                fs.Close();
                br.Close();
            }
            catch
            {
                MessageBox.Show("Missing or invalid file");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex)
            {
                case 0:
                    //CockpitBox.ImageLocation



                default:
                    break;
            }
        }

        private void SavePart_Click(object sender, EventArgs e)
        {
            SaveApart();
        }

        private void TypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(TypeCombo.SelectedIndex)
            {
                case 0:
                    Currentp.type = PartTypes.cockpit;
                    break;
                case 1:
                    Currentp.type = PartTypes.chassis;
                    break;
                case 2:
                    Currentp.type = PartTypes.leftwing;
                    break;
                case 3:
                    Currentp.type = PartTypes.rightwing;
                    break;
                case 4:
                    Currentp.type = PartTypes.thruster;
                    break;
                case 5:
                    Currentp.type = PartTypes.leftweapon;
                    break;
                case 6:
                    Currentp.type = PartTypes.rightweapon;
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadApart();
        }
    }
}
