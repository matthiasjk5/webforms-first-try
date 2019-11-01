using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webforms_first_try
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string roomName;
        int area;
        int cost;
        int totalCost;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox2.Text = 0.ToString();
                TextBox3.Text = 0.ToString();
                TextBox4.Text = 0.ToString();
                TextBox5.Text = 0.ToString();
            }
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox4.Text = (int.Parse(TextBox2.Text) * int.Parse(TextBox3.Text)).ToString();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox4.Text = (int.Parse(TextBox2.Text) * int.Parse(TextBox3.Text)).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            roomName = TextBox1.Text;
            area = int.Parse(TextBox4.Text);
            cost = int.Parse(TextBox5.Text);
            totalCost = area * cost;

            int rooms = int.Parse(WebConfigurationManager.AppSettings["start"]);
            if (rooms < int.Parse(WebConfigurationManager.AppSettings["maxroom"]))
            {
                //TextArea1.Value = "Room Name: " + roomName;
                //TextArea1.Value += " Cost: " + totalCost + "\n";
                TextArea1.Value = TextArea1.Value + "\n " + "Room Name: " + TextBox1.Text + " Room Area: " + TextBox4.Text + " Cost of Room: " + (int.Parse(TextBox4.Text) * int.Parse(TextBox5.Text));
                WebConfigurationManager.AppSettings["start"] = (rooms + 1).ToString();
            } else
            {
                Response.Write("<script>alert('You annot add more rooms');</script>");
            }


        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}