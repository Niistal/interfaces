namespace esaldiak
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
            esaldia1 = new Button();
            Rtxt = new RichTextBox();
            esaldia2 = new Button();
            esaldia3 = new Button();
            esaldia4 = new Button();
            esaldia5 = new Button();
            lotu = new Button();
            reset = new Button();
            itxi = new Button();
            SuspendLayout();
            // 
            // esaldia1
            // 
            esaldia1.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            esaldia1.Location = new Point(76, 181);
            esaldia1.Name = "esaldia1";
            esaldia1.Size = new Size(125, 72);
            esaldia1.TabIndex = 1;
            esaldia1.Text = "esaldia1";
            esaldia1.UseVisualStyleBackColor = true;
            esaldia1.Click += esaldia1_Click;
            // 
            // Rtxt
            // 
            Rtxt.Location = new Point(192, 27);
            Rtxt.Name = "Rtxt";
            Rtxt.Size = new Size(433, 120);
            Rtxt.TabIndex = 2;
            Rtxt.Text = "";
            
            // 
            // esaldia2
            // 
            esaldia2.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            esaldia2.Location = new Point(323, 181);
            esaldia2.Name = "esaldia2";
            esaldia2.Size = new Size(125, 72);
            esaldia2.TabIndex = 3;
            esaldia2.Text = "esaldia2";
            esaldia2.UseVisualStyleBackColor = true;
            esaldia2.Click += esaldia2_Click;
            // 
            // esaldia3
            // 
            esaldia3.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            esaldia3.Location = new Point(577, 181);
            esaldia3.Name = "esaldia3";
            esaldia3.Size = new Size(125, 72);
            esaldia3.TabIndex = 4;
            esaldia3.Text = "esaldia3";
            esaldia3.UseVisualStyleBackColor = true;
            esaldia3.Click += esaldia3_Click;
            // 
            // esaldia4
            // 
            esaldia4.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            esaldia4.Location = new Point(76, 301);
            esaldia4.Name = "esaldia4";
            esaldia4.Size = new Size(125, 72);
            esaldia4.TabIndex = 5;
            esaldia4.Text = "esaldia4";
            esaldia4.UseVisualStyleBackColor = true;
            esaldia4.Click += esaldia4_Click;
            // 
            // esaldia5
            // 
            esaldia5.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            esaldia5.Location = new Point(323, 301);
            esaldia5.Name = "esaldia5";
            esaldia5.Size = new Size(125, 72);
            esaldia5.TabIndex = 6;
            esaldia5.Text = "esaldia5";
            esaldia5.UseVisualStyleBackColor = true;
            esaldia5.Click += esaldia5_Click;
            // 
            // lotu
            // 
            lotu.BackColor = Color.Lime;
            lotu.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lotu.Location = new Point(577, 301);
            lotu.Name = "lotu";
            lotu.Size = new Size(125, 72);
            lotu.TabIndex = 7;
            lotu.Text = "lotu";
            lotu.UseVisualStyleBackColor = false;
            lotu.Click += lotu_Click;
            // 
            // reset
            // 
            reset.BackColor = Color.Gold;
            reset.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            reset.Location = new Point(207, 392);
            reset.Name = "reset";
            reset.Size = new Size(116, 48);
            reset.TabIndex = 8;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // itxi
            // 
            itxi.BackColor = Color.Red;
            itxi.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            itxi.Location = new Point(471, 392);
            itxi.Name = "itxi";
            itxi.Size = new Size(116, 48);
            itxi.TabIndex = 9;
            itxi.Text = "itxi";
            itxi.UseVisualStyleBackColor = false;
            itxi.Click += itxi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(itxi);
            Controls.Add(reset);
            Controls.Add(lotu);
            Controls.Add(esaldia5);
            Controls.Add(esaldia4);
            Controls.Add(esaldia3);
            Controls.Add(esaldia2);
            Controls.Add(Rtxt);
            Controls.Add(esaldia1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button esaldia1;
        private RichTextBox Rtxt;
        private Button esaldia2;
        private Button esaldia3;
        private Button esaldia4;
        private Button esaldia5;
        private Button lotu;
        private Button reset;
        private Button itxi;
    }
}