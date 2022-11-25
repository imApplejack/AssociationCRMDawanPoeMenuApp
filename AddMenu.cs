using AssociationCRMDawanPoe.Entity;
using AssociationCRMDawanPoe.Persistance.Menu_DAO;
using AssociationCRMDawanPoe.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsMenu
{
    public partial class AddMenu : Form
    {
        Menu Menu;
        IMenuService _menuService;
        public AddMenu(IMenuService service, Menu? menu = null)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _menuService = service;

            if (menu is null)
            {
                Menu = new();
            }
            else
            {
                Menu = menu;
                textBoxName.Text = Menu.Name.ToString();

                foreach (var produits in menu.products)
                {
                    listBoxMenu.Items.Add(produits.Name);
                }


                buttonAdd.Text = "Modifier";

            }
            Product p = new();
            foreach (var category in Enum.GetValues(typeof(ProductCategory)))
            {
                comboBox1.Items.Add(category);
            }
            
           
            Menu = new();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals("Plat"))
            {
                
            }
        }
    }
}
