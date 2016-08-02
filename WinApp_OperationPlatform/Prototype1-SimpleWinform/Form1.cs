using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype1_SimpleWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateDataGridView();
        }

        private void CreateDataGridView()
        {
            DBHandler db = new DBHandler();
            dataGridView1.DataSource = db.GetDt();
        }
    }
}
