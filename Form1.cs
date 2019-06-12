using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal GetResultCount(CancellationToken cancellation)
        {
            decimal iResult = 0;
            while (iResult < 10000000000)
            {
                if (cancellation.IsCancellationRequested)
                    return iResult;

                iResult++;
            }

            return iResult;
        }

        private CancellationTokenSource cancellationTokenSource;

        private void BtnCount_Click(object sender, EventArgs e)
        {
            decimal test = 0;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            this.txtArea.AppendText("App Start : " + watch.Elapsed.Seconds);

            //using async and await => user experience, UI not blocked
            //test = await CountLongTask();
            cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.Token.Register(() => { this.txtException.Text = "I canclled"; });

            var result =  Task.Run(() =>
                {
                    test = GetResultCount(cancellationTokenSource.Token);
                    return test;
                });
            //If use cancle token option while continuedwith, The process will be stop immediately.
            //using continuedWith it mean the current task will be excuted in seperate thread.
            var testCompleted = result.ContinueWith(t =>
            {
                if (this.txtCountResult.InvokeRequired)
                {
                    this.txtCountResult.Invoke(new Action(() =>
                       {
                           this.txtCountResult.Text = t.Result.ToString();
                           this.txtArea.AppendText("\n Counting completed" + watch.Elapsed.Seconds);
                       }));
                }

            },
            //cancleToken
            TaskContinuationOptions.OnlyOnRanToCompletion);

            watch.Stop();

            this.txtArea.AppendText("\n Application done :" + watch.Elapsed.Seconds);
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource = null;
            }
        }
    }
}
