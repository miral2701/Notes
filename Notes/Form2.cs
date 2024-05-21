using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form2 : MaterialForm
    {

        MaterialListBox b;
        public static int top=0;
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public Form2(MaterialListBox a)
        {
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow300, Primary.Yellow300,
                Primary.Green100, Accent.Lime100, TextShade.BLACK);
            InitializeComponent();
            b = a;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Button c = new Button()
            //{
            //    Text = materialTextBox1.Text,
            //    BackColor = Color.LightYellow,
            //    Width = 600,
            //    Height = 50,
            //    Top = 0,
            //};

            //Panel panel=new Panel() {Top=top,Width=600,};
            //panel.Controls.Add(c);
            //top += 50;
            //panel.Click+= Panel_Click;

            b.AddItem(new MaterialListBoxItem(materialTextBox1.Text));
            b.AddItem(new MaterialListBoxItem("    " + materialTextBox2.Text));
            if (materialTextBox1.Text == "")
            {
                throw new Exception("Empty string");
            }

            this.Close();


        }

        private void Panel_Click(object sender, EventArgs e)
        {
            bool flag=false;
            if(!flag) 
            {
                (sender as Panel).Height+=100;

            }

        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
