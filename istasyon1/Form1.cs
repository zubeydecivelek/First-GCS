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
using System.Threading;

namespace istasyon1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        int counter = 0;
        string[] Veri;

        private void button1_Click_1(object sender, EventArgs e)
        {
            string File_path = "C:\\Users\\zubey\\Desktop\\İHA\\Yer İstasyonu Yazılım ödevi\\2021Cervos yarışma verileri.txt";

            Veri = File.ReadAllLines(File_path);

            timer2.Start();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer2.Interval = 300;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string islenecek_veri = Veri[counter];
            richTextBox1.Text = islenecek_veri.ToString();
            string[] splitVeri = islenecek_veri.Split(',');
            takım_no_box.Text = splitVeri[0].ToString();
            paketNo_box.Text = splitVeri[1].ToString();
            zaman_box.Text = splitVeri[2].ToString();
            pil_Box.Text = splitVeri[7].ToString();
            roll_box.Text = splitVeri[12].ToString();
            pitch_box.Text = splitVeri[13].ToString();
            yaw_box.Text = splitVeri[14].ToString();

            chartTool.Series["Sıcaklık"].Points.AddXY(splitVeri[2], splitVeri[6]);
            chart2.Series["Basınç"].Points.AddXY(splitVeri[2], splitVeri[3]);

            if (counter < Veri.Length)
            {
                counter++;
            }
        }

       
    }
}
