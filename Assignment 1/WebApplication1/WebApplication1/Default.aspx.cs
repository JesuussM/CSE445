using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnConvertC_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client prxy = new ServiceReference1.Service1Client();
            String c = txtInputC.Text;
            Int32 x = prxy.c2f(Convert.ToInt32(c));
            lblResultC.Text = Convert.ToString(x);
        }

        protected void btnConvertF_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client prxy = new ServiceReference1.Service1Client();
            String f = txtInputF.Text;
            Int32 x = prxy.f2c(Convert.ToInt32(f));
            lblResultF.Text = Convert.ToString(x);
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client prxy = new ServiceReference1.Service1Client();
            String c = txtInputS.Text;
            lblResultS.Text = prxy.sort(c);
        }
    }
}