
namespace lab2graphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.rPb = new System.Windows.Forms.PictureBox();
            this.gPb = new System.Windows.Forms.PictureBox();
            this.bPb = new System.Windows.Forms.PictureBox();
            this.gChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.88316F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.11684F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 478F));
            this.tableLayoutPanel1.Controls.Add(this.pbSource, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rPb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gPb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bPb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gChart, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rChart, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bChart, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbSource
            // 
            this.pbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSource.Location = new System.Drawing.Point(3, 3);
            this.pbSource.Name = "pbSource";
            this.tableLayoutPanel1.SetRowSpan(this.pbSource, 3);
            this.pbSource.Size = new System.Drawing.Size(424, 439);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSource.TabIndex = 1;
            this.pbSource.TabStop = false;
            this.pbSource.Click += new System.EventHandler(this.pbSource_Click);
            // 
            // rPb
            // 
            this.rPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rPb.Location = new System.Drawing.Point(433, 3);
            this.rPb.Name = "rPb";
            this.rPb.Size = new System.Drawing.Size(146, 141);
            this.rPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rPb.TabIndex = 2;
            this.rPb.TabStop = false;
            // 
            // gPb
            // 
            this.gPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPb.Location = new System.Drawing.Point(433, 151);
            this.gPb.Name = "gPb";
            this.gPb.Size = new System.Drawing.Size(146, 142);
            this.gPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gPb.TabIndex = 3;
            this.gPb.TabStop = false;
            // 
            // bPb
            // 
            this.bPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bPb.Location = new System.Drawing.Point(433, 299);
            this.bPb.Name = "bPb";
            this.bPb.Size = new System.Drawing.Size(146, 143);
            this.bPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bPb.TabIndex = 4;
            this.bPb.TabStop = false;
            // 
            // gChart
            // 
            this.gChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.gChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.gChart.Legends.Add(legend4);
            this.gChart.Location = new System.Drawing.Point(585, 151);
            this.gChart.Name = "gChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.gChart.Series.Add(series4);
            this.gChart.Size = new System.Drawing.Size(473, 142);
            this.gChart.TabIndex = 6;
            this.gChart.Text = "gChart";
            // 
            // rChart
            // 
            this.rChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.rChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.rChart.Legends.Add(legend5);
            this.rChart.Location = new System.Drawing.Point(585, 3);
            this.rChart.Name = "rChart";
            this.rChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.rChart.Series.Add(series5);
            this.rChart.Size = new System.Drawing.Size(473, 142);
            this.rChart.TabIndex = 7;
            this.rChart.Text = "rChart";
            // 
            // bChart
            // 
            this.bChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.bChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.bChart.Legends.Add(legend6);
            this.bChart.Location = new System.Drawing.Point(585, 299);
            this.bChart.Name = "bChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.bChart.Series.Add(series6);
            this.bChart.Size = new System.Drawing.Size(473, 143);
            this.bChart.TabIndex = 8;
            this.bChart.Text = "bChart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox rPb;
        private System.Windows.Forms.PictureBox gPb;
        private System.Windows.Forms.PictureBox bPb;
        private System.Windows.Forms.DataVisualization.Charting.Chart gChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart rChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart bChart;
    }
}

