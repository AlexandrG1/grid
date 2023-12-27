using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private Users _dataHelper = new Users();

        public Form1()
        {

            InitializeComponent();
            DataLoad();
        }

        private void DataLoad()
        {
            _dataHelper.LoadData();
            GridControl1.DataSource = _dataHelper.DataTableUsers;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();;
            addForm.ShowDialog();

            if (!string.IsNullOrEmpty(addForm.PersoneName) && !string.IsNullOrEmpty(addForm.Address) && addForm.Age > 0)
            {

            DataTable data = (DataTable)GridControl1.DataSource;
            DataRow row = data.NewRow();

            row["name"] = addForm.PersoneName;
            row["address"] = addForm.Address;
            row["age"] = addForm.Age;

            data.Rows.Add(row);
            _dataHelper.Change();
            DataLoad();
            }
            else
            {
                return;
            }
        }


        private void DelBtn_Click(object sender, EventArgs e)
        {
            var result = XtraMessageBox.Show("Do you want to close the <b>form</b>?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, DefaultBoolean.True);

            if (result == DialogResult.Yes)
            {
                GridView1.DeleteRow(GridView1.FocusedRowHandle);
            }
              
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _dataHelper.Change();
        }
    }
}
