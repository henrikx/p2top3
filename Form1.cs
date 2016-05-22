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


namespace P2_to_P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string csv = File.ReadAllText(textBox1.Text);
            csv = csv.Replace("GPS", "P-GPS");
            File.WriteAllText(textBox1.Text, csv);
            Chilkat.Csv chcsv = new Chilkat.Csv();

            bool load = chcsv.LoadFile(textBox1.Text);
            if (load = !true)
            {
                MessageBox.Show("load failed!");
            }
            int lineCount = File.ReadLines(textBox1.Text).Count();
            MessageBox.Show("There are " + lineCount + " lines");
            progressBar1.Maximum = lineCount;
            for (int i = 1; i <= lineCount-1; i++)
            {
                bool setcelltest = chcsv.SetCell(i, 50, "4");
                progressBar1.Value = i;
            }
            chcsv.SetCell(1, 52, textBox2.Text);
            MessageBox.Show("Done converting! Upload to HealthyDrones and enjoy!");
            bool savetest = chcsv.SaveFile(textBox1.Text);
        }
    }
}