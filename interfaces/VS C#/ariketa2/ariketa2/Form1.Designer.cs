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
            textBox1 = new TextBox();
            label1 = new Label();
            Lbzenb = new Label();
            Hurrengoa = new Button();
            Garbitu = new Button();
            Irten = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(268, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(453, 27);
            textBox1.TabIndex = 0;
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
            Lbzenb.Location = new Point(78, 61);
            Lbzenb.Name = "Lbzenb";
            Lbzenb.Size = new Size(85, 20);
            Lbzenb.TabIndex = 1;
            Lbzenb.Text = "1. Zenbakia";
            // 
            // Hurrengoa
            // 
            Hurrengoa.Location = new Point(108, 356);
            Hurrengoa.Name = "Hurrengoa";
            Hurrengoa.Size = new Size(146, 35);
            Hurrengoa.TabIndex = 2;
            Hurrengoa.Text = "Hurrengoa";
            Hurrengoa.UseVisualStyleBackColor = true;
            // 
            // Garbitu
            // 
            Garbitu.Location = new Point(333, 356);
            Garbitu.Name = "Garbitu";
            Garbitu.Size = new Size(146, 35);
            Garbitu.TabIndex = 3;
            Garbitu.Text = "Garbitu";
            Garbitu.UseVisualStyleBackColor = true;
            // 
            // Irten
            // 
            Irten.Location = new Point(553, 356);
            Irten.Name = "Irten";
            Irten.Size = new Size(146, 35);
            Irten.TabIndex = 4;
            Irten.Text = "Irten";
            Irten.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Irten);
            Controls.Add(Garbitu);
            Controls.Add(Hurrengoa);
            Controls.Add(Lbzenb);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label Lbzenb;
        private Button Hurrengoa;
        private Button Garbitu;
        private Button Irten;
    }
}