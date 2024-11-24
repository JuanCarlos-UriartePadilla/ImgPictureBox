namespace ImgPictureBox3minFinal
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
            pictureBox1 = new PictureBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img10;
            pictureBox1.Location = new Point(51, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 409);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 1;
            btn1.Text = "Imagen 1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(126, 409);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 2;
            btn2.Text = "Imagen 2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(236, 409);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 3;
            btn3.Text = "Imagen 3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(347, 409);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 29);
            btn4.TabIndex = 4;
            btn4.Text = "Imagen 4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GrayText;
            label1.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 33);
            label1.TabIndex = 5;
            label1.Text = "Juan Carlos Uriarte Padilla";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(489, 450);
            Controls.Add(label1);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Label label1;
    }
}
