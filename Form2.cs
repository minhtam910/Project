using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        DataSet ds; 
        public Form2(DataSet ds)
        {
            this.ds = ds;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.DataTable1BindingSource.DataSource = ds;
            this.reportViewer1.RefreshReport();
        }
    }
}
