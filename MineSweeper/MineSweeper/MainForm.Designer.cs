
namespace MineSweeper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnCommon = new System.Windows.Forms.RadioButton();
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.imgLose = new System.Windows.Forms.PictureBox();
            this.imgResult = new System.Windows.Forms.PictureBox();
            this.imgWin = new System.Windows.Forms.PictureBox();
            this.imgEight = new System.Windows.Forms.PictureBox();
            this.imgSeven = new System.Windows.Forms.PictureBox();
            this.imgSix = new System.Windows.Forms.PictureBox();
            this.imgFive = new System.Windows.Forms.PictureBox();
            this.imgFour = new System.Windows.Forms.PictureBox();
            this.imgThree = new System.Windows.Forms.PictureBox();
            this.imgTwo = new System.Windows.Forms.PictureBox();
            this.imgOne = new System.Windows.Forms.PictureBox();
            this.imgGray = new System.Windows.Forms.PictureBox();
            this.imgFlag = new System.Windows.Forms.PictureBox();
            this.imgBtn = new System.Windows.Forms.PictureBox();
            this.imgBomb = new System.Windows.Forms.PictureBox();
            this.imgBang = new System.Windows.Forms.PictureBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgQM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQM)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.labelTimer);
            this.splitContainer1.Panel1.Controls.Add(this.labelResult);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnHard);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnCommon);
            this.splitContainer1.Panel1.Controls.Add(this.rbtnEasy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imgQM);
            this.splitContainer1.Panel2.Controls.Add(this.imgLose);
            this.splitContainer1.Panel2.Controls.Add(this.imgResult);
            this.splitContainer1.Panel2.Controls.Add(this.imgWin);
            this.splitContainer1.Panel2.Controls.Add(this.imgEight);
            this.splitContainer1.Panel2.Controls.Add(this.imgSeven);
            this.splitContainer1.Panel2.Controls.Add(this.imgSix);
            this.splitContainer1.Panel2.Controls.Add(this.imgFive);
            this.splitContainer1.Panel2.Controls.Add(this.imgFour);
            this.splitContainer1.Panel2.Controls.Add(this.imgThree);
            this.splitContainer1.Panel2.Controls.Add(this.imgTwo);
            this.splitContainer1.Panel2.Controls.Add(this.imgOne);
            this.splitContainer1.Panel2.Controls.Add(this.imgGray);
            this.splitContainer1.Panel2.Controls.Add(this.imgFlag);
            this.splitContainer1.Panel2.Controls.Add(this.imgBtn);
            this.splitContainer1.Panel2.Controls.Add(this.imgBomb);
            this.splitContainer1.Panel2.Controls.Add(this.imgBang);
            this.splitContainer1.Size = new System.Drawing.Size(688, 701);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.labelResult.Location = new System.Drawing.Point(140, 5);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(80, 30);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "bomb";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Level:";
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Location = new System.Drawing.Point(59, 41);
            this.rbtnHard.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(77, 27);
            this.rbtnHard.TabIndex = 2;
            this.rbtnHard.TabStop = true;
            this.rbtnHard.Text = "Hard";
            this.rbtnHard.UseVisualStyleBackColor = true;
            this.rbtnHard.CheckedChanged += new System.EventHandler(this.rbtnHard_CheckedChanged);
            // 
            // rbtnCommon
            // 
            this.rbtnCommon.AutoSize = true;
            this.rbtnCommon.Location = new System.Drawing.Point(59, 23);
            this.rbtnCommon.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCommon.Name = "rbtnCommon";
            this.rbtnCommon.Size = new System.Drawing.Size(114, 27);
            this.rbtnCommon.TabIndex = 1;
            this.rbtnCommon.TabStop = true;
            this.rbtnCommon.Text = "Common";
            this.rbtnCommon.UseVisualStyleBackColor = true;
            this.rbtnCommon.CheckedChanged += new System.EventHandler(this.rbtnCommon_CheckedChanged);
            // 
            // rbtnEasy
            // 
            this.rbtnEasy.AutoSize = true;
            this.rbtnEasy.Location = new System.Drawing.Point(59, 5);
            this.rbtnEasy.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnEasy.Name = "rbtnEasy";
            this.rbtnEasy.Size = new System.Drawing.Size(72, 27);
            this.rbtnEasy.TabIndex = 0;
            this.rbtnEasy.TabStop = true;
            this.rbtnEasy.Text = "Easy";
            this.rbtnEasy.UseVisualStyleBackColor = true;
            this.rbtnEasy.CheckedChanged += new System.EventHandler(this.rbtnEasy_CheckedChanged);
            // 
            // imgLose
            // 
            this.imgLose.ErrorImage = null;
            this.imgLose.Image = ((System.Drawing.Image)(resources.GetObject("imgLose.Image")));
            this.imgLose.Location = new System.Drawing.Point(503, 143);
            this.imgLose.Margin = new System.Windows.Forms.Padding(4);
            this.imgLose.Name = "imgLose";
            this.imgLose.Size = new System.Drawing.Size(172, 98);
            this.imgLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLose.TabIndex = 16;
            this.imgLose.TabStop = false;
            this.imgLose.Visible = false;
            // 
            // imgResult
            // 
            this.imgResult.ErrorImage = null;
            this.imgResult.Location = new System.Drawing.Point(503, 249);
            this.imgResult.Margin = new System.Windows.Forms.Padding(4);
            this.imgResult.Name = "imgResult";
            this.imgResult.Size = new System.Drawing.Size(172, 98);
            this.imgResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgResult.TabIndex = 15;
            this.imgResult.TabStop = false;
            // 
            // imgWin
            // 
            this.imgWin.ErrorImage = null;
            this.imgWin.Image = ((System.Drawing.Image)(resources.GetObject("imgWin.Image")));
            this.imgWin.Location = new System.Drawing.Point(503, 37);
            this.imgWin.Margin = new System.Windows.Forms.Padding(4);
            this.imgWin.Name = "imgWin";
            this.imgWin.Size = new System.Drawing.Size(172, 98);
            this.imgWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgWin.TabIndex = 14;
            this.imgWin.TabStop = false;
            this.imgWin.Visible = false;
            // 
            // imgEight
            // 
            this.imgEight.ErrorImage = null;
            this.imgEight.Image = ((System.Drawing.Image)(resources.GetObject("imgEight.Image")));
            this.imgEight.Location = new System.Drawing.Point(403, 443);
            this.imgEight.Margin = new System.Windows.Forms.Padding(4);
            this.imgEight.Name = "imgEight";
            this.imgEight.Size = new System.Drawing.Size(122, 128);
            this.imgEight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEight.TabIndex = 13;
            this.imgEight.TabStop = false;
            this.imgEight.Visible = false;
            // 
            // imgSeven
            // 
            this.imgSeven.ErrorImage = null;
            this.imgSeven.Image = ((System.Drawing.Image)(resources.GetObject("imgSeven.Image")));
            this.imgSeven.Location = new System.Drawing.Point(274, 443);
            this.imgSeven.Margin = new System.Windows.Forms.Padding(4);
            this.imgSeven.Name = "imgSeven";
            this.imgSeven.Size = new System.Drawing.Size(122, 128);
            this.imgSeven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSeven.TabIndex = 12;
            this.imgSeven.TabStop = false;
            this.imgSeven.Visible = false;
            // 
            // imgSix
            // 
            this.imgSix.ErrorImage = null;
            this.imgSix.Image = ((System.Drawing.Image)(resources.GetObject("imgSix.Image")));
            this.imgSix.Location = new System.Drawing.Point(144, 443);
            this.imgSix.Margin = new System.Windows.Forms.Padding(4);
            this.imgSix.Name = "imgSix";
            this.imgSix.Size = new System.Drawing.Size(122, 128);
            this.imgSix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSix.TabIndex = 11;
            this.imgSix.TabStop = false;
            this.imgSix.Visible = false;
            // 
            // imgFive
            // 
            this.imgFive.ErrorImage = null;
            this.imgFive.Image = ((System.Drawing.Image)(resources.GetObject("imgFive.Image")));
            this.imgFive.Location = new System.Drawing.Point(15, 443);
            this.imgFive.Margin = new System.Windows.Forms.Padding(4);
            this.imgFive.Name = "imgFive";
            this.imgFive.Size = new System.Drawing.Size(122, 128);
            this.imgFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFive.TabIndex = 10;
            this.imgFive.TabStop = false;
            this.imgFive.Visible = false;
            // 
            // imgFour
            // 
            this.imgFour.ErrorImage = null;
            this.imgFour.Image = ((System.Drawing.Image)(resources.GetObject("imgFour.Image")));
            this.imgFour.Location = new System.Drawing.Point(403, 308);
            this.imgFour.Margin = new System.Windows.Forms.Padding(4);
            this.imgFour.Name = "imgFour";
            this.imgFour.Size = new System.Drawing.Size(122, 128);
            this.imgFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFour.TabIndex = 9;
            this.imgFour.TabStop = false;
            this.imgFour.Visible = false;
            // 
            // imgThree
            // 
            this.imgThree.ErrorImage = null;
            this.imgThree.Image = ((System.Drawing.Image)(resources.GetObject("imgThree.Image")));
            this.imgThree.Location = new System.Drawing.Point(274, 308);
            this.imgThree.Margin = new System.Windows.Forms.Padding(4);
            this.imgThree.Name = "imgThree";
            this.imgThree.Size = new System.Drawing.Size(122, 128);
            this.imgThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgThree.TabIndex = 8;
            this.imgThree.TabStop = false;
            this.imgThree.Visible = false;
            // 
            // imgTwo
            // 
            this.imgTwo.ErrorImage = null;
            this.imgTwo.Image = ((System.Drawing.Image)(resources.GetObject("imgTwo.Image")));
            this.imgTwo.Location = new System.Drawing.Point(144, 308);
            this.imgTwo.Margin = new System.Windows.Forms.Padding(4);
            this.imgTwo.Name = "imgTwo";
            this.imgTwo.Size = new System.Drawing.Size(122, 128);
            this.imgTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTwo.TabIndex = 7;
            this.imgTwo.TabStop = false;
            this.imgTwo.Visible = false;
            // 
            // imgOne
            // 
            this.imgOne.ErrorImage = null;
            this.imgOne.Image = ((System.Drawing.Image)(resources.GetObject("imgOne.Image")));
            this.imgOne.Location = new System.Drawing.Point(15, 308);
            this.imgOne.Margin = new System.Windows.Forms.Padding(4);
            this.imgOne.Name = "imgOne";
            this.imgOne.Size = new System.Drawing.Size(122, 128);
            this.imgOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOne.TabIndex = 6;
            this.imgOne.TabStop = false;
            this.imgOne.Visible = false;
            // 
            // imgGray
            // 
            this.imgGray.ErrorImage = null;
            this.imgGray.Image = ((System.Drawing.Image)(resources.GetObject("imgGray.Image")));
            this.imgGray.Location = new System.Drawing.Point(274, 172);
            this.imgGray.Margin = new System.Windows.Forms.Padding(4);
            this.imgGray.Name = "imgGray";
            this.imgGray.Size = new System.Drawing.Size(122, 128);
            this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGray.TabIndex = 5;
            this.imgGray.TabStop = false;
            this.imgGray.Visible = false;
            // 
            // imgFlag
            // 
            this.imgFlag.ErrorImage = null;
            this.imgFlag.Image = ((System.Drawing.Image)(resources.GetObject("imgFlag.Image")));
            this.imgFlag.Location = new System.Drawing.Point(15, 173);
            this.imgFlag.Margin = new System.Windows.Forms.Padding(4);
            this.imgFlag.Name = "imgFlag";
            this.imgFlag.Size = new System.Drawing.Size(122, 128);
            this.imgFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFlag.TabIndex = 4;
            this.imgFlag.TabStop = false;
            this.imgFlag.Visible = false;
            // 
            // imgBtn
            // 
            this.imgBtn.ErrorImage = null;
            this.imgBtn.Image = ((System.Drawing.Image)(resources.GetObject("imgBtn.Image")));
            this.imgBtn.Location = new System.Drawing.Point(274, 37);
            this.imgBtn.Margin = new System.Windows.Forms.Padding(4);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.Size = new System.Drawing.Size(122, 128);
            this.imgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBtn.TabIndex = 3;
            this.imgBtn.TabStop = false;
            this.imgBtn.Tag = "1";
            this.imgBtn.Visible = false;
            // 
            // imgBomb
            // 
            this.imgBomb.ErrorImage = null;
            this.imgBomb.Image = ((System.Drawing.Image)(resources.GetObject("imgBomb.Image")));
            this.imgBomb.Location = new System.Drawing.Point(144, 37);
            this.imgBomb.Margin = new System.Windows.Forms.Padding(4);
            this.imgBomb.Name = "imgBomb";
            this.imgBomb.Size = new System.Drawing.Size(122, 128);
            this.imgBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBomb.TabIndex = 2;
            this.imgBomb.TabStop = false;
            this.imgBomb.Visible = false;
            // 
            // imgBang
            // 
            this.imgBang.Image = ((System.Drawing.Image)(resources.GetObject("imgBang.Image")));
            this.imgBang.Location = new System.Drawing.Point(15, 37);
            this.imgBang.Margin = new System.Windows.Forms.Padding(4);
            this.imgBang.Name = "imgBang";
            this.imgBang.Size = new System.Drawing.Size(122, 128);
            this.imgBang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBang.TabIndex = 1;
            this.imgBang.TabStop = false;
            this.imgBang.Visible = false;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.labelTimer.Location = new System.Drawing.Point(139, 35);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(64, 30);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgQM
            // 
            this.imgQM.ErrorImage = null;
            this.imgQM.Image = ((System.Drawing.Image)(resources.GetObject("imgQM.Image")));
            this.imgQM.Location = new System.Drawing.Point(144, 173);
            this.imgQM.Margin = new System.Windows.Forms.Padding(4);
            this.imgQM.Name = "imgQM";
            this.imgQM.Size = new System.Drawing.Size(122, 128);
            this.imgQM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgQM.TabIndex = 17;
            this.imgQM.TabStop = false;
            this.imgQM.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 701);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox imgBang;
        private System.Windows.Forms.PictureBox imgBomb;
        private System.Windows.Forms.PictureBox imgBtn;
        private System.Windows.Forms.PictureBox imgGray;
        private System.Windows.Forms.PictureBox imgFlag;
        private System.Windows.Forms.PictureBox imgEight;
        private System.Windows.Forms.PictureBox imgSeven;
        private System.Windows.Forms.PictureBox imgSix;
        private System.Windows.Forms.PictureBox imgFive;
        private System.Windows.Forms.PictureBox imgFour;
        private System.Windows.Forms.PictureBox imgThree;
        private System.Windows.Forms.PictureBox imgTwo;
        private System.Windows.Forms.PictureBox imgOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.RadioButton rbtnCommon;
        private System.Windows.Forms.RadioButton rbtnEasy;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox imgWin;
        private System.Windows.Forms.PictureBox imgLose;
        private System.Windows.Forms.PictureBox imgResult;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox imgQM;
    }
}

