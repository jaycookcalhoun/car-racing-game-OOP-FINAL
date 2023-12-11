namespace car_racing_game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            car = new PictureBox();
            enemy3 = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            over = new Label();
            coin1 = new PictureBox();
            coin2 = new PictureBox();
            coin3 = new PictureBox();
            bigcoin = new PictureBox();
            label1 = new Label();
            restartbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bigcoin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.Location = new Point(12, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(8, 468);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Lime;
            pictureBox2.Location = new Point(364, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(8, 468);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // car
            // 
            car.Image = (Image)resources.GetObject("car.Image");
            car.Location = new Point(53, 395);
            car.Name = "car";
            car.Size = new Size(35, 54);
            car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.TabIndex = 2;
            car.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.Image = (Image)resources.GetObject("enemy3.Image");
            enemy3.Location = new Point(276, 152);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(40, 40);
            enemy3.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy3.TabIndex = 5;
            enemy3.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(107, 178);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(40, 40);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 6;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(158, 70);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(40, 40);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 7;
            enemy2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // over
            // 
            over.AutoSize = true;
            over.BackColor = Color.FromArgb(0, 64, 0);
            over.Font = new Font("Bauhaus 93", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            over.ForeColor = Color.Lime;
            over.Location = new Point(85, 200);
            over.Name = "over";
            over.Size = new Size(216, 42);
            over.TabIndex = 8;
            over.Text = "GAME OVER";
            // 
            // coin1
            // 
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(209, 318);
            coin1.Name = "coin1";
            coin1.Size = new Size(40, 40);
            coin1.SizeMode = PictureBoxSizeMode.StretchImage;
            coin1.TabIndex = 9;
            coin1.TabStop = false;
            // 
            // coin2
            // 
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(85, 108);
            coin2.Name = "coin2";
            coin2.Size = new Size(40, 40);
            coin2.SizeMode = PictureBoxSizeMode.StretchImage;
            coin2.TabIndex = 10;
            coin2.TabStop = false;
            // 
            // coin3
            // 
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(310, 37);
            coin3.Name = "coin3";
            coin3.Size = new Size(40, 40);
            coin3.SizeMode = PictureBoxSizeMode.StretchImage;
            coin3.TabIndex = 11;
            coin3.TabStop = false;
            // 
            // bigcoin
            // 
            bigcoin.Image = (Image)resources.GetObject("bigcoin.Image");
            bigcoin.Location = new Point(26, 272);
            bigcoin.Name = "bigcoin";
            bigcoin.Size = new Size(40, 40);
            bigcoin.SizeMode = PictureBoxSizeMode.StretchImage;
            bigcoin.TabIndex = 12;
            bigcoin.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 13;
            label1.Text = "coins = 0";
            // 
            // restartbutton
            // 
            restartbutton.Location = new Point(158, 262);
            restartbutton.Name = "restartbutton";
            restartbutton.Size = new Size(75, 23);
            restartbutton.TabIndex = 14;
            restartbutton.Text = "Retry";
            restartbutton.UseVisualStyleBackColor = true;
            restartbutton.Click += restartbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(384, 461);
            Controls.Add(restartbutton);
            Controls.Add(label1);
            Controls.Add(bigcoin);
            Controls.Add(coin3);
            Controls.Add(coin2);
            Controls.Add(coin1);
            Controls.Add(over);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(enemy3);
            Controls.Add(car);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)car).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bigcoin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox car;
        private PictureBox enemy3;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private System.Windows.Forms.Timer timer1;
        private Label over;
        private PictureBox coin1;
        private PictureBox coin2;
        private PictureBox coin3;
        private PictureBox bigcoin;
        private Label label1;
        private Button restartbutton;
    }
}