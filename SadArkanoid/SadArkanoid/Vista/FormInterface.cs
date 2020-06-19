using System;
using System.Drawing.Text;
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
            DoubleBuffered = true;
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
                    panel1.Controls.Remove(current);
                }

                current = newControl;
                panel1.Controls.Add(current);
                
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error.");
            }
        }
    }
}