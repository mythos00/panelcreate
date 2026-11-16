namespace PanelCreate
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;
        private System.Windows.Forms.Panel gameArea = null!;
        private System.Windows.Forms.Panel bottomBar = null!;
        private System.Windows.Forms.PictureBox pictureBox1 = null!;
        private System.Windows.Forms.Label label1 = null!;
        private System.Windows.Forms.Label label2 = null!;
        private System.Windows.Forms.Button button1 = null!;
        private System.Windows.Forms.Button button2 = null!;
        private System.Windows.Forms.Button button3 = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameArea = new Panel();
            pictureBox1 = new PictureBox();
            bottomBar = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            bottomBar.SuspendLayout();
            SuspendLayout();
            // 
            // gameArea
            // 
            gameArea.BackColor = Color.White;
            gameArea.Controls.Add(pictureBox1);
            gameArea.Dock = DockStyle.Fill;
            gameArea.Location = new Point(0, 0);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(857, 456);
            gameArea.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(70, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bottomBar
            // 
            bottomBar.BackColor = Color.Gray;
            bottomBar.Controls.Add(label1);
            bottomBar.Controls.Add(label2);
            bottomBar.Controls.Add(button1);
            bottomBar.Controls.Add(button2);
            bottomBar.Controls.Add(button3);
            bottomBar.Dock = DockStyle.Bottom;
            bottomBar.Location = new Point(0, 456);
            bottomBar.Name = "bottomBar";
            bottomBar.Size = new Size(857, 66);
            bottomBar.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(45, 26);
            label1.TabIndex = 0;
            label1.Text = "Xal:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 20);
            label2.Name = "label2";
            label2.Size = new Size(55, 26);
            label2.TabIndex = 1;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(206, 15);
            button1.Name = "button1";
            button1.Size = new Size(138, 40);
            button1.TabIndex = 2;
            button1.Text = "Panel yarat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(395, 15);
            button2.Name = "button2";
            button2.Size = new Size(224, 40);
            button2.TabIndex = 3;
            button2.Text = "Bombanın yerini dəyiş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(674, 15);
            button3.Name = "button3";
            button3.Size = new Size(138, 40);
            button3.TabIndex = 4;
            button3.Text = "Çıxış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 522);
            Controls.Add(gameArea);
            Controls.Add(bottomBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PanelCreate";
            gameArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            bottomBar.ResumeLayout(false);
            ResumeLayout(false);
        }
        private System.Windows.Forms.Timer timer1;
    }
}
