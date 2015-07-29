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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string path = Application.StartupPath + @"\login.txt";
        public string user, pass;
        public int counter=0;
        public string line;
        public SoundPlayer f = new SoundPlayer(JsonEdit.Properties.Resources.LoginFailed);
        public SoundPlayer s = new SoundPlayer(JsonEdit.Properties.Resources.LoginSucs);

        private void Form2_Load(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == user && textBox2.Text == pass)
            {
                s.Play();
                MessageBox.Show("Login successful.");
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
                
            }

            else
            {
                f.Play();
                MessageBox.Show("Login failed.");
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) label6_Click(this, e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) label6_Click(this, e);
        }
    }
}
