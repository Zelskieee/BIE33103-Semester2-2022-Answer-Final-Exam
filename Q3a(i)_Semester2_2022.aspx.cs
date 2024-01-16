using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spot_Question_DotNet
{
    public partial class Q3a_i__Semester2_2022 : System.Web.UI.Page
    {
        public void Proc_Thread()
        {
            for (int i = 0; i <= 6; i++)
            {
                if (i % 2 == 0)
                {
                    Response.Write("This is even = " + i + "</br>");
                }
                else
                {
                    Response.Write("This is odd </br>");
                }
                Thread.Sleep(1000);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Thread thr1 = new Thread(Proc_Thread);
            thr1.Start();
            Response.Write("Start the count</br>");
            for (int a = 1; a < 5; a++)
            {
                Response.Write("Going On</br>");
            }
            thr1.Join();
        }
    }
}