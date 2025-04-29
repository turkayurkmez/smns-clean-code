using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);           
            string message = new ProductService().CreateProduct(name, price);
            MessageBox.Show(message);
        }

       

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }
    }
}
