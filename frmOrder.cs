using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualBasic;
using System.Linq;
using System.Threading;
namespace PizzaPalace
{
    public partial class frmPayFees : Form
    {
        public frmPayFees()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ENGINEERNGENO\\SQLEXPRESS;Initial Catalog=SDRS;Integrated Security=True");
           loaddata();
           showdata();
        }
        // Database variables
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt= new DataTable();
        DataRow dr;
        // Global Variables
        int rno = 0;
        int cBalance;
        int prepaid;
        int bal;
        int paid;
        public void Alert(string msg, Alert.alertTypeEnum type)
        {
            Alert f = new Alert();
            f.setAlert(msg, type);
        }
        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayFees_Load(object sender, EventArgs e)
        {
            // Initialize Payment Modes
            cbxMode.Items.Add("MPESA");
            cbxMode.Items.Add("Direct Deposit");
            cbxMode.Items.Add("Bank Collection");
        }
        // Load data in adapter
        void loaddata()
        {
            try
            {
          
                    adapter = new SqlDataAdapter("SELECT * FROM tblPayment INNER JOIN tblStudents ON tblStudents.AdmNo=tblPayment.AdmNo ", con);
                    ds = new DataSet(); adapter.Fill(ds, "student");
                    //textBox1.Text = ds.Tables[0].Rows[rno][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
 this.Alert("Could Perform query Operation" + ex.Message, PizzaPalace.Alert.alertTypeEnum.Warning);
            }

        }
        void getCurrentBalance()
        {
            // Search student to pay Fees
            try
            {

                adapter = new SqlDataAdapter("SELECT * FROM tblPayment  WHERE tblPayment.PaymentID= (select MAX(PaymentID) FROM  tblPayment WHERE AdmNo=" + txtAdmNo21.Text + ")", con);
                ds = new DataSet(); adapter.Fill(ds, "student");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cBalance = Convert.ToInt32(ds.Tables[0].Rows[rno][5]);
                }
                // If the student is not found
                else
                    this.Alert("A student with this Admission Number does not Exist!", PizzaPalace.Alert.alertTypeEnum.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Alert("Could Perform query Operation" + ex.Message, PizzaPalace.Alert.alertTypeEnum.Warning);
            }
            
        }
        void showdata()
        {
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // display Payment Details on input controls 
                    txtAdmNo21.Text = ds.Tables[0].Rows[rno][1].ToString();
                    txtBilled21.Text = ds.Tables[0].Rows[rno][2].ToString();
                    txtAmount21.Text = ds.Tables[0].Rows[rno][3].ToString();
                    txtBalance21.Text = "***";
                    txtPrepaid21.Text = "***";
                    cbxMode.Text = ds.Tables[0].Rows[rno][7].ToString();
                    txtName.Text = ds.Tables[0].Rows[rno][9].ToString();
                    txtMobile21.Text = ds.Tables[0].Rows[rno][17].ToString();
                    txtForm.Text = ds.Tables[0].Rows[rno][10].ToString();
                }
                else
                    this.Alert("There are no existing records!", PizzaPalace.Alert.alertTypeEnum.Warning);
            }
            catch (Exception ex)
            {
                this.Alert("Unable to query databse!!", PizzaPalace.Alert.alertTypeEnum.Warning);
            }
        }
        void getStudent()
        {
            getCurrentBalance();
            // Search student to pay Fees
            try
            {

                adapter = new SqlDataAdapter("SELECT * FROM tblPayment INNER JOIN tblStudents ON tblStudents.AdmNo=tblPayment.AdmNo WHERE tblPayment.PaymentID= (select MAX(PaymentID) FROM  tblPayment WHERE AdmNo=" + txtAdmNo21.Text + ")", con);
                ds = new DataSet(); adapter.Fill(ds, "student");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtAdmNo21.Text = ds.Tables[0].Rows[rno][1].ToString();
                    txtBilled21.Text = ds.Tables[0].Rows[rno][2].ToString();
                    txtAmount21.Text = ds.Tables[0].Rows[rno][3].ToString();
                    txtBalance21.Text = cBalance.ToString();
                    txtPrepaid21.Text = ds.Tables[0].Rows[rno][6].ToString();
                    cbxMode.Text = ds.Tables[0].Rows[rno][7].ToString();
                    txtName.Text = ds.Tables[0].Rows[rno][9].ToString();
                    txtMobile21.Text = ds.Tables[0].Rows[rno][17].ToString();
                    txtForm.Text = ds.Tables[0].Rows[rno][10].ToString();
                }
                // If the student is not found
                else
                    this.Alert("A student with this Admission Number does not Exist!", PizzaPalace.Alert.alertTypeEnum.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Alert("Could Perform query Operation" + ex.Message, PizzaPalace.Alert.alertTypeEnum.Warning);
            }
        }
        private void btnSearch21_Click(object sender, EventArgs e)
        {
            getStudent();   
        }

        private void btnSave21_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            // Perform Fees Updation Calculations
            getCurrentBalance();
            paid = Convert.ToInt32(txtAmount21.Text);
            //int Billed = Convert.ToInt32(txtBilled21.Text);
            if (paid > cBalance)
            { 
                prepaid = paid-cBalance;
                cBalance= 0;
            }
            else
            {
                cBalance = cBalance - paid;
                prepaid = 0;
            }
           
            try
            {
                cmd = new SqlCommand("INSERT into tblPayment(AdmNo,TotalAmount,Paid,Date,Balance,Prepayment,PayMode) values(" + txtAdmNo21.Text + "," + txtBilled21.Text + ","+paid+",'" + DateTime.Parse(dpPayDate.Text) + "'," + cBalance+ ","+prepaid+", '"+cbxMode.Text+"')", con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                con.Close();
   this.Alert("Payment processed", PizzaPalace.Alert.alertTypeEnum.Info);
                getStudent();

                // Send SMS to the parent of successful payment
                frmDashb smpf = new frmDashb();
            }
            catch (Exception ex)
            {
                this.Alert("Unable to Bill Current Student!!", PizzaPalace.Alert.alertTypeEnum.Error);
                con.Close();
            }
        }
        public void PullFeesBal(string phone, int adm)
        {

            // Search student to pay Fees
            try
            {

                adapter = new SqlDataAdapter("SELECT  (SELECT Name FROM tblStudents WHERE AdmNo="+adm+") AS Name, (SELECT PhoneNO FROM tblStudents WHERE AdmNo="+adm+") AS number,Balance FROM tblPayment  WHERE PaymentID= (select MAX(PaymentID) FROM  tblPayment WHERE AdmNo = "+adm+")", con);
                ds = new DataSet(); adapter.Fill(ds, "student");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string name = ds.Tables[0].Rows[rno][0].ToString();
                    string pno = ds.Tables[0].Rows[rno][1].ToString();
                    int Bal = Convert.ToInt32(ds.Tables[0].Rows[rno][2]);
                    if (pno == phone)
                    {
                        string s = "Current Fees Balance for " + name + "," + adm + " " + "is KES" + Bal + ".00" + ". Thank you for being part of Singoronik Secondary School. ^BN";
                        frmDashb sms = new frmDashb();
                        
                    }
                    else
                    {
                        frmDashb dsm = new frmDashb();

                    }

                    //  MessageBox.Show(s);
                }
                // If the student is not found
                else
                {
                    frmDashb smsb = new frmDashb();
                }
                    //this.Alert("A student with this Admission Number does not Exist!", SDRS.Alert.alertTypeEnum.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ "Pull Fees Balance");
                this.Alert("Could Perform query Operation" + ex.Message, PizzaPalace.Alert.alertTypeEnum.Warning);
            }
        }
       public void PullFeeState(string phone, int adm)
        {

            try
            {

                adapter = new SqlDataAdapter("SELECT  TOP 5 CONCAT(Date,Paid,PayMode)AS statement,(SELECT PhoneNO FROM tblStudents WHERE AdmNo= "+adm+") AS number  FROM tblPayment WHERE AdmNo= "+adm+" AND PayMode !='NULL' ", con);
                ds = new DataSet();
                adapter.Fill(ds, "States");
                var dt = new DataTable();
                adapter.Fill(dt);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string pno = ds.Tables[0].Rows[rno][1].ToString();
                    if (pno == phone)
                    {
                        string s = "Fee Statement for" + adm + ":  " + string.Join(", | ", dt.Rows.OfType<DataRow>().Select(r => r[0].ToString()));
                        frmDashb smss = new frmDashb();
                       
                    }
                    else
                    {
                        frmDashb dsm = new frmDashb();

                    }
                   
                    
                }
               
                else
                {
                    frmDashb smsf = new frmDashb();

                }
                }
                  

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Pull Fees Statement");

            }
        }
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (rno > 0)
            {
                rno--;
                showdata();
            }
            else
                this.Alert("You have reached the beginning of Payments navigation", PizzaPalace.Alert.alertTypeEnum.Info);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (rno > 0)
            {
                rno--;
                showdata();
            }
            else
                this.Alert("You have reached the beginning of Paymnents navigation",PizzaPalace.Alert.alertTypeEnum.Info);
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if(rno < ds.Tables[0].Rows.Count - 1)
            {
                rno++; showdata();
            }
            else
                this.Alert("End of Payments navigation", PizzaPalace.Alert.alertTypeEnum.Info);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            rno = ds.Tables[0].Rows.Count - 1;
            showdata();
        }
        
        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        
    }
}
