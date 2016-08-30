using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;
namespace WebApplication1.CE_138_Varun_shah
{
    public partial class V4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            if (!this.IsPostBack)
            {
                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                lstForeColor.DataSource = colorArray;
                lstForeColor.DataBind();
                 
                string[] colorArray1 = Enum.GetNames(typeof(KnownColor));
                lstBackColor.DataSource = colorArray1;
                lstBackColor.DataBind();
                 
                foreach (FontFamily family in fonts.Families)
                {
                    lstFontName.Items.Add(family.Name);
                }

                 
                string[] borderStyleArray = Enum.GetNames(typeof(BorderStyle));
                lstBorder.DataSource = borderStyleArray;
                lstBorder.DataBind();
                 
                lstBorder.SelectedIndex = 0;
                 
                imgDefault.ImageUrl = "default.jpg";
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);

            pnlCard.ForeColor = Color.FromName(lstForeColor.SelectedItem.Text);
             
            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
            if (Int32.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(Int32.Parse(txtFontSize.Text));
            }  
             
            TypeConverter converter =
            TypeDescriptor.GetConverter(typeof(BorderStyle));
             
            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(
            lstBorder.SelectedItem.Text);
             
            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }
             
            lblGreeting.Text = txtGreeting.Text;
        }

    }
}