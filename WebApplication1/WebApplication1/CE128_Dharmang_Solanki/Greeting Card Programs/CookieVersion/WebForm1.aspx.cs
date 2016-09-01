using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.CE128_Dharmang_Solanki.Greeting_Card_Programs.CookieVersion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            if (!this.IsPostBack)
            {
                // Set color options.
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                lstBackColor.DataSource = colorArray;
                lstBackColor.DataBind();
                // Set font options.
                foreach (FontFamily family in fonts.Families)
                {
                    lstFontName.Items.Add(family.Name);
                }



            }
        }
        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            HttpCookie Cookie = Request.Cookies["Attributes"];
            if (Cookie == null)
            {
                Cookie = new HttpCookie("Attributes");
            }
            Cookie["back"] = lstBackColor.SelectedItem.Text;
            Cookie["fontn"] = lstFontName.SelectedItem.Text;
            Cookie["fonts"] = txtFontSize.Text;
            Cookie["border"] = lstBorder.SelectedItem.Text;
            Cookie["text"] = txtGreeting.Text;
           
            Cookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(Cookie);
            Response.Redirect("greetingcardpage.aspx");
        }

    }
}
