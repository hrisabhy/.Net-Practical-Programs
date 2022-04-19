using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(getNum.Text);
            int n, rev = 0, d;
            n = num;
            while (n > 0)
            {
                d = n % 10;
                n = n / 10;
                rev = rev * 10 + d;

            }
            if (rev == num)
            {
                resultLabel.Text = "Is a palimdrome";
            }
            else
            {
                resultLabel.Text = "not a plalindrome";
            }
        }
    }
}