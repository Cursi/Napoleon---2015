using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JsonEdit
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string path = Application.StartupPath + @"\Napoleon_Data\Site\data.js";
        string tot;
        public string part1, part2,part3;

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader(path);
            tot = r.ReadToEnd();
            r.Close();
           
            int j;

                for (j = 0; j <= 41; j++)
                {
                    part2 += tot[j];
                }

                for (j = 42; j <= tot.Length - 31; j++)
                {
                    part1 += tot[j];
                }

            for (j = tot.Length - 30; j <= tot.Length - 1; j++)
            {
                part3 += tot[j];
            }

            richTextBox1.Text = part1;
            tot = "";

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            tot += part2;
            tot += richTextBox1.Text;
            tot += part3;

            StreamWriter raw = new StreamWriter(path);
            raw.Write(tot);
            raw.Close();
        }
    }
}
