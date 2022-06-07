
namespace Rock_Paper_scissor_game
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSpock = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnLizard = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(79, 110);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 0;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(79, 149);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 0;
            this.btnScissor.Text = "Scissor";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSpock
            // 
            this.btnSpock.Location = new System.Drawing.Point(79, 235);
            this.btnSpock.Name = "btnSpock";
            this.btnSpock.Size = new System.Drawing.Size(75, 25);
            this.btnSpock.TabIndex = 0;
            this.btnSpock.Text = "Spock";
            this.btnSpock.UseVisualStyleBackColor = true;
            this.btnSpock.Click += new System.EventHandler(this.btnSpock_Click);
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(79, 69);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnLizard
            // 
            this.btnLizard.Location = new System.Drawing.Point(79, 191);
            this.btnLizard.Name = "btnLizard";
            this.btnLizard.Size = new System.Drawing.Size(75, 23);
            this.btnLizard.TabIndex = 0;
            this.btnLizard.Text = "Lizard";
            this.btnLizard.UseVisualStyleBackColor = true;
            this.btnLizard.Click += new System.EventHandler(this.btnLizard_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(731, 321);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 25);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // picCPU
            // 
            this.picCPU.Image = global::Rock_Paper_scissor_game.Properties.Resources.qq;
            this.picCPU.Location = new System.Drawing.Point(635, 69);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(171, 191);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 1;
            this.picCPU.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::Rock_Paper_scissor_game.Properties.Resources.qq;
            this.picPlayer.Location = new System.Drawing.Point(223, 69);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(171, 191);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Player";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = " ";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(454, 69);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(140, 20);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Player:0 - CPU:0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCountDown
            // 
            this.txtCountDown.AutoSize = true;
            this.txtCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountDown.Location = new System.Drawing.Point(514, 113);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(19, 20);
            this.txtCountDown.TabIndex = 2;
            this.txtCountDown.Text = "5";
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRounds.Location = new System.Drawing.Point(482, 266);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(82, 20);
            this.txtRounds.TabIndex = 2;
            this.txtRounds.Text = "Round: 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(476, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 2;
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimerEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPU";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 347);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.btnLizard);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSpock);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissor Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSpock;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnLizard;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

