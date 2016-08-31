using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Greeting_Card_Programs.Multiview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            if (!this.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                // Set color options.
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                lstForeColor.DataSource = colorArray;
                lstForeColor.DataBind();

                string[] colorArray1 = Enum.GetNames(typeof(KnownColor));
                lstBackColor.DataSource = colorArray1;
                lstBackColor.DataBind();
                // Set font options.
                foreach (FontFamily family in fonts.Families)
                {
                    lstFontName.Items.Add(family.Name);
                }

                // Set border style options
                string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
                lstBorder.DataSource = borderStyleArray;
                lstBorder.DataBind();
                // Select the first border option.
                lstBorder.SelectedIndex = 0;
                // Set the picture.
                imgDefault.ImageUrl = "image/default.jpg";
            }

        }

        

        protected void ChangeFore(object sender, EventArgs e)
        {
            pnlCard2.ForeColor = Color.FromName(lstForeColor.SelectedItem.Text);

        }

        protected void ChangeBack(object sender, EventArgs e)
        {
            pnlCard2.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);

        }

        protected void ChangeBorder(object sender, EventArgs e)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard2.BorderStyle = (BorderStyle)converter.ConvertFromString(
            lstBorder.SelectedItem.Text);

        }

        protected void Picture(object sender, EventArgs e)
        {
            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }

        }

        protected void ChangeFont(object sender, EventArgs e)
        {
            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;

        }

        protected void ChangeFontSize(object sender, EventArgs e)
        {

            if (Int32.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(txtFontSize.Text));
            }
        }

        protected void ChangeText(object sender, EventArgs e)
        {
            lblGreeting.Text = txtGreeting.Text;

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View1);
        }

        protected void Button2_Click2(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View2);
        }

        protected void Button3_Click3(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View3);
        }

        
    }
}