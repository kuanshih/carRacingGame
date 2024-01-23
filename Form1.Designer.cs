namespace carRacingGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picAI2 = new System.Windows.Forms.PictureBox();
            this.picAI1 = new System.Windows.Forms.PictureBox();
            this.picBoxAwade = new System.Windows.Forms.PictureBox();
            this.picBoxExplosion = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            this.picBoxRoadTrack1 = new System.Windows.Forms.PictureBox();
            this.picBoxRoadTrack2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.labScore = new System.Windows.Forms.Label();
            this.labDiscription = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAwade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRoadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRoadTrack2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.picAI2);
            this.panel1.Controls.Add(this.picAI1);
            this.panel1.Controls.Add(this.picBoxAwade);
            this.panel1.Controls.Add(this.picBoxExplosion);
            this.panel1.Controls.Add(this.picBoxPlayer);
            this.panel1.Controls.Add(this.picBoxRoadTrack1);
            this.panel1.Controls.Add(this.picBoxRoadTrack2);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 519);
            this.panel1.TabIndex = 0;
            // 
            // picAI2
            // 
            this.picAI2.Image = global::carRacingGame.Properties.Resources.carGrey;
            this.picAI2.Location = new System.Drawing.Point(330, 76);
            this.picAI2.Margin = new System.Windows.Forms.Padding(2);
            this.picAI2.Name = "picAI2";
            this.picAI2.Size = new System.Drawing.Size(50, 100);
            this.picAI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAI2.TabIndex = 2;
            this.picAI2.TabStop = false;
            this.picAI2.Tag = "carRight";
            // 
            // picAI1
            // 
            this.picAI1.Image = global::carRacingGame.Properties.Resources.carGreen;
            this.picAI1.Location = new System.Drawing.Point(86, 75);
            this.picAI1.Margin = new System.Windows.Forms.Padding(2);
            this.picAI1.Name = "picAI1";
            this.picAI1.Size = new System.Drawing.Size(50, 101);
            this.picAI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAI1.TabIndex = 2;
            this.picAI1.TabStop = false;
            this.picAI1.Tag = "carLeft";
            // 
            // picBoxAwade
            // 
            this.picBoxAwade.Image = global::carRacingGame.Properties.Resources.bronze;
            this.picBoxAwade.Location = new System.Drawing.Point(130, 224);
            this.picBoxAwade.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxAwade.Name = "picBoxAwade";
            this.picBoxAwade.Size = new System.Drawing.Size(250, 100);
            this.picBoxAwade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxAwade.TabIndex = 2;
            this.picBoxAwade.TabStop = false;
            // 
            // picBoxExplosion
            // 
            this.picBoxExplosion.Image = global::carRacingGame.Properties.Resources.explosion;
            this.picBoxExplosion.Location = new System.Drawing.Point(53, 375);
            this.picBoxExplosion.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxExplosion.Name = "picBoxExplosion";
            this.picBoxExplosion.Size = new System.Drawing.Size(64, 64);
            this.picBoxExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxExplosion.TabIndex = 2;
            this.picBoxExplosion.TabStop = false;
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.Image = global::carRacingGame.Properties.Resources.carYellow;
            this.picBoxPlayer.Location = new System.Drawing.Point(214, 400);
            this.picBoxPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(50, 99);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxPlayer.TabIndex = 2;
            this.picBoxPlayer.TabStop = false;
            // 
            // picBoxRoadTrack1
            // 
            this.picBoxRoadTrack1.Image = global::carRacingGame.Properties.Resources.roadTrack;
            this.picBoxRoadTrack1.Location = new System.Drawing.Point(0, 519);
            this.picBoxRoadTrack1.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxRoadTrack1.Name = "picBoxRoadTrack1";
            this.picBoxRoadTrack1.Size = new System.Drawing.Size(476, 519);
            this.picBoxRoadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRoadTrack1.TabIndex = 0;
            this.picBoxRoadTrack1.TabStop = false;
            // 
            // picBoxRoadTrack2
            // 
            this.picBoxRoadTrack2.Image = global::carRacingGame.Properties.Resources.roadTrack;
            this.picBoxRoadTrack2.Location = new System.Drawing.Point(0, 0);
            this.picBoxRoadTrack2.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxRoadTrack2.Name = "picBoxRoadTrack2";
            this.picBoxRoadTrack2.Size = new System.Drawing.Size(476, 519);
            this.picBoxRoadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRoadTrack2.TabIndex = 3;
            this.picBoxRoadTrack2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(201, 619);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.resartGame);
            // 
            // labScore
            // 
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.Location = new System.Drawing.Point(89, 576);
            this.labScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(297, 19);
            this.labScore.TabIndex = 2;
            this.labScore.Text = "Score: 0";
            this.labScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labDiscription
            // 
            this.labDiscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiscription.Location = new System.Drawing.Point(89, 676);
            this.labDiscription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDiscription.Name = "labDiscription";
            this.labDiscription.Size = new System.Drawing.Size(297, 76);
            this.labDiscription.TabIndex = 3;
            this.labDiscription.Text = "Press and right to move the car\r\n\r\nDon\'t hit any other cars in the gamae and try " +
    "to survive as  long as you can";
            this.labDiscription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 781);
            this.Controls.Add(this.labDiscription);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAwade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRoadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRoadTrack2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labDiscription;
        private System.Windows.Forms.PictureBox picAI2;
        private System.Windows.Forms.PictureBox picAI1;
        private System.Windows.Forms.PictureBox picBoxAwade;
        private System.Windows.Forms.PictureBox picBoxExplosion;
        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.PictureBox picBoxRoadTrack1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox picBoxRoadTrack2;
    }
}

