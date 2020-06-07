using System;
using System.Windows.Forms;

namespace SadArkanoid
{
    public partial class FormInterface : Form
    {
        private UserControl current = null;
        
        public FormInterface()
        {
            InitializeComponent();
            current = userCtrlMainMenu1;
        }
        
        public void ChangeControl(UserControl newControl) 
        {
            try
            {
                if (newControl == null)
                {
                    throw new ArgumentNullException("newControl");
                }

                if (current != null)
                {
                    Controls.Remove(current);
                }

                Controls.Add(newControl);
                current = newControl;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error.");
            }
        }
    }
}