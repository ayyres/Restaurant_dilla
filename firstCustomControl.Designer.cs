namespace Restaurant_dilla
{
    partial class firstCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstCustomControl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(64, 49);
            label1.Name = "label1";
            label1.Size = new Size(239, 123);
            label1.TabIndex = 0;
            label1.Text = "$19";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(64, 49);
            label2.Name = "label2";
            label2.Size = new Size(43, 18);
            label2.TabIndex = 1;
            label2.Text = "Only";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 163);
            label3.Name = "label3";
            label3.Size = new Size(178, 28);
            label3.TabIndex = 2;
            label3.Text = "Cheeseburger";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 191);
            label4.Name = "label4";
            label4.Size = new Size(256, 17);
            label4.TabIndex = 3;
            label4.Text = "With Onions and tomato and ketchup";
            // 
            // label6
            // 
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(88, 217);
            label6.Name = "label6";
            label6.Size = new Size(416, 88);
            label6.TabIndex = 5;
            label6.Text = resources.GetString("label6.Text");
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(103, 308);
            button1.Name = "button1";
            button1.Size = new Size(329, 39);
            button1.TabIndex = 6;
            button1.Text = "Order New";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(510, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // firstCustomControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "firstCustomControl";
            Size = new Size(817, 423);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
