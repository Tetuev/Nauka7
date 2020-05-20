using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Nauka7
{
    public partial class Form3 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =  Table.mdb";
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void табельBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.табельBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tableDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tableDataSet.Табель". При необходимости она может быть перемещена или удалена.
            this.табельTableAdapter.Fill(this.tableDataSet.Табель);

        }
    }
}
