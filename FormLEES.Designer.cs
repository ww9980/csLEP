﻿namespace csLEES
{
    partial class FormLEES
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TopPlot = new LiveCharts.WinForms.CartesianChart();
            this.BottomPlot = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TopPlot, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BottomPlot, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TopPlot
            // 
            this.TopPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPlot.Location = new System.Drawing.Point(3, 3);
            this.TopPlot.Name = "TopPlot";
            this.TopPlot.Size = new System.Drawing.Size(910, 235);
            this.TopPlot.TabIndex = 0;
            this.TopPlot.Text = "cartesianChart1";
            // 
            // BottomPlot
            // 
            this.BottomPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPlot.Location = new System.Drawing.Point(3, 244);
            this.BottomPlot.Name = "BottomPlot";
            this.BottomPlot.Size = new System.Drawing.Size(910, 236);
            this.BottomPlot.TabIndex = 1;
            this.BottomPlot.Text = "cartesianChart2";
            // 
            // FormLEES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLEES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LEES Results";
            this.Load += new System.EventHandler(this.FormLEES_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart TopPlot;
        private LiveCharts.WinForms.CartesianChart BottomPlot;
    }
}