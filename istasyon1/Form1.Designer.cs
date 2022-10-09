namespace istasyon1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.takım_no_text = new System.Windows.Forms.Label();
            this.paket_no_text = new System.Windows.Forms.Label();
            this.zaman_text = new System.Windows.Forms.Label();
            this.pil_text = new System.Windows.Forms.Label();
            this.roll_text = new System.Windows.Forms.Label();
            this.pitch_text = new System.Windows.Forms.Label();
            this.yaw_text = new System.Windows.Forms.Label();
            this.paketNo_box = new System.Windows.Forms.TextBox();
            this.zaman_box = new System.Windows.Forms.TextBox();
            this.pil_Box = new System.Windows.Forms.TextBox();
            this.roll_box = new System.Windows.Forms.TextBox();
            this.pitch_box = new System.Windows.Forms.TextBox();
            this.yaw_box = new System.Windows.Forms.TextBox();
            this.takım_no_box = new System.Windows.Forms.RichTextBox();
            this.chartTool = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(822, 42);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // takım_no_text
            // 
            this.takım_no_text.AutoSize = true;
            this.takım_no_text.ForeColor = System.Drawing.Color.Maroon;
            this.takım_no_text.Location = new System.Drawing.Point(35, 110);
            this.takım_no_text.Name = "takım_no_text";
            this.takım_no_text.Size = new System.Drawing.Size(56, 13);
            this.takım_no_text.TabIndex = 2;
            this.takım_no_text.Text = "Takım No:";
            // 
            // paket_no_text
            // 
            this.paket_no_text.AutoSize = true;
            this.paket_no_text.ForeColor = System.Drawing.Color.Maroon;
            this.paket_no_text.Location = new System.Drawing.Point(270, 110);
            this.paket_no_text.Name = "paket_no_text";
            this.paket_no_text.Size = new System.Drawing.Size(85, 13);
            this.paket_no_text.TabIndex = 3;
            this.paket_no_text.Text = "Paket Numarası:";
            // 
            // zaman_text
            // 
            this.zaman_text.AutoSize = true;
            this.zaman_text.ForeColor = System.Drawing.Color.Maroon;
            this.zaman_text.Location = new System.Drawing.Point(566, 110);
            this.zaman_text.Name = "zaman_text";
            this.zaman_text.Size = new System.Drawing.Size(43, 13);
            this.zaman_text.TabIndex = 4;
            this.zaman_text.Text = "Zaman:";
            // 
            // pil_text
            // 
            this.pil_text.AutoSize = true;
            this.pil_text.ForeColor = System.Drawing.Color.Maroon;
            this.pil_text.Location = new System.Drawing.Point(35, 143);
            this.pil_text.Name = "pil_text";
            this.pil_text.Size = new System.Drawing.Size(57, 13);
            this.pil_text.TabIndex = 5;
            this.pil_text.Text = "Pil Gerilimi:";
            // 
            // roll_text
            // 
            this.roll_text.AutoSize = true;
            this.roll_text.ForeColor = System.Drawing.Color.Maroon;
            this.roll_text.Location = new System.Drawing.Point(273, 143);
            this.roll_text.Name = "roll_text";
            this.roll_text.Size = new System.Drawing.Size(28, 13);
            this.roll_text.TabIndex = 6;
            this.roll_text.Text = "Roll:";
            // 
            // pitch_text
            // 
            this.pitch_text.AutoSize = true;
            this.pitch_text.ForeColor = System.Drawing.Color.Maroon;
            this.pitch_text.Location = new System.Drawing.Point(569, 142);
            this.pitch_text.Name = "pitch_text";
            this.pitch_text.Size = new System.Drawing.Size(37, 13);
            this.pitch_text.TabIndex = 7;
            this.pitch_text.Text = "Pitch: ";
            // 
            // yaw_text
            // 
            this.yaw_text.AutoSize = true;
            this.yaw_text.ForeColor = System.Drawing.Color.Maroon;
            this.yaw_text.Location = new System.Drawing.Point(569, 168);
            this.yaw_text.Name = "yaw_text";
            this.yaw_text.Size = new System.Drawing.Size(31, 13);
            this.yaw_text.TabIndex = 8;
            this.yaw_text.Text = "Yaw:";
            // 
            // paketNo_box
            // 
            this.paketNo_box.Location = new System.Drawing.Point(362, 107);
            this.paketNo_box.Name = "paketNo_box";
            this.paketNo_box.Size = new System.Drawing.Size(100, 20);
            this.paketNo_box.TabIndex = 10;
            // 
            // zaman_box
            // 
            this.zaman_box.Location = new System.Drawing.Point(615, 107);
            this.zaman_box.Name = "zaman_box";
            this.zaman_box.Size = new System.Drawing.Size(100, 20);
            this.zaman_box.TabIndex = 11;
            // 
            // pil_Box
            // 
            this.pil_Box.Location = new System.Drawing.Point(99, 143);
            this.pil_Box.Name = "pil_Box";
            this.pil_Box.Size = new System.Drawing.Size(100, 20);
            this.pil_Box.TabIndex = 12;
            // 
            // roll_box
            // 
            this.roll_box.Location = new System.Drawing.Point(308, 142);
            this.roll_box.Name = "roll_box";
            this.roll_box.Size = new System.Drawing.Size(100, 20);
            this.roll_box.TabIndex = 13;
            // 
            // pitch_box
            // 
            this.pitch_box.Location = new System.Drawing.Point(615, 140);
            this.pitch_box.Name = "pitch_box";
            this.pitch_box.Size = new System.Drawing.Size(100, 20);
            this.pitch_box.TabIndex = 14;
            // 
            // yaw_box
            // 
            this.yaw_box.Location = new System.Drawing.Point(615, 168);
            this.yaw_box.Name = "yaw_box";
            this.yaw_box.Size = new System.Drawing.Size(100, 20);
            this.yaw_box.TabIndex = 15;
            // 
            // takım_no_box
            // 
            this.takım_no_box.Location = new System.Drawing.Point(99, 107);
            this.takım_no_box.Name = "takım_no_box";
            this.takım_no_box.Size = new System.Drawing.Size(113, 20);
            this.takım_no_box.TabIndex = 16;
            this.takım_no_box.Text = "";
            // 
            // chartTool
            // 
            this.chartTool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chartTool.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTool.Legends.Add(legend1);
            this.chartTool.Location = new System.Drawing.Point(12, 212);
            this.chartTool.Margin = new System.Windows.Forms.Padding(1);
            this.chartTool.Name = "chartTool";
            this.chartTool.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Sıcaklık";
            this.chartTool.Series.Add(series1);
            this.chartTool.Size = new System.Drawing.Size(320, 143);
            this.chartTool.TabIndex = 17;
            this.chartTool.Text = "chart_tool";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(378, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Basınç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(35, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sıcaklık";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(673, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "THARSIS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::istasyon1.Properties.Resources.Ekran_görüntüsü_2022_02_16_004225;
            this.pictureBox1.Location = new System.Drawing.Point(716, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 111);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(381, 212);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Basınç";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(302, 150);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(230, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Zaman:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(587, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Zaman:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 367);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartTool);
            this.Controls.Add(this.takım_no_box);
            this.Controls.Add(this.yaw_box);
            this.Controls.Add(this.pitch_box);
            this.Controls.Add(this.roll_box);
            this.Controls.Add(this.pil_Box);
            this.Controls.Add(this.zaman_box);
            this.Controls.Add(this.paketNo_box);
            this.Controls.Add(this.yaw_text);
            this.Controls.Add(this.pitch_text);
            this.Controls.Add(this.roll_text);
            this.Controls.Add(this.pil_text);
            this.Controls.Add(this.zaman_text);
            this.Controls.Add(this.paket_no_text);
            this.Controls.Add(this.takım_no_text);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chartTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox takımNoTextBox;
        private System.Windows.Forms.TextBox paketNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label takım_no_text;
        private System.Windows.Forms.Label paket_no_text;
        private System.Windows.Forms.Label zaman_text;
        private System.Windows.Forms.Label pil_text;
        private System.Windows.Forms.Label roll_text;
        private System.Windows.Forms.Label pitch_text;
        private System.Windows.Forms.Label yaw_text;
        private System.Windows.Forms.TextBox paketNo_box;
        private System.Windows.Forms.TextBox zaman_box;
        private System.Windows.Forms.TextBox pil_Box;
        private System.Windows.Forms.TextBox roll_box;
        private System.Windows.Forms.TextBox pitch_box;
        private System.Windows.Forms.TextBox yaw_box;
        private System.Windows.Forms.RichTextBox takım_no_box;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

