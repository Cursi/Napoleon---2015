using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace JsonEdit
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public SoundPlayer s = new SoundPlayer(JsonEdit.Properties.Resources.help);

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            s.Play();   
            MessageBox.Show("This is the control-panel for the questions that are used in the web page," + Environment.NewLine + "where you can add or edit the questions.", "Help");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
