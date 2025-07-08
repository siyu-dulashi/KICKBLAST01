using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KICKBLAST01
{
    //  OOP: Abstraction
    public abstract class NavigationHandler
    {
        // Abstract method for navigation
        public abstract void Navigate(Form currentForm, Form targetForm);
    }

    //  OOP: Inheritance
    public class FormNavigator : NavigationHandler
    {
        // Override abstract method
        public override void Navigate(Form currentForm, Form targetForm)
        {
            targetForm.Show();
            currentForm.Hide();
        }
    }

}
