using System;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtInput.Text, out int n))
        {
            // Check if n is non-negative
            if (n < 0)
            {
                lblResult.Text = "Please enter a non-negative integer.";
            }
            else
            {
                // Calculate Fibonacci and display the result
                long result = CalculateFibonacci(n);
                lblResult.Text = $"The {n}th Fibonacci element is: {result}";
            }
        }
        else
        {
            lblResult.Text = "Please enter a valid integer.";
        }
    }

    private long CalculateFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }
}
