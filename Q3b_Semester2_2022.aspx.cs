using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Spot_Question_DotNet
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitForm_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string Gender = gender.SelectedItem.Value;
            string Email = email.Text;
            string PhoneNumber = phoneNumber.Text;

            SqlConnection con = new SqlConnection
                ("Data Source = LAPTOP-BM8BRT21\\SQLEXPRESS; Initial Catalog = TestDatabase; Integrated Security = True; Pooling = False");

            try
            {
                con.Open();

                // Use parameterized query to prevent SQL injection
                SqlCommand cmd = new SqlCommand("INSERT INTO contactus (name, gender, email, phone_no) VALUES (@name, @gender, @email, @phoneNumber)", con);

                // Add parameters
                cmd.Parameters.Add("@name", SqlDbType.VarChar, 30).Value = Name;
                cmd.Parameters.Add("@gender", SqlDbType.TinyInt).Value = Convert.ToByte(Gender); // Assuming gender is a TinyInt (1 byte) in the database
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = Email;
                cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 15).Value = PhoneNumber;

                // Execute the SQL command
                cmd.ExecuteNonQuery();

                Response.Write("User data inserted successfully");
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
            finally
            {
                con.Close();

                // Clear input fields
                name.Text = string.Empty;
                gender.ClearSelection();
                email.Text = string.Empty;
                phoneNumber.Text = string.Empty;
            }
        }
    }
}