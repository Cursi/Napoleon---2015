using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace JsonEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Nou
        {
            public string Q { get; set; }
            public string A { get; set; }
            public string B { get; set; }
            public string C { get; set; }
            public string D { get; set; }
            public int R { get; set; }
            public Nou(string q, string a, string b, string c, string d, int r)
            {
                Q = q;
                A = a;
                B = b;
                C = c;
                D = d;
                R = r;
            }
        }

        public string path = Application.StartupPath + @"\Napoleon_Data\Site\data.js";
       public string part1, part2;

        private void Form1_Load(object sender, EventArgs e)
        {
            string buba;
            

            StreamReader r = new StreamReader(path);
            buba = r.ReadToEnd();
            r.Close();
            //MessageBox.Show(buba);
            
            int j;

            for (j = 0; j <= buba.Length - 31; j++)
            {
                part1 += buba[j];
            }

                for (j = buba.Length - 30; j <= buba.Length - 1; j++)
                {
                    part2 += buba[j];
                }
              //  textBox1.Text = part1;
            
        }

        public int cor;

        private void label6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && (radioButton1.Checked==true || radioButton2.Checked==true || radioButton3.Checked==true || radioButton4.Checked==true))
            {
                
                if (radioButton1.Checked == true) cor = Convert.ToInt32(radioButton1.Text);
                if (radioButton2.Checked == true) cor = Convert.ToInt32(radioButton2.Text);
                if (radioButton3.Checked == true) cor = Convert.ToInt32(radioButton3.Text);
                if (radioButton4.Checked == true) cor = Convert.ToInt32(radioButton4.Text);
                cor--;

                Nou variabila = new Nou(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text, cor);
                var result = JsonConvert.SerializeObject(variabila);
                string x = result;
                string x2="";
                for (int i = 0; i <= x.Length - 1; i++)
                {   x2 += x[i];
                    if (x[i] == ',') x2 += Environment.NewLine; 
                }

                     x = Environment.NewLine + ",";
                    x += x2;
                    part1 += x;
                    part1 += part2;

                    StreamWriter wr = new StreamWriter(path);
                    wr.Write(part1);
                    wr.Close();

                    this.Close();
            }
        }
    }
}
