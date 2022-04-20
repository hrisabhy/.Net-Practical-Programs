using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac13
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(TextBox1.Text);
            int num2 = Int32.Parse(TextBox2.Text);

            Prac13.WebService1 obj1 = new Prac13.WebService1();
            int sum = obj1.add(num1, num2);
            resullLabel.Text = sum.ToString();
        }

        protected void MultiplyButton_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(TextBox1.Text);
            int num2 = Int32.Parse(TextBox2.Text);
            Prac13.WebService1 obj1 = new Prac13.WebService1();
            int multiply = obj1.multiply(num1, num2);
            resullLabel.Text = multiply.ToString();
        }
    }
}