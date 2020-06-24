using System;
using System.Drawing;
using System.Windows.Forms;
using SadArkanoid.Controladores;

namespace SadArkanoid
{
    public partial class FormInterface : Form
    {
        //userControl actual
        private UserControl current = null;
        
        public FormInterface()
        {
            InitializeComponent();
            current = userCtrlMainMenu1;
            DoubleBuffered = true;
        }
        
        private void FormInterface_Load(object sender, EventArgs e)
        {
            try
            {
                string fontName = "Zorque";
                float fontSize = 10;
                using (Font fontTester = new Font(fontName, fontSize))
                {
                    if (fontTester.Name != "Zorque")
                        throw new MissingFontException(fontName + " font not installed.");
                }
            }
            catch (MissingFontException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       /*
        * Método: void ChangeControl(UserControl newControl)
        *
        * Función: cambiar el userControl actual
        *
        * Descripción: Quita el userControl que se está mostrando actualmente
        * en el panel principal y muestra una nueva instancia
        * 'newControl' de uno de los UserControls
        * disponibles (UserCtrlMainMenu, UserCtrlUser o UserCtrlTopTen). 
        */
        public void ChangeControl(UserControl newControl) 
        {
            try
            {
                if (newControl == null)
                {
                    throw new NullUserControlException("Requested UserControl could not be loaded.");
                }

                if (current != null)
                {
                    mainPanel.Controls.Remove(current);
                }

                current = newControl;
                mainPanel.Controls.Add(current);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}