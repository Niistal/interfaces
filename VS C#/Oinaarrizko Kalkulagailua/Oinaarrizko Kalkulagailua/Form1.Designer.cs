namespace Oinaarrizko_Kalkulagailua
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            gehi = new Button();
            ken = new Button();
            bider = new Button();
            zati = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(96, 93);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(201, 27);
            txt1.TabIndex = 0;
            // 
            // txt2
            // 
            txt2.Location = new Point(577, 93);
            txt2.Margin = new Padding(3, 4, 3, 4);
            txt2.Name = "txt2";
            txt2.Size = new Size(201, 27);
            txt2.TabIndex = 1;
            // 
            // gehi
            // 
            gehi.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gehi.ForeColor = SystemColors.MenuHighlight;
            gehi.Location = new Point(152, 161);
            gehi.Margin = new Padding(3, 4, 3, 4);
            gehi.Name = "gehi";
            gehi.Size = new Size(145, 129);
            gehi.TabIndex = 2;
            gehi.Text = "+";
            gehi.UseVisualStyleBackColor = true;
            gehi.Click += gehi_Click;
            // 
            // ken
            // 
            ken.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point);
            ken.ForeColor = SystemColors.MenuHighlight;
            ken.Location = new Point(577, 161);
            ken.Margin = new Padding(3, 4, 3, 4);
            ken.Name = "ken";
            ken.Size = new Size(145, 129);
            ken.TabIndex = 3;
            ken.Text = "-";
            ken.UseVisualStyleBackColor = true;
            ken.Click += ken_Click;
            // 
            // bider
            // 
            bider.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point);
            bider.ForeColor = SystemColors.MenuHighlight;
            bider.Location = new Point(152, 353);
            bider.Margin = new Padding(3, 4, 3, 4);
            bider.Name = "bider";
            bider.Size = new Size(145, 129);
            bider.TabIndex = 4;
            bider.Text = "x";
            bider.UseVisualStyleBackColor = true;
            bider.Click += bider_Click;
            // 
            // zati
            // 
            zati.Font = new Font("Impact", 36F, FontStyle.Bold, GraphicsUnit.Point);
            zati.ForeColor = SystemColors.MenuHighlight;
            zati.Location = new Point(577, 353);
            zati.Margin = new Padding(3, 4, 3, 4);
            zati.Name = "zati";
            zati.Size = new Size(145, 129);
            zati.TabIndex = 5;
            zati.Text = "/";
            zati.UseVisualStyleBackColor = true;
            zati.Click += zati_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 67);
            label1.TabIndex = 6;
            label1.Text = "kalkulagailua";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(zati);
            Controls.Add(bider);
            Controls.Add(ken);
            Controls.Add(gehi);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private Button gehi;
        private Button ken;
        private Button bider;
        private Button zati;
        private Label label1;
    }
}