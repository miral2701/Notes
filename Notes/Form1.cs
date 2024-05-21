using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //listBox1.DataSource = _viewModel.Employees;
            //materialListBox2.DataSource = list.;
            //materialListBox2.DataBindings.Add("DataSource",list, "DataSource");
      



            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Yellow300, Primary.Yellow300,
                Primary.Green100, Accent.Lime100, TextShade.BLACK);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2(materialListBox1);
            form2.ShowDialog();
         

          
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            materialListBox1.Items.Remove(materialListBox1.SelectedItem);
            materialListBox1.Items.RemoveAt(materialListBox1.SelectedIndex);

        }

        private void materialListBox1_DoubleClick(object sender, EventArgs e)
        {
                materialListBox1.AddItem(new MaterialListBoxItem("Text"));
                
        }

       
    }
}