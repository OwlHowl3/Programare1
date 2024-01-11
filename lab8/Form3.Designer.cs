namespace lab8
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxLocality = new System.Windows.Forms.TextBox();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxAccomodation = new System.Windows.Forms.CheckBox();
            this.checkBoxTransport = new System.Windows.Forms.CheckBox();
            this.groupBoxCampus = new System.Windows.Forms.GroupBox();
            this.radioButtonTituMaiorescu = new System.Windows.Forms.RadioButton();
            this.radioButtonCodrescu = new System.Windows.Forms.RadioButton();
            this.radioButtonTargusorCopou = new System.Windows.Forms.RadioButton();
            this.groupBoxCampus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Locality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "GPA";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(161, 80);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(161, 115);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxLocality
            // 
            this.textBoxLocality.Location = new System.Drawing.Point(161, 151);
            this.textBoxLocality.Name = "textBoxLocality";
            this.textBoxLocality.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocality.TabIndex = 6;
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(161, 181);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(100, 20);
            this.textBoxGPA.TabIndex = 7;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(161, 366);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(100, 23);
            this.buttonInfo.TabIndex = 8;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(312, 79);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 24);
            this.labelInfo.TabIndex = 9;
            // 
            // checkBoxAccomodation
            // 
            this.checkBoxAccomodation.AutoSize = true;
            this.checkBoxAccomodation.Location = new System.Drawing.Point(161, 248);
            this.checkBoxAccomodation.Name = "checkBoxAccomodation";
            this.checkBoxAccomodation.Size = new System.Drawing.Size(127, 17);
            this.checkBoxAccomodation.TabIndex = 10;
            this.checkBoxAccomodation.Text = "Needs accomodation";
            this.checkBoxAccomodation.UseVisualStyleBackColor = true;
            this.checkBoxAccomodation.CheckedChanged += new System.EventHandler(this.checkBoxAccomodation_CheckedChanged);
            // 
            // checkBoxTransport
            // 
            this.checkBoxTransport.AutoSize = true;
            this.checkBoxTransport.Location = new System.Drawing.Point(161, 272);
            this.checkBoxTransport.Name = "checkBoxTransport";
            this.checkBoxTransport.Size = new System.Drawing.Size(133, 17);
            this.checkBoxTransport.TabIndex = 11;
            this.checkBoxTransport.Text = "Needs transport facility";
            this.checkBoxTransport.UseVisualStyleBackColor = true;
            // 
            // groupBoxCampus
            // 
            this.groupBoxCampus.Controls.Add(this.radioButtonTargusorCopou);
            this.groupBoxCampus.Controls.Add(this.radioButtonCodrescu);
            this.groupBoxCampus.Controls.Add(this.radioButtonTituMaiorescu);
            this.groupBoxCampus.Location = new System.Drawing.Point(369, 248);
            this.groupBoxCampus.Name = "groupBoxCampus";
            this.groupBoxCampus.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCampus.TabIndex = 12;
            this.groupBoxCampus.TabStop = false;
            this.groupBoxCampus.Text = "Campus";
            // 
            // radioButtonTituMaiorescu
            // 
            this.radioButtonTituMaiorescu.AutoSize = true;
            this.radioButtonTituMaiorescu.Location = new System.Drawing.Point(7, 24);
            this.radioButtonTituMaiorescu.Name = "radioButtonTituMaiorescu";
            this.radioButtonTituMaiorescu.Size = new System.Drawing.Size(95, 17);
            this.radioButtonTituMaiorescu.TabIndex = 0;
            this.radioButtonTituMaiorescu.TabStop = true;
            this.radioButtonTituMaiorescu.Text = "Titu Maiorescu";
            this.radioButtonTituMaiorescu.UseVisualStyleBackColor = true;
            this.radioButtonTituMaiorescu.CheckedChanged += new System.EventHandler(this.radioButtonTituMaiorescu_CheckedChanged);
            // 
            // radioButtonCodrescu
            // 
            this.radioButtonCodrescu.AutoSize = true;
            this.radioButtonCodrescu.Location = new System.Drawing.Point(7, 48);
            this.radioButtonCodrescu.Name = "radioButtonCodrescu";
            this.radioButtonCodrescu.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCodrescu.TabIndex = 1;
            this.radioButtonCodrescu.TabStop = true;
            this.radioButtonCodrescu.Text = "Codrescu";
            this.radioButtonCodrescu.UseVisualStyleBackColor = true;
            this.radioButtonCodrescu.CheckedChanged += new System.EventHandler(this.radioButtonCodrescu_CheckedChanged);
            // 
            // radioButtonTargusorCopou
            // 
            this.radioButtonTargusorCopou.AutoSize = true;
            this.radioButtonTargusorCopou.Location = new System.Drawing.Point(7, 72);
            this.radioButtonTargusorCopou.Name = "radioButtonTargusorCopou";
            this.radioButtonTargusorCopou.Size = new System.Drawing.Size(101, 17);
            this.radioButtonTargusorCopou.TabIndex = 2;
            this.radioButtonTargusorCopou.TabStop = true;
            this.radioButtonTargusorCopou.Text = "Targusor Copou";
            this.radioButtonTargusorCopou.UseVisualStyleBackColor = true;
            this.radioButtonTargusorCopou.CheckedChanged += new System.EventHandler(this.radioButtonTargusorCopou_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxCampus);
            this.Controls.Add(this.checkBoxTransport);
            this.Controls.Add(this.checkBoxAccomodation);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.textBoxGPA);
            this.Controls.Add(this.textBoxLocality);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBoxCampus.ResumeLayout(false);
            this.groupBoxCampus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxLocality;
        private System.Windows.Forms.TextBox textBoxGPA;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxAccomodation;
        private System.Windows.Forms.CheckBox checkBoxTransport;
        private System.Windows.Forms.GroupBox groupBoxCampus;
        private System.Windows.Forms.RadioButton radioButtonTargusorCopou;
        private System.Windows.Forms.RadioButton radioButtonCodrescu;
        private System.Windows.Forms.RadioButton radioButtonTituMaiorescu;
    }
}