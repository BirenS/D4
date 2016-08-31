using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.CE128_Dharmang_Solanki.Greeting_Card_Programs.CookieVersion
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie Cookie = Request.Cookies["Attributes"];
            if (Cookie == null)
            {
                Response.Redirect("GreetingCardMaker_version8.aspx");
            }
            else
            {

                pnlCard.BackColor = Color.FromName(Cookie["back"]);

                // Update the font.
                lblGreeting.Font.Name = Cookie["fontn"];
                if (Int32.Parse(Cookie["fonts"]) > 0)
                {
                    lblGreeting.Font.Size =
                    FontUnit.Point(Int32.Parse(Cookie["fonts"]));
                }

                TypeConverter converter =
                TypeDescriptor.GetConverter(typeof(BorderStyle));
              
                pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(
                Cookie["borderstyle"]);
              
             
                // Set the text.
                lblGreeting.Text = Cookie["greetingtext"];


            }
        }
    }
}