using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inquiry_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nameBox.Text);

            if (juusyoBox.Text == "")
            {
                MessageBox.Show("住所未入力です。");
            }
            else if (AdoresuBox.Text == "")
            {
                MessageBox.Show("アドレス未入力です。");
            }
            else if (TelBox.Text == "")
            {
                MessageBox.Show("電話番号未入力です。");
            }
            else if (checkBox1.Checked == false)
            {
                label8.Text = "利用規約に同意してください。";
            }

            // どのボタンを選択したかを判断する
            if (MessageBox.Show("登録しますか？", "会員登録", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("登録されました！", "登録完了");
                using (StreamWriter writer = new StreamWriter("data.csv", true))
                //書き込む先のファイル名は"data.csv"
                {
                    writer.Write(nameBox.Text); //textboxの内容を書き込む
                    writer.Write(",");          //任意（ここではカンマ）のTextを書き込む。
                    writer.Write(juusyoBox.Text);
                    writer.Write(",");
                    writer.Write(AdoresuBox.Text);
                    writer.Write(",");
                    writer.Write(TelBox.Text);
                    writer.Write(",");
                    writer.Write(comboBox1.Text);
                    writer.Write("\n");  //改行

                }
            }
            else
            {
                MessageBox.Show("キャンセルしました");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2を表示する
            Form2 f = new Form2();
            //ダイアログとして表示する
            f.ShowDialog(this);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nameBox.ResetText();
            juusyoBox.ResetText();
            AdoresuBox.ResetText();
            TelBox.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
