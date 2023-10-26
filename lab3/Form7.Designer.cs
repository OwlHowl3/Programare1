namespace lab3
{
    partial class Form7
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
            this.labelNr1 = new System.Windows.Forms.Label();
            this.labelNr2 = new System.Windows.Forms.Label();
            this.textBoxNr1 = new System.Windows.Forms.TextBox();
            this.textBoxNr2 = new System.Windows.Forms.TextBox();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNr1
            // 
            this.labelNr1.AutoSize = true;
            this.labelNr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNr1.Location = new System.Drawing.Point(65, 86);
            this.labelNr1.Name = "labelNr1";
            this.labelNr1.Size = new System.Drawing.Size(92, 24);
            this.labelNr1.TabIndex = 0;
            this.labelNr1.Text = "Numar A";
            // 
            // labelNr2
            // 
            this.labelNr2.AutoSize = true;
            this.labelNr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNr2.Location = new System.Drawing.Point(217, 85);
            this.labelNr2.Name = "labelNr2";
            this.labelNr2.Size = new System.Drawing.Size(91, 24);
            this.labelNr2.TabIndex = 1;
            this.labelNr2.Text = "Numar B";
            this.labelNr2.Click += new System.EventHandler(this.labelNr2_Click);
            // 
            // textBoxNr1
            // 
            this.textBoxNr1.Location = new System.Drawing.Point(68, 124);
            this.textBoxNr1.Name = "textBoxNr1";
            this.textBoxNr1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNr1.TabIndex = 2;
            // 
            // textBoxNr2
            // 
            this.textBoxNr2.Location = new System.Drawing.Point(221, 124);
            this.textBoxNr2.Name = "textBoxNr2";
            this.textBoxNr2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNr2.TabIndex = 3;
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolve.Location = new System.Drawing.Point(140, 172);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(130, 32);
            this.buttonSolve.TabIndex = 4;
            this.buttonSolve.Text = "Rezolvare";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ecuatie grad I (ax + b = 0)";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 316);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.textBoxNr2);
            this.Controls.Add(this.textBoxNr1);
            this.Controls.Add(this.labelNr2);
            this.Controls.Add(this.labelNr1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNr1;
        private System.Windows.Forms.Label labelNr2;
        private System.Windows.Forms.TextBox textBoxNr1;
        private System.Windows.Forms.TextBox textBoxNr2;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label label3;
    }
}