namespace CheckBox
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
            this.checkBoxDorucak = new System.Windows.Forms.CheckBox();
            this.checkBoxRucak = new System.Windows.Forms.CheckBox();
            this.checkBoxVecera = new System.Windows.Forms.CheckBox();
            this.buttonPosalji = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.checkBoxSakrijNarudzbu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxDorucak
            // 
            this.checkBoxDorucak.AutoSize = true;
            this.checkBoxDorucak.Location = new System.Drawing.Point(116, 85);
            this.checkBoxDorucak.Name = "checkBoxDorucak";
            this.checkBoxDorucak.Size = new System.Drawing.Size(67, 17);
            this.checkBoxDorucak.TabIndex = 0;
            this.checkBoxDorucak.Text = "Dorucak";
            this.checkBoxDorucak.UseVisualStyleBackColor = true;
            this.checkBoxDorucak.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxRucak
            // 
            this.checkBoxRucak.AutoSize = true;
            this.checkBoxRucak.Location = new System.Drawing.Point(116, 128);
            this.checkBoxRucak.Name = "checkBoxRucak";
            this.checkBoxRucak.Size = new System.Drawing.Size(58, 17);
            this.checkBoxRucak.TabIndex = 1;
            this.checkBoxRucak.Text = "Rucak";
            this.checkBoxRucak.UseVisualStyleBackColor = true;
            // 
            // checkBoxVecera
            // 
            this.checkBoxVecera.AutoSize = true;
            this.checkBoxVecera.Location = new System.Drawing.Point(116, 171);
            this.checkBoxVecera.Name = "checkBoxVecera";
            this.checkBoxVecera.Size = new System.Drawing.Size(60, 17);
            this.checkBoxVecera.TabIndex = 2;
            this.checkBoxVecera.Text = "Vecera";
            this.checkBoxVecera.UseVisualStyleBackColor = true;
            // 
            // buttonPosalji
            // 
            this.buttonPosalji.Location = new System.Drawing.Point(116, 220);
            this.buttonPosalji.Name = "buttonPosalji";
            this.buttonPosalji.Size = new System.Drawing.Size(75, 23);
            this.buttonPosalji.TabIndex = 3;
            this.buttonPosalji.Text = "Posalji";
            this.buttonPosalji.UseVisualStyleBackColor = true;
            this.buttonPosalji.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(276, 83);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(201, 105);
            this.textBox.TabIndex = 4;
            // 
            // checkBoxSakrijNarudzbu
            // 
            this.checkBoxSakrijNarudzbu.AutoSize = true;
            this.checkBoxSakrijNarudzbu.Location = new System.Drawing.Point(276, 220);
            this.checkBoxSakrijNarudzbu.Name = "checkBoxSakrijNarudzbu";
            this.checkBoxSakrijNarudzbu.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSakrijNarudzbu.TabIndex = 5;
            this.checkBoxSakrijNarudzbu.Text = "Sakrij narudzbu";
            this.checkBoxSakrijNarudzbu.UseVisualStyleBackColor = true;
            this.checkBoxSakrijNarudzbu.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxSakrijNarudzbu);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonPosalji);
            this.Controls.Add(this.checkBoxVecera);
            this.Controls.Add(this.checkBoxRucak);
            this.Controls.Add(this.checkBoxDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDorucak;
        private System.Windows.Forms.CheckBox checkBoxRucak;
        private System.Windows.Forms.CheckBox checkBoxVecera;
        private System.Windows.Forms.Button buttonPosalji;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox checkBoxSakrijNarudzbu;
    }
}

