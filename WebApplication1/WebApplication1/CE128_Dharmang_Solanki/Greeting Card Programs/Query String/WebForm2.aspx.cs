using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;

namespace WebApplication1.Greeting_Card_Programs.Query_String
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string str1, str2, str3, str4, str5, str6;
        protected void Page_Load(object sender, EventArgs e)
        {
            str1 = Request.QueryString["val1"].ToString();

            str2 = Request.QueryString["val2"].ToString();

            str3 = Request.QueryString["val3"].ToString();

            str4 = Request.QueryString["val4"].ToString();

            str5 = Request.QueryString["val5"].ToString();
            str6 = Request.QueryString["val6"].ToString();
            pnlCard.BackColor = Color.FromName(str1);
            imgDefault.ImageUrl = "image/default.jpg";
            // Update the font.
            lblGreeting.Font.Name = str2;
            if (Int32.Parse(str4) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(str4));
            }
            // Update the border style. This requires two conversion steps.
            // First, the value of the list item is converted from a string
            // into an integer. Next, the integer is converted to a value in
            // the BorderStyle enumeration.
            // Find the appropriate TypeConverter for the BorderStyle enumeration.
            TypeConverter converter =
            TypeDescriptor.GetConverter(typeof(BorderStyle));
            // Update the border style using the value from the converter.
            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(
            str3);
            // Update the picture.
            if (str6 == "True")
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }
            // Set the text.
            lblGreeting.Text = str5;
        }
    }
}