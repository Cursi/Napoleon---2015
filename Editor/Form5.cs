using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace JsonEdit
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public string path = Application.StartupPath + @"\login.txt";
        public string user, pass;
        public int counter = 0;
        public string line;
        public string tot="";

        public SoundPlayer s = new SoundPlayer(JsonEdit.Properties.Resources.passsucss);
        public SoundPlayer f = new SoundPlayer(JsonEdit.Properties.Resources.passfail);

        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == pass && textBox2.Text != "")
            {
                tot = user;
                tot += Environment.NewLine;
                tot += textBox2.Text;

                StreamWriter raw = new StreamWriter(path);
                raw.Write(tot);
                raw.Close();
                s.Play();
                MessageBox.Show("The password was changed.");
                this.Close();
            }

            else
            {
                f.Play();
                MessageBox.Show("The old password is wrong or the field for new password is empty.");
                this.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader(path);

            while ((line = r.ReadLine()) != null)
            {
                if (counter == 0) user = line;
                if (counter == 1) pass = line;
                counter++;
            }
            r.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) label3_Click(this, e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) label3_Click(this, e);
        }
    }
}
