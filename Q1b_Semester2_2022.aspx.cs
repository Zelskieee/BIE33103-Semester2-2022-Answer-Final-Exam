using System;

namespace DiamondGenerator
{
    public partial class DiamondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Diamond_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Num_Rows.Text, out int numRows))
            {
                if (numRows % 2 != 0)
                {
                    // Display diamond only for odd number of rows
                    GenerateDiamond(numRows);
                }
                else
                {
                    Result.Text = "Please enter an odd number of rows.";
                }
            }
            else
            {
                Result.Text = "Invalid input. Please enter a valid number of rows.";
            }
        }

        private void GenerateDiamond(int numRows)
        {
            Result.Text = ""; // Clear any previous result

            int spaces = numRows / 2;

            // Upper half of the diamond
            for (int i = 1; i <= numRows; i += 2)
            {
                Result.Text += new string(' ', spaces) + new string('*', i) + "<br/>";
                spaces--;
            }

            // Lower half of the diamond
            spaces = 1;
            for (int i = numRows - 2; i >= 1; i -= 2)
            {
                Result.Text += new string(' ', spaces) + new string('*', i) + "<br/>";
                spaces++;
            }
        }
    }
}
