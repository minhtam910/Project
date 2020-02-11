using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using LinqToExcel;

namespace Project
{
    public partial class Form1 : Form
    {
        String password = @"tUYD[2\-zHy*k6#U";
        String dataSource = @"FVDB1-NEW\FVDB1";
        String connString;
        DbManager dbManager;
        DataSet dsExt;
        DataSet dsDetail;
        string fromDate, toDate;
        string fromTime, toTime;
        
        public Form1()
        {
            connString = "Data Source=" + dataSource + ";Initial Catalog = TelephoneReport; Persist Security Info=True;User ID = telephone; Password=" + password;
            dbManager = new DbManager(connString);
            InitializeComponent();
            changeFormat();
            FillDetailData();
            EmptyTable();
            txtUsername.Text = Environment.UserName;
            fromDate = pickFromDate.Value.ToString("yyyy-MM-dd");
            toDate = pickToDate.Value.ToString("yyyy-MM-dd");
            fromTime = pickFromTime.Value.ToString("HH:mm:ss");
            toTime = pickToTime.Value.ToString("HH:mm:ss");
        }

        void createDetailDataSet(DataSet ds)
        {
            dsDetail = new DataSet1();
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dsDetail.Tables[0].ImportRow(row);
                }
            }
        }

        void changeFormat()
        {
            pickFromTime.Format = DateTimePickerFormat.Time;
            pickToTime.Format = DateTimePickerFormat.Time;
            pickFromDate.Format = DateTimePickerFormat.Short;
            pickToDate.Format = DateTimePickerFormat.Short;
        }

        void FillDetailData()
        {
            string select = "select top 20 * from pabx_calldata_nl_view";
            SqlParameter[] p = { };
            DataSet ds = new DataSet();
            ds = dbManager.selectCommand(select, p);
            dataDetail.ReadOnly = true;
            dataDetail.DataSource = ds.Tables[0];
        }

        void EmptyTable()
        {
            dsExt = new DataSet();
            DataTable dtExt = dsExt.Tables.Add();
            DataColumn colExt = dtExt.Columns.Add("Extension", typeof(string));
            colExt.AllowDBNull = false;
            colExt.Unique = true;
            DataColumn colNot = dtExt.Columns.Add("Note", typeof(String));

            dataExtension.ReadOnly = true;
            dataExtension.DataSource = dsExt.Tables[0];
        }

        private void txtExtension_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataExtension.SelectedRows)
            {
                dataExtension.Rows.RemoveAt(row.Index);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtExtension.Text.Equals(""))
            {
                int numExt;
                try
                {
                    numExt = System.Convert.ToInt32(txtExtension.Text);
                    if (numExt > 999 && numExt < 10000)
                        dsExt.Tables[0].Rows.Add(txtExtension.Text, "");
                    else
                        MessageBox.Show("Invalid Extension!");
                    txtExtension.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Invalid Extension!");
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            if (of.FileName != "")
            {
                String fileName = of.FileName;
                String ext = Path.GetExtension(fileName);
                if (ext.ToLower().Equals(".xls") || ext.ToLower().Equals(".xlsx"))
                {
                    ExcelQueryFactory excel = new ExcelQueryFactory(fileName);
                    var extension = from ex in excel.Worksheet<Extension>("Sheet1") select ex;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Extension");
                    dt.Columns.Add("Note");

                    foreach (var item in extension)
                    {
                        dt.Rows.Add(item.ExtensionID, item.Note);
                    }
                    dt.AcceptChanges();
                    DataTable table = dsExt.Tables[0];
                    dsExt.Tables.Remove(table);
                    dsExt.Tables.Add(dt);
                    dataExtension.DataSource = dsExt.Tables[0];
                }
            }
        }
        bool checkConstraintDateTime(DateTime fromD, DateTime toD, DateTime fromT, DateTime toT)
        {
            if (fromD.Year <= toD.Year && fromD.Month <= toD.Month && fromD.Day <= toD.Day)
            {
                if (fromD.Day < toD.Day)
                    return true;
                else
                    if (fromT.Hour <= toT.Hour && fromT.Minute <= toT.Minute && fromT.Second <= toT.Second)
                    return true;
            }
            return false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String[] extensionArray = new String[dataExtension.Rows.Count -1];
            for (int i = 0; i < dataExtension.Rows.Count-1; i++)
            {
                extensionArray[i] = dataExtension.Rows[i].Cells[0].Value.ToString().Trim();
                
            }
            DataSet ds = GetDetail(extensionArray[0]);
            for (int j = 1; j < extensionArray.Length; j++)
            {
                DataSet dsTemp = GetDetail(extensionArray[j]);
                foreach (DataTable dt in dsTemp.Tables)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ds.Tables[0].ImportRow(row);
                    }
                }
            }
            createDetailDataSet(ds);
            dataDetail.ReadOnly = true;
            dataDetail.DataSource = dsDetail.Tables[0];
            this.dataDetail.Columns["DataID"].Visible = false;
            MessageBox.Show("Success!");
            /*
            if (checkConstraintDateTime(pickFromDate.Value, pickToDate.Value, pickFromTime.Value, pickToTime.Value))
            {
                
            }*/
        }

        DataSet GetDetail(string extension)
        {
            DataSet ds = new DataSet();
            DataTable dtDetail = ds.Tables.Add("ExtensionDetail");
            string select = "";
            SqlParameter p5 = new SqlParameter("@extension", extension);
            SqlParameter p1 = new SqlParameter("@fromDate", fromDate);
            SqlParameter p2 = new SqlParameter("@toDate", toDate);
            SqlParameter p3 = new SqlParameter("@fromTime", fromTime);
            SqlParameter p4 = new SqlParameter("@toTime", toTime);
            SqlParameter[] p = { p1, p2, p3, p4, p5 };
            select = @"if exists (select * from pabx_calldata_nl_view where DialDate = @fromDate union select * from pabx_calldata_nl_view where DialDate = @toDate )
	                            if exists (select * from pabx_calldata_nl_view where DialDate = @fromDate)
                                    if exists (select * from pabx_calldata_nl_view where DialDate = @toDate)
		                                select * from pabx_calldata_nl_view
                                            where DialDate = @fromDate and CAST(DialTime as time) > @fromTime
                                            and Extension = @extension  
		                                union
		                                select * from pabx_calldata_nl_view
		                                    where DialDate > @fromDate and DialDate < @toDate
                                            and Extension = @extension
		                                union
		                                select * from pabx_calldata_nl_view
                                            where DialDate = @toDate and CAST(DialTime as time) < @toTime
                                            and Extension = @extension
	                                else
                                        select * from pabx_calldata_nl_view
                                            where DialDate = @fromDate and CAST(DialTime as time) > @fromTime
                                            and Extension = @extension  
		                                union
		                                select * from pabx_calldata_nl_view
		                                    where DialDate > @fromDate and DialDate < @toDate
                                            and Extension = @extension
                                else
                                    select * from pabx_calldata_nl_view
		                                    where DialDate > @fromDate and DialDate < @toDate
                                            and Extension = @extension
		                                union
		                                select * from pabx_calldata_nl_view
                                            where DialDate = @toDate and CAST(DialTime as time) < @toTime
                                            and Extension = @extension
                        else
		                   select * from pabx_calldata_nl_view
		                       where DialDate > @fromDate and DialDate < @toDate
                               and Extension = @extension
                           ";
            DataSet dsTemp = new DataSet();
            if (checkConstraintDateTime(pickFromDate.Value, pickToDate.Value, pickFromTime.Value, pickToTime.Value))
            {

                dsTemp = dbManager.selectCommand(select, p);
                /*foreach (DataRow row in dsTemp.Tables[0].Rows)
                {
                    ds.Tables["ExtensionDetail"].ImportRow(row);
                }*/
            }
            return dsTemp;
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            EmptyTable();
        }

        private void pickToDate_ValueChanged(object sender, EventArgs e)
        {
            toDate = pickToDate.Value.ToString("yyyy-MM-dd");
        }

        private void pickToTime_ValueChanged(object sender, EventArgs e)
        {
            toTime = pickToTime.Value.ToString("HH:mm:ss");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(dsDetail);
            this.Hide();
            f2.ShowDialog();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            
        }

        private void myDataSet_Initialized(object sender, EventArgs e)
        {

        }

        private void pickFromDate_ValueChanged(object sender, EventArgs e)
        {
            fromDate = pickFromDate.Value.ToString("yyyy-MM-dd");
        }
        private void pickFromTime_ValueChanged(object sender, EventArgs e)
        {
            fromTime = pickFromTime.Value.ToString("HH:mm:ss");
        }

        private void dataExtension_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataExtension.SelectedRows)
            {
                //extension = row.Cells[0].Value.ToString();
                //note = row.Cells[1].Value.ToString();
            }
        }
    }
}
