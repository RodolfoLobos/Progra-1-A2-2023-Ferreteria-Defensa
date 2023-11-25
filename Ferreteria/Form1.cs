using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void customizar()
        {
            panelAgregarSubmenu.Visible = false;
            PanelSubmenuModificar.Visible = false;
        }

        private void esconderSubMenu()
        {
            if (panelAgregarSubmenu.Visible == true)
                panelAgregarSubmenu.Visible= false;
            if (PanelSubmenuModificar.Visible ==true)
                PanelSubmenuModificar.Visible= false;
        }
        private void SubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible= true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SubMenu(panelAgregarSubmenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
