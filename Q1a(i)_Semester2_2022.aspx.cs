using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Spot_Question_DotNet
{
    public partial class Q1a_i__Semester2_2022 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGenerate_Click(object sender, EventArgs e)
        {
                if (int.TryParse(txtNumberOfElements.Text, out int numberOfElements))
                {
                    lblResult.Text = GenerateFibonacciSequence(numberOfElements);
                }
                else
                {
                    lblResult.Text = "Please enter a valid number.";
                }
        }

        private string GenerateFibonacciSequence(int n)
        {
                int a = 0, b = 1;
                string result = $"{a}, {b}";

                for (int i = 2; i < n; i++)
                {
                    int temp = a + b;
                    result += $", {temp}";
                    a = b;
                    b = temp;
                }

                return result;
        }
    }
}
