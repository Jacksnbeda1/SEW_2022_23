namespace HUE03
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.Analysieren = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSelectResultDirectory = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(220, 36);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(106, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Datei wählen";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // Analysieren
            // 
            this.Analysieren.Location = new System.Drawing.Point(332, 36);
            this.Analysieren.Name = "Analysieren";
            this.Analysieren.Size = new System.Drawing.Size(107, 23);
            this.Analysieren.TabIndex = 1;
            this.Analysieren.Text = "Analysieren";
            this.Analysieren.UseVisualStyleBackColor = true;
            this.Analysieren.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtResult
            // 
            this.txtResult.AcceptsReturn = true;
            this.txtResult.AcceptsTab = true;
            this.txtResult.AllowDrop = true;
            this.txtResult.Location = new System.Drawing.Point(219, 69);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtResult.Size = new System.Drawing.Size(350, 311);
            this.txtResult.TabIndex = 2;
            // 
            // btnSelectResultDirectory
            // 
            this.btnSelectResultDirectory.Location = new System.Drawing.Point(445, 36);
            this.btnSelectResultDirectory.Name = "btnSelectResultDirectory";
            this.btnSelectResultDirectory.Size = new System.Drawing.Size(124, 23);
            this.btnSelectResultDirectory.TabIndex = 3;
            this.btnSelectResultDirectory.Text = "Speicherort wählen";
            this.btnSelectResultDirectory.UseVisualStyleBackColor = true;
            this.btnSelectResultDirectory.Click += new System.EventHandler(this.btnSelectResultDirectory_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(219, 386);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 23);
            this.progressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSelectResultDirectory);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Analysieren);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Analyse";
            this.Click += new System.EventHandler(this.btnSelectFile_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSelectFile;
        private Button Analysieren;
        private TextBox txtResult;
        private Button btnSelectResultDirectory;
        private ProgressBar progressBar;
    }
}