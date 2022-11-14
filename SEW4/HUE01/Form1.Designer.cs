
namespace HUE01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_readData = new System.Windows.Forms.Button();
            this.lb_Port = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.lb_AktuelleTemperatur = new System.Windows.Forms.Label();
            this.txt_AktuelleTemperatur = new System.Windows.Forms.TextBox();
            this.lb_MWTemperatur = new System.Windows.Forms.Label();
            this.txt_MWTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_readData
            // 
            this.btn_readData.Location = new System.Drawing.Point(521, 61);
            this.btn_readData.Name = "btn_readData";
            this.btn_readData.Size = new System.Drawing.Size(110, 23);
            this.btn_readData.TabIndex = 0;
            this.btn_readData.Text = "Daten lesen";
            this.btn_readData.UseVisualStyleBackColor = true;
            this.btn_readData.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Location = new System.Drawing.Point(86, 65);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(32, 15);
            this.lb_Port.TabIndex = 1;
            this.lb_Port.Text = "Port:";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(124, 62);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(246, 23);
            this.txt_Port.TabIndex = 2;
            // 
            // lb_AktuelleTemperatur
            // 
            this.lb_AktuelleTemperatur.AutoSize = true;
            this.lb_AktuelleTemperatur.Location = new System.Drawing.Point(86, 115);
            this.lb_AktuelleTemperatur.Name = "lb_AktuelleTemperatur";
            this.lb_AktuelleTemperatur.Size = new System.Drawing.Size(116, 15);
            this.lb_AktuelleTemperatur.TabIndex = 3;
            this.lb_AktuelleTemperatur.Text = "Aktuelle Temperatur:";
            // 
            // txt_AktuelleTemperatur
            // 
            this.txt_AktuelleTemperatur.Location = new System.Drawing.Point(209, 115);
            this.txt_AktuelleTemperatur.Name = "txt_AktuelleTemperatur";
            this.txt_AktuelleTemperatur.Size = new System.Drawing.Size(161, 23);
            this.txt_AktuelleTemperatur.TabIndex = 4;
            // 
            // lb_MWTemperatur
            // 
            this.lb_MWTemperatur.AutoSize = true;
            this.lb_MWTemperatur.Location = new System.Drawing.Point(86, 166);
            this.lb_MWTemperatur.Name = "lb_MWTemperatur";
            this.lb_MWTemperatur.Size = new System.Drawing.Size(165, 15);
            this.lb_MWTemperatur.TabIndex = 5;
            this.lb_MWTemperatur.Text = "Mittelwert Temperatur (5min):";
            // 
            // txt_MWTemp
            // 
            this.txt_MWTemp.Location = new System.Drawing.Point(258, 166);
            this.txt_MWTemp.Name = "txt_MWTemp";
            this.txt_MWTemp.Size = new System.Drawing.Size(112, 23);
            this.txt_MWTemp.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_MWTemp);
            this.Controls.Add(this.lb_MWTemperatur);
            this.Controls.Add(this.txt_AktuelleTemperatur);
            this.Controls.Add(this.lb_AktuelleTemperatur);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.lb_Port);
            this.Controls.Add(this.btn_readData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_readData;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label lb_AktuelleTemperatur;
        private System.Windows.Forms.TextBox txt_AktuelleTemperatur;
        private System.Windows.Forms.Label lb_MWTemperatur;
        private System.Windows.Forms.TextBox txt_MWTemp;
    }
}

