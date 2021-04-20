using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PizzaPalace
{
    public partial class frmExamResult : Form
    {
        public frmExamResult()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ENGINEERNGENO\\SQLEXPRESS;Initial Catalog=SDRS;Integrated Security=True");
            showGrid();
        }
        // Database variables
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt = new DataTable();
        // Global Variables
        int TotalBilled;
        int rno = 0;
        // Alert function
        public void Alert(string msg, Alert.alertTypeEnum type)
        {
            Alert f = new Alert();
            f.setAlert(msg, type);
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExamResult_Load(object sender, EventArgs e)
        {
            var bunifuDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Controls.Add(bunifuDataGrid);
            cbxForm.Items.Add("1");
            cbxForm.Items.Add("2");
            cbxForm.Items.Add("3");
            cbxForm.Items.Add("4");



        }



        private void dgvViewStudents_Resize(object sender, EventArgs e)
        {

        }

        private void btnSend23_Click(object sender, EventArgs e)
        {
            //frmExamMark exm = new frmExamMark();
            //exm.PushExam();
        }
        // Load data in adapter
        void showGrid()
        {
            try
            {
                adapter = new SqlDataAdapter("select * from tblResult", con);
                adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                adapter.Fill(ds, "Results");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display on Grid 
                    dgvResults.DataSource = ds;
                    dgvResults.DataMember = "Results";
                }
                else
                    dgvResults.Rows.Add("No Existing Records Found");

            }
            catch (Exception ex)
            {
                this.Alert("Could Perform query Operation" + ex.Message, PizzaPalace.Alert.alertTypeEnum.Warning);
            }

        }

        private void btnSearch11_Click(object sender, EventArgs e)
        {

        }

        private void cbxForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("select * from tblResult", con);
                ds = new DataSet();
                adapter.Fill(dt);
                dgvResults.DataSource = dt.Select("Form= " + cbxForm.SelectedItem + "").CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Data Found");
            }
            
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvResults.Width, this.dgvResults.Height);
            dgvResults.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvResults.Width, this.dgvResults.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
        private void btnPrint12_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnDelete11_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show(" ALL STUDENT RESULTS WILL BE CLEARED!! ", "CLEAR ALL RESULTS", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlg == DialogResult.OK)
            {
                try
                {
                    cmd = new SqlCommand("delete from tblResult", con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    con.Close();
                    if (n > 0)
                    {
                        this.Alert("All Student Results Cleared!!", PizzaPalace.Alert.alertTypeEnum.Info);
                    }
                    else
                        this.Alert("Failed to delete Student Results !", PizzaPalace.Alert.alertTypeEnum.Warning);
                }
                catch (Exception ex)
                {
                    this.Alert("Could Perform Deletion Operation!!", PizzaPalace.Alert.alertTypeEnum.Error);
                    con.Close();
                }
            }
        }
    }
}