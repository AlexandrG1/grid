using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestWinForms
{
    public class Users
    {
        private string _dbConnect = "Server=localhost;Database=EmployeeDB;Trusted_Connection=True;";

        private SqlDataAdapter _sqlDataAdapter;

        private SqlConnection _sqlConnection;

        private SqlCommandBuilder _sqlCommandBuilder;

        private DataSet _dataSet;

        public DataTable DataTableUsers { get; set; }


        public void Change()
        {
            _sqlConnection.Open();
            _sqlDataAdapter.Update(_dataSet);
            _sqlConnection.Close();
        }

        public void LoadData()
        {
            DataTableUsers = new DataTable();

            try
            {
                _sqlConnection = new SqlConnection(_dbConnect);
                _sqlConnection.Open();

                var sql = "SELECT * FROM EmployeTable";

                _sqlDataAdapter = new SqlDataAdapter(sql, _sqlConnection);
                _sqlCommandBuilder = new SqlCommandBuilder(_sqlDataAdapter);

                _dataSet = new DataSet();
                _sqlDataAdapter.Fill(_dataSet);

                DataTableUsers = _dataSet.Tables[0];

                _sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
