using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        DateTime now;
        DateTime startTime;
        BackgroundWorker bw;
        TimeSpan ts;
        bool isStoped = false;
        List<TimeSpan> ts1 = new List<TimeSpan>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ts = new TimeSpan(0);
            bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.WorkerSupportsCancellation = true;
        }
        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button1.Text = "Start";
            if (isStoped)
            {
                ts = new TimeSpan(0);
                label1.Text = "00:00:00.000";
                ts1.Clear();
                dataGridView1.Rows.Clear();
                isStoped = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                startTime = DateTime.Now - ts;
                bw.RunWorkerAsync();
                button1.Text = "Pause";
            }
            else
            {
                bw.CancelAsync();
                button1.Text = "Start";
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            isStoped = true;
            if (bw.IsBusy)
            {
                bw.CancelAsync();
            }
            else
            {
                ts = new TimeSpan(0);
                label1.Text = "00:00:00.000";
                isStoped = false;
            }
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!bw.CancellationPending)
            {
                now = DateTime.Now;
                ts = now - startTime;
                try
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        label1.Text = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                    });
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy) return;
            ts1.Add(ts);
                TimeSpan tmp = new TimeSpan(0);
                if (ts1.Count <= 1)
            {
                tmp = ts1[ts1.Count - 1];
            }
            else
            {
                tmp = ts1[ts1.Count - 1] - ts1[ts1.Count - 2];
            }
            DataGridViewTextBoxCell jikoku = new DataGridViewTextBoxCell();
            DataGridViewTextBoxCell laptime = new DataGridViewTextBoxCell();
            jikoku.Value = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", now.Hour, now.Minute, now.Second, now.Millisecond);
            laptime.Value = String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", tmp.Hours, tmp.Minutes, tmp.Seconds, tmp.Milliseconds);
            DataGridViewRow r = new DataGridViewRow();
            r.Cells.Add(jikoku);
            r.Cells.Add(laptime);
            dataGridView1.Rows.Add(r);
        }
    }
}
