using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BillGenerator : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Initialize dropdown with waffle options
            ddlWaffleType.Items.Add(new ListItem("Chocolate", "2.50"));
            ddlWaffleType.Items.Add(new ListItem("Strawberry", "2.50"));
            ddlWaffleType.Items.Add(new ListItem("Kaya", "2.50"));
        }
    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        // Validate inputs
        if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtQuantity.Text))
        {
            lblResult.Text = "Please enter both customer name and quantity.";
            return;
        }

        // Parse quantity
        if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
        {
            lblResult.Text = "Please enter a valid quantity.";
            return;
        }

        // Calculate total price
        double unitPrice = double.Parse(ddlWaffleType.SelectedValue);
        double totalPrice = unitPrice * quantity;

        // Apply discount if total price is RM7.50 and above
        if (totalPrice >= 7.50)
        {
            totalPrice *= 0.9; // Apply 10% discount
        }

        // Display the result
        lblResult.Text = $"Total Price for {quantity} {ddlWaffleType.SelectedItem.Text} waffles: RM {totalPrice:F2}";
    }
}
