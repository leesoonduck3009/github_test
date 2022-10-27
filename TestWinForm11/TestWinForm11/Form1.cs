using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForm11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CosumizeDesign();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void CosumizeDesign()
        {
            panelSubmenu1.Visible = false;
            panelSubmenu2.Visible = false;

        }
        private void HideSubMenu()
        {
            if (panelSubmenu1.Visible == true)
                panelSubmenu1.Visible = false;
            if (panelSubmenu2.Visible==true)
                panelSubmenu2.Visible=false;   
        }
        private void DisplaySubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //HideSubMenu();
                
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }    
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            DisplaySubMenu(panelSubmenu1);
        }

     

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMain2_Click(object sender, EventArgs e)
        {
            DisplaySubMenu(panelSubmenu2);
        }
    }
}
