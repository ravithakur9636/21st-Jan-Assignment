using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspAssignment2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "select", "Chevrolet", "Jeep", "Mercedes", "BMW", "Bugatti", "Range Rover" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image2.ImageUrl = "~/pics/" + str + ".jpg";
        }

        
        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Chevrolet")
            {
                TextBox1.Text = "Rs 1500000";
            }
            else if (DropDownList1.Text == "Jeep")
            {
                TextBox1.Text = "Rs 1200000";
            }
            else if (DropDownList1.Text == "Mercedes")
            {
                TextBox1.Text = "Rs 5500000";
            }
            else if (DropDownList1.Text == "BMW")
            {
                TextBox1.Text = "Rs 8000000";
            }
            else if (DropDownList1.Text == "Bugatti")
            {
                TextBox1.Text = "Rs 11000000";
            }

            else
            {
                TextBox1.Text = "Rs 3700000";
            }

        }
    }
}