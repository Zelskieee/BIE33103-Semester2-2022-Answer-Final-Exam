using System;
using System.Threading;

namespace Q3a_
{
    public partial class Thread2 : System.Web.UI.Page
    {
        bool stopped = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            Thread thr1 = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Response.Write("Running...");
                    Thread.Sleep(1000);
                }
            }));

            Thread thr2 = new Thread(ProcThread2);
            thr1.Start();
            thr2.Start();
            thr2.IsBackground = true;

            thr1.Join();
        }

        public void ProcThread2()
        {
            Response.Write("I am number 1");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            stopped = true;
            Response.Write("stop");
        }
    }
}
