using System;
using System.Web.UI;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblMessage.Text = "Welcome to ASP.NET 4 Web Forms!";
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        lblResult.Text = "Hello, " + name + "!";
    }
}