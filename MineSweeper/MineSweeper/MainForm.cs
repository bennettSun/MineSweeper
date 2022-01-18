using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        PictureBox[,] btn;//紀錄按鈕
        int[,] bombs;//紀錄是否為炸彈
        bool stop;//暫停
        bool loseAt1st;
        int bomb;//炸彈數
        int level;//遊戲難度
        int flag;//旗子數
        double time;//時間
        void PutBtn(int cols, int rows, int bomb)//放炸彈
        {
            this.bomb = bomb;
            Size = new Size(cols * 25 + 16, rows * 25 + 115);//Form大小
            btn = new PictureBox[rows, cols];
            bombs = new int[rows, cols];
            splitContainer1.Panel2.Controls.Clear();//重設splitContainer1
            for (int r = 0; r < rows; r++)//放按鈕
            {
                for(int c = 0; c < cols; c++)
                {
                    btn[r, c] = new PictureBox();
                    btn[r, c].Image = imgBtn.Image;
                    btn[r, c].Width = btn[r, c].Height = 25;
                    btn[r, c].Top = r * 25;
                    btn[r, c].Left = c * 25;
                    btn[r, c].Click += Mine_Click;
                    btn[r, c].SizeMode = PictureBoxSizeMode.Zoom;
                    splitContainer1.Panel2.Controls.Add(btn[r, c]);
                }
            }
            PutBomb();
        }
        void PutBomb()
        {
            int rows = btn.GetLength(0);
            int cols = btn.GetLength(1);
            for (int r = 0; r < rows; r++)//清空炸彈
            {
                for (int c = 0; c < cols; c++)
                {
                    bombs[r, c] = 0;
                }
            }
            Random R = new Random();
            int Br, Bc;
            bool reDraw = false;//是否重抽
            for (int i = 0; i < bomb; i++)
            {
                Br = R.Next(rows);//炸彈位置
                Bc = R.Next(cols);
                if (bombs[Br, Bc] == 1)
                    reDraw = true;
                //消除周圍都是炸彈
                else if (Br == 0 && Bc == 0)//在左上角
                {
                    if (bombs[Br + 1, Bc] == 1 && bombs[Br + 1, Bc + 1] == 1 && bombs[Br, Bc + 1] == 1)
                        reDraw = true;
                }
                else if (Br == rows - 1 && Bc == 0)//在左下角
                {
                    if (bombs[Br, Bc + 1] == 1 && bombs[Br - 1, Bc + 1] == 1 && bombs[Br - 1, Bc] == 1)
                        reDraw = true;
                }
                else if (Br == 0 && Bc == cols - 1)//在右上角
                {
                    if (bombs[Br + 1, Bc] == 1 && bombs[Br, Bc - 1] == 1 && bombs[Br + 1, Bc - 1] == 1)
                        reDraw = true;
                }
                else if (Br == rows - 1 && Bc == cols - 1)//在右下角
                {
                    if (bombs[Br - 1, Bc] == 1 && bombs[Br - 1, Bc - 1] == 1 && bombs[Br, Bc - 1] == 1)
                        reDraw = true;
                }
                else if (Br == 0)//在最上排
                {
                    if (bombs[Br + 1, Bc] == 1 && bombs[Br + 1, Bc + 1] == 1 && bombs[Br, Bc + 1] == 1
                    && bombs[Br, Bc - 1] == 1 && bombs[Br + 1, Bc - 1] == 1)
                        reDraw = true;
                }
                else if (Br == rows - 1)//在最下排
                {
                    if (bombs[Br, Bc + 1] == 1 && bombs[Br - 1, Bc + 1] == 1 && bombs[Br - 1, Bc] == 1
                    && bombs[Br - 1, Bc - 1] == 1 && bombs[Br, Bc - 1] == 1)
                        reDraw = true;
                }
                else if (Bc == 0)//在最左排
                {
                    if (bombs[Br + 1, Bc] == 1 && bombs[Br + 1, Bc + 1] == 1 && bombs[Br, Bc + 1] == 1
                    && bombs[Br - 1, Bc + 1] == 1 && bombs[Br + 1, Bc - 1] == 1)
                        reDraw = true;
                }
                else if (Bc == cols - 1)//在最右排
                {
                    if (bombs[Br + 1, Bc] == 1 && bombs[Br - 1, Bc] == 1 && bombs[Br - 1, Bc - 1] == 1
                    && bombs[Br, Bc - 1] == 1 && bombs[Br + 1, Bc - 1] == 1)
                        reDraw = true;
                }
                else if (bombs[Br + 1, Bc] == 1 && bombs[Br + 1, Bc + 1] == 1 && bombs[Br, Bc + 1] == 1//在中間
                    && bombs[Br - 1, Bc + 1] == 1 && bombs[Br - 1, Bc] == 1 && bombs[Br - 1, Bc - 1] == 1
                    && bombs[Br, Bc - 1] == 1 && bombs[Br + 1, Bc - 1] == 1)
                    reDraw = true;
                if (reDraw)
                {
                    i--;
                    reDraw = false;
                    continue;
                }
                bombs[Br, Bc] = 1;
            }
        }
        void Reset()
        {
            switch (level)
            {
                case 1://easy
                    PutBtn(9, 9, 10);//行、列、炸彈數
                    break;
                case 2://common
                    PutBtn(16, 16, 40);
                    break;
                case 3://hard
                    PutBtn(30, 16, 99);
                    break;
            }
            splitContainer1.SplitterDistance = 70;
            imgResult.Visible = false;//關閉顯示數贏
            stop = false;//開始
            loseAt1st = true;
            labelResult.Text = "bomb: " + bomb;
            flag = 0;
            time = 0;
        }
        public MainForm()
        {
            InitializeComponent();
            level = 1;
            Reset();
        }
        private void Mine_Click(object sender, EventArgs e)//切換燈泡開關
        {
            if (stop)//如果暫停則無法按按鈕
                return;
            PictureBox btnSender = (PictureBox)sender;
            int r = btnSender.Top / 25;//判斷是哪個按鍵
            int c = btnSender.Left / 25;
            MouseEventArgs Mouse_e = (MouseEventArgs)e;
            if (Mouse_e.Button == MouseButtons.Right)//滑鼠按右鍵
            {
                if (btn[r, c].Image == imgFlag.Image)//如果是旗子，改顯示問號
                {
                    btn[r, c].Image = imgQM.Image;
                    flag -= 1;
                }
                else if (btn[r, c].Image == imgQM.Image)//如果是問號，改顯示預設
                {
                    btn[r, c].Image = imgBtn.Image;
                    flag -= 1;
                }
                else if (btn[r, c].Image == imgBtn.Image)//如果是預設，改顯示旗子
                {
                    btn[r, c].Image = imgFlag.Image;
                    flag += 1;
                }
                labelResult.Text = "bomb: " + (bomb - flag);//顯示剩餘炸彈數
                Win();//判斷是否勝利
                return;
            }
            if (btn[r, c].Image != imgBtn.Image)//如果按鈕非預設，則無法按
                return;
            int rows = btn.GetLength(0);
            int cols = btn.GetLength(1);
            if (bombs[r, c] == 1)//點到炸彈
            {
                double t = time;
                while (loseAt1st)
                {
                    PutBomb();
                    Mine_Click(sender, e);
                    time = t;
                    return;
                }
                btn[r, c].Image = imgBang.Image;//按到的鍵顯示爆炸
                bombs[r, c] = 2;
                for (r = 0; r < rows; r++)//顯示其他的所有炸彈
                {
                    for (c = 0; c < cols; c++)
                    {
                        if (bombs[r, c] == 1)
                        {
                            btn[r, c].Image = imgBomb.Image;
                        }
                    }
                }
                stop = true;//遊戲暫停
                labelResult.Text = "Restart";//炸彈數輛label改顯示Restart
                imgResult.Image = imgLose.Image;//顯示輸了
                imgResult.Visible = true;
                imgResult.Left = (int)(rows * 12.5 - 90);
                imgResult.Top = 20;
                splitContainer1.Panel2.Controls.Add(imgResult);
                imgResult.BringToFront();
                return;
            }
            loseAt1st = false;
            putNumber(r, c);//顯示結果數字
            Win();//判斷是否勝利
        }
        void findZero(int r, int c)//判斷九宮格內均無炸彈的按紐，用遞迴往上下左右找
        {
            int rows = btn.GetLength(0);
            int cols = btn.GetLength(1);
            if (r != rows - 1)//往下
            {
                if (btn[r + 1, c].Image == imgBtn.Image)
                {
                    if (findNumber(r + 1, c) == 0)
                    {
                        btn[r + 1, c].Image = imgGray.Image;
                        findZero(r + 1, c);
                    }
                    else
                        putNumber(r + 1, c);
                }
            }
            if (c != cols - 1)//往右
            {
                if (btn[r, c + 1].Image == imgBtn.Image)
                {
                    if (findNumber(r, c + 1) == 0)
                    {
                        btn[r, c + 1].Image = imgGray.Image;
                        findZero(r, c + 1);
                    }
                    else
                        putNumber(r, c + 1);
                }
            }
            if (r != 0)//往上
            {
                if (btn[r - 1, c].Image == imgBtn.Image)
                {
                    if (findNumber(r - 1, c) == 0)
                    {
                        btn[r - 1, c].Image = imgGray.Image;
                        findZero(r - 1, c);
                    }
                    else
                        putNumber(r - 1, c);
                }
            }
            if (c != 0)//往左
            {
                if (btn[r, c - 1].Image == imgBtn.Image)
                {
                    if (findNumber(r, c - 1) == 0)
                    {
                        btn[r, c - 1].Image = imgGray.Image;
                        findZero(r, c - 1);
                    }
                    else
                        putNumber(r, c - 1);
                }
            }
            //角落
            if (r + 1 != rows && c + 1 != cols)//右下
            {
                if(btn[r + 1, c + 1].Image == imgBtn.Image)
                {
                    putNumber(r + 1, c + 1);
                }
            }
            if (r + 1 != rows && c - 1 != -1)//右上
            {
                if (btn[r + 1, c - 1].Image == imgBtn.Image)
                {
                    putNumber(r + 1, c - 1);
                }
            }
            if (r - 1 != -1 && c + 1 != cols)//左下
            {
                if (btn[r - 1, c + 1].Image == imgBtn.Image)
                {
                    putNumber(r - 1, c + 1);
                }
            }
            if (r - 1 != -1 && c - 1 != -1)//左上
            {
                if (btn[r - 1, c - 1].Image == imgBtn.Image)
                {
                    putNumber(r - 1, c - 1);
                }
            }
        }
        int findNumber(int r,int c)//判斷九宮格有多少炸彈
        {
            int num;
            int rows = btn.GetLength(0);
            int cols = btn.GetLength(1);
            //判斷在不同位置下的九宮格
            if (r == 0 && c == 0)//左上角
                num = bombs[r + 1, c] + bombs[r + 1, c + 1] + bombs[r, c + 1];
            else if (r == rows - 1 && c == 0)//左下角
                num = bombs[r, c + 1] + bombs[r - 1, c + 1] + bombs[r - 1, c];
            else if (r == 0 && c == cols - 1)//右上角
                num = bombs[r + 1, c] + bombs[r, c - 1] + bombs[r + 1, c - 1];
            else if (r == rows - 1 && c == cols - 1)//右下角
                num = bombs[r - 1, c] + bombs[r - 1, c - 1] + bombs[r, c - 1];
            else if (r == 0)//最上排
                num = bombs[r + 1, c] + bombs[r + 1, c + 1] + bombs[r, c + 1] + bombs[r, c - 1] + bombs[r + 1, c - 1];
            else if (r == rows - 1)//最下排
                num = bombs[r, c + 1] + bombs[r - 1, c + 1] + bombs[r - 1, c] + bombs[r - 1, c - 1] + bombs[r, c - 1];
            else if (c == 0)//最左排
                num = bombs[r + 1, c] + bombs[r + 1, c + 1] + bombs[r, c + 1] + bombs[r - 1, c + 1] + bombs[r - 1, c];
            else if (c == cols - 1)//最右排
                num = bombs[r + 1, c] + bombs[r - 1, c] + bombs[r - 1, c - 1] + bombs[r, c - 1] + bombs[r + 1, c - 1];
            else//在中間
                num = bombs[r + 1, c] + bombs[r + 1, c + 1] + bombs[r, c + 1] + bombs[r - 1, c + 1] + bombs[r - 1, c] + bombs[r - 1, c - 1] + bombs[r, c - 1] + bombs[r + 1, c - 1];
            return num;
        }
        void putNumber(int r, int c)//顯示數字
        {
            switch (findNumber(r, c))
            {
                case 1:
                    btn[r, c].Image = imgOne.Image;
                    break;
                case 2:
                    btn[r, c].Image = imgTwo.Image;
                    break;
                case 3:
                    btn[r, c].Image = imgThree.Image;
                    break;
                case 4:
                    btn[r, c].Image = imgFour.Image;
                    break;
                case 5:
                    btn[r, c].Image = imgFive.Image;
                    break;
                case 6:
                    btn[r, c].Image = imgSix.Image;
                    break;
                case 7:
                    btn[r, c].Image = imgSeven.Image;
                    break;
                case 8:
                    btn[r, c].Image = imgEight.Image;
                    break;
                case 0:
                    btn[r, c].Image = imgGray.Image;
                    findZero(r, c);
                    break;
            }
        }
        void Win()//判斷是否勝利
        {
            int rows = btn.GetLength(0);
            int cols = btn.GetLength(1);
            bool notWin = false;
            int lastBomb = 0;
            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < cols; c++)
                {
                    if((bombs[r,c]==1&&btn[r,c].Image!=imgFlag.Image)|| (bombs[r, c] == 0 && btn[r, c].Image == imgFlag.Image))//若每個炸彈都有放旗子且沒多放，則勝利
                    {
                        notWin = true;
                    }
                    if(btn[r, c].Image == imgFlag.Image || btn[r, c].Image == imgBtn.Image)//判斷是否剩下炸彈
                    {
                        lastBomb += 1;
                    }
                }
            }
            if (bomb == lastBomb || !notWin)//勝利，顯示結果，遊戲暫停
            {
                stop = true;
                labelResult.Text = "Restart";
                imgResult.Image = imgWin.Image;
                imgResult.Visible = true;
                imgResult.Left = (int)(rows * 12.5 - 90);
                imgResult.Top = 20;
                splitContainer1.Panel2.Controls.Add(imgResult);
                imgResult.BringToFront();
            }
        }
        private void labelResult_Click(object sender, EventArgs e)//點選重新開始
        {
            if (stop)
            {
                Reset();
            }
        }
        private void rbtnEasy_CheckedChanged(object sender, EventArgs e)//選擇簡單版
        {
            if (level != 1)
            {
                level = 1;
                Reset();
            }
        }
        private void rbtnCommon_CheckedChanged(object sender, EventArgs e)//選擇普通版
        {
            if (level != 2)
            {
                level = 2;
                Reset();
            }
        }

        private void rbtnHard_CheckedChanged(object sender, EventArgs e)//選擇困難版
        {
            if (level != 3)
            {
                level = 3;
                Reset();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//顯示遊戲間
        {
            if (!stop)
            {
                time += 0.1;
                labelTimer.Text = $"Time: {time:0}";
            }
        }
    }
}
