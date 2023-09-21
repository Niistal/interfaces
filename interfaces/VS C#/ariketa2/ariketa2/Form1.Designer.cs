namespace ariketa2
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
            txtZenb = new TextBox();
            label1 = new Label();
            Lbzenb = new Label();
            Hurrengoa = new Button();
            Garbitu = new Button();
            Irten = new Button();
            SuspendLayout();
            // 
            // txtZenb
            // 
            txtZenb.Location = new Point(229, 133);
            txtZenb.Name = "txtZenb";
            txtZenb.Size = new Size(453, 27);
            txtZenb.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // Lbzenb
            // 
            Lbzenb.AutoSize = true;
            Lbzenb.BackColor = Color.MediumBlue;
            Lbzenb.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Lbzenb.ForeColor = Color.Transparent;
            Lbzenb.Location = new Point(71, 133);
            Lbzenb.Name = "Lbzenb";
            Lbzenb.Size = new Size(110, 25);
            Lbzenb.TabIndex = 1;
            Lbzenb.Text = "1. Zenbakia";
            // 
            // Hurrengoa
            // 
            Hurrengoa.Location = new Point(104, 231);
            Hurrengoa.Name = "Hurrengoa";
            Hurrengoa.Size = new Size(146, 35);
            Hurrengoa.TabIndex = 2;
            Hurrengoa.Text = "Hurrengoa";
            Hurrengoa.UseVisualStyleBackColor = true;
            Hurrengoa.Click += Hurrengoa_Click;
            // 
            // Garbitu
            // 
            Garbitu.Location = new Point(329, 231);
            Garbitu.Name = "Garbitu";
            Garbitu.Size = new Size(146, 35);
            Garbitu.TabIndex = 3;
            Garbitu.Text = "Garbitu";
            Garbitu.UseVisualStyleBackColor = true;
            Garbitu.Click += Garbitu_Click;
            // 
            // Irten
            // 
            Irten.Location = new Point(549, 231);
            Irten.Name = "Irten";
            Irten.Size = new Size(146, 35);
            Irten.TabIndex = 4;
            Irten.Text = "Irten";
            Irten.UseVisualStyleBackColor = true;
            Irten.Click += Irten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 431);
            Controls.Add(Irten);
            Controls.Add(Garbitu);
            Controls.Add(Hurrengoa);
            Controls.Add(Lbzenb);
            Controls.Add(label1);
            Controls.Add(txtZenb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZenb;
        private Label label1;
        private Label Lbzenb;
        private Button Hurrengoa;
        private Button Garbitu;
        private Button Irten;
    }
}