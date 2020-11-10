using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        enum eArithmetic
        {
                Div
                ,Mutl
                ,Sub
                ,Add
                ,None
        }
        eArithmetic gArithmetic;
        decimal gVal1;

        

        public Form1()
        {
            InitializeComponent();
            this.txtResult.Text = "0";
            gArithmetic = eArithmetic.None;
            gVal1 = 0;
        }
         

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            decimal iNum = Decimal.Parse(this.txtResult.Text + btn.Text);
            this.txtResult.Text = iNum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArithmetic_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "÷")
            {
                gArithmetic = eArithmetic.Div;
            }
            if (btn.Text == "×")
            {
                gArithmetic = eArithmetic.Mutl;
            }
            if (btn.Text == "-")
            {
                gArithmetic = eArithmetic.Sub;
            }
            if (btn.Text == "+")
            {
                gArithmetic = eArithmetic.Add;
            }
            //Val1 + Val2 = Result
            gVal1 = Decimal.Parse(this.txtResult.Text);
            this.txtResult.Text = "0";

        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            decimal Val2 = Decimal.Parse(this.txtResult.Text);
            decimal valResult = 0;

            //this.txtResult.Text = (gVal1 + Val2).ToString();

            //this.txtResult.Text = (gVal1 - Val2).ToString();

            //this.txtResult.Text = (gVal1 * Val2).ToString();

            //this.txtResult.Text = (gVal1 / Val2).ToString();

            switch (gArithmetic)
            {
                case eArithmetic.Div:
                    valResult = gVal1 / Val2;
                    break;
                case eArithmetic.Mutl:
                    valResult = gVal1 * Val2;
                    break;
                case eArithmetic.Sub:
                    valResult = gVal1 - Val2;
                    break;
                case eArithmetic.Add:
                    valResult = gVal1 + Val2;
                    break;
                default:
                    break;
            }
            this.txtResult.Text = valResult.ToString();
            //gVal1 = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "0";
            gArithmetic = eArithmetic.None;
            gVal1 = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.IndexOf(".") >= 0)
            {
            return;
            }
                txtResult.Text = txtResult.Text + "."; 
        }
        
    }
}
