using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ProfileService.ServiceSoapClient client = new ProfileService.ServiceSoapClient();
        ProfileService.Profile profile = new ProfileService.Profile();
        profile.Name = txtName.Text;
        profile.Email = txtEmail.Text;
        profile.PhoneNo = txtPhoneNo.Text;
        profile.Message = txtMessage.Text;
        clearControls();
        lblMessage.Text = client.UpdateProfileInformation(profile);
    }

    private void clearControls()
    {
        txtName.Text = string.Empty;
        txtEmail.Text = string.Empty;
        txtPhoneNo.Text = string.Empty;
        txtMessage.Text = string.Empty;
    }
}