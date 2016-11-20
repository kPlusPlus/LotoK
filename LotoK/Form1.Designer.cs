namespace LotoK
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.txtCombination = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(304, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.Text = "CombLoto.json";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(347, 14);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(136, 39);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "generator";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // txtCombination
            // 
            this.txtCombination.Location = new System.Drawing.Point(12, 70);
            this.txtCombination.Multiline = true;
            this.txtCombination.Name = "txtCombination";
            this.txtCombination.Size = new System.Drawing.Size(304, 315);
            this.txtCombination.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(724, 425);
            this.Controls.Add(this.txtCombination);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtFileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.TextBox txtCombination;
    }
}

