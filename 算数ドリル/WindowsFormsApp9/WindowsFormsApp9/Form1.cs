using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        long noA = 0;
        long noB = 0;
        long noC = 0;
        long mondaiCnt = 0;
        long mondaiMax = 0;
        long seikaiCnt = 0;
        long type = 0;        //1:足し算 2:引き算
        string typeStr;       //演算記号表示

        
        public Form1()
        {
            InitializeComponent();
        }

        private void InBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数値およびバックスぺースのみを受け入れる
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
            {
                if(e.KeyChar != '-' && InBox.TextLength == 0)
                { 
                e.Handled = true;
                }
            }

            if ((e.KeyChar == (char)Keys.Enter ) && InBox.Text != "" && InBox.Text != "-")
            { 
                Console.WriteLine(InBox.Text);
                OutBox.AppendText(InBox.Text + "\r\n");
                Kotaeawase();
                InBox.Text = "";
                if ( mondaiCnt < mondaiMax )
                {
                    Mondaisakusei();
                }
                else
                {
                    Seiseki();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InBox.Enabled = false;
        }

        private void Mondaisakusei()
        {
            noA = rand.Next(1, 10);
            noB = rand.Next(1, 10);
            MondaiLbl.Text = noA + typeStr + noB + " = ";
            if (type == 1)
            {
                noC = noA + noB;
            }
            if (type == 2)
            {
                noC = noA - noB;
            }
            if (type == 3)
            {
                noC = noA * noB;
            }
            //if (type == 4)
            //{
            //    noC = noA / noB;
            //}


            mondaiCnt++;
        }

        private void Kotaeawase()
        {
            if ( noC == Int64.Parse(InBox.Text) )
            {
                OutBox.AppendText("○ ");
                seikaiCnt++;
            }
            else
            {
                OutBox.AppendText("× ");
            }
            OutBox.AppendText(MondaiLbl.Text + InBox.Text + "\r\n");
        }

        private void Seiseki()
        {
            InBox.Enabled = false;
            MondaiLbl.Text = "";
            OutBox.AppendText("正解数は " + seikaiCnt + " です");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //問題を変更する
            if( RB10.Checked)
            {
                mondaiMax = 10;
            }
            if( RB20.Checked)
            {
                mondaiMax = 20;
            }
            if( RB30.Checked)
            {
                mondaiMax = 30;
            }
            
            //計算タイプを変更
            if( RBtasu.Checked)
            {
                type = 1;
                typeStr = " + ";
            }
            if( RBhiku.Checked)
            {
                type = 2;
                typeStr = " - ";
            }
            if (RBkake.Checked)
            {
                type = 3;
                typeStr = " × ";
            }
            //if (RBwaru.Checked)
            //{
            //    type = 4;
            //    typeStr = " ÷ ";
            //}

            mondaiCnt = 0;
            seikaiCnt = 0;
            Mondaisakusei();
            InBox.Enabled = true;
            InBox.Focus();   //解答欄へフォーカスを移す
        }
    }
}
