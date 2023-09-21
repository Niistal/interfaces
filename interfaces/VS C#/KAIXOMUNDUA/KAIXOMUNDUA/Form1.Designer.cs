namespace KAIXOMUNDUA
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
            KAIXO = new Button();
            ITXI = new Button();
            SuspendLayout();
            // 
            // KAIXO
            // 
            KAIXO.BackColor = SystemColors.ActiveBorder;
            KAIXO.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            KAIXO.ForeColor = SystemColors.HotTrack;
            KAIXO.Location = new Point(305, 69);
            KAIXO.Name = "KAIXO";
            KAIXO.Size = new Size(209, 82);
            KAIXO.TabIndex = 0;
            KAIXO.Text = "KAIXO";
            KAIXO.UseVisualStyleBackColor = false;
            KAIXO.Click += button1_Click;
            // 
            // ITXI
            // 
            ITXI.BackColor = SystemColors.ActiveBorder;
            ITXI.Font = new Font("Impact", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ITXI.ForeColor = SystemColors.HotTrack;
            ITXI.Location = new Point(305, 275);
            ITXI.Name = "ITXI";
            ITXI.Size = new Size(209, 82);
            ITXI.TabIndex = 1;
            ITXI.Text = "ITXI";
            ITXI.UseVisualStyleBackColor = false;
            ITXI.Click += ITXI_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ITXI);
            Controls.Add(KAIXO);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button KAIXO;
        private Button ITXI;
    }
}