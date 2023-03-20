using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace BalanceXpert
{
    //-------------------------------------------------------------------------
    // Class: Main
    // Description: Main form of the application
    // Author: Aarón Flore Pasos
    // Date: 20/03/2023
    //-------------------------------------------------------------------------
    public partial class Main : MaterialForm
    {
        //---------------------------------------------------------------------
        // Attributes
        //---------------------------------------------------------------------
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        //---------------------------------------------------------------------
        // Method: Main
        // Description: Constructor of the class
        //---------------------------------------------------------------------
        public Main()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                               MaterialSkin.Primary.Indigo500,
                               MaterialSkin.Primary.Indigo700,
                               MaterialSkin.Primary.Indigo100,
                               MaterialSkin.Accent.Indigo700,
                               MaterialSkin.TextShade.WHITE);
        }
    }
}
