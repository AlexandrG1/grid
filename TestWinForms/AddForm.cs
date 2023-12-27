using System;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class AddForm : Form
    {
        public string PersoneName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void Add2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Age = Convert.ToInt32(AgeTxt.Text);
                PersoneName = NameTxt.Text;
                Address = AddressTxt.Text;
                Close();
            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
