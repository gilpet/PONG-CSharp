namespace WindowsFormsApplication2
{
    partial class Pong
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
            this.components = new System.ComponentModel.Container();
            this.Computer = new System.Windows.Forms.PictureBox();
            this.ComputerScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayerScore = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Computer
            // 
            this.Computer.BackColor = System.Drawing.Color.Red;
            this.Computer.Location = new System.Drawing.Point(12, 147);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(16, 128);
            this.Computer.TabIndex = 0;
            this.Computer.TabStop = false;
            // 
            // ComputerScore
            // 
            this.ComputerScore.AutoSize = true;
            this.ComputerScore.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScore.Location = new System.Drawing.Point(51, 42);
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(30, 33);
            this.ComputerScore.TabIndex = 1;
            this.ComputerScore.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.Location = new System.Drawing.Point(518, 42);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(30, 33);
            this.PlayerScore.TabIndex = 2;
            this.PlayerScore.Text = "0";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Blue;
            this.Player.Location = new System.Drawing.Point(596, 147);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(16, 128);
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.ErrorImage = global::WindowsFormsApplication2.Properties.Resources.ball4;
            this.Ball.Image = global::WindowsFormsApplication2.Properties.Resources.ball4;
            this.Ball.InitialImage = global::WindowsFormsApplication2.Properties.Resources.ball4;
            this.Ball.Location = new System.Drawing.Point(304, 157);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.TabIndex = 4;
            this.Ball.TabStop = false;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.ComputerScore);
            this.Controls.Add(this.Computer);
            this.Name = "Pong";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Computer;
        private System.Windows.Forms.Label ComputerScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ball;
    }
}

