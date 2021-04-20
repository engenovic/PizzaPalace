using PizzaPalace.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.ComponentModel;
// Developed By Engineer Ngeno | Brivic @2020
// Final Year Project 
// Meru University of Science & Technology
//******** Supervised by Dr. Chege Amos Kirongo **** DPt. Computer Science 
namespace PizzaPalace
{
    public partial class frmDashb : Form
    {
        public frmDashb()
        { 
            InitializeComponent();
            hideSubMenu();
            con = new SqlConnection("Data Source=ENGINEERNGENO\\SQLEXPRESS;Initial Catalog=SDRS;Integrated Security=True");

        }
       
        // Database variables
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        DataSet ds;
        DataRow row;
        int rno;
        // SMS Variables 
        string a;
        string b;
        string c;
        string d;
        string ee;
        string f;
        public void Alert(string msg, Alert.alertTypeEnum type)
        {
            Alert f = new Alert();
            f.setAlert(msg, type);
        }
        
        int counter;
        private void frmDashb_Load(object sender, EventArgs e)
        {

            
        }
        // Hide Menu Function
        private void hideSubMenu()
        {
            panelStudentSub.Visible = false;
            panelExamSub.Visible = false;
            panelFeesSub.Visible = false;
            panelToolsSub.Visible = false;
        }
        
        // Display Menu According to Logged in User
        public  void UpdateExam(bool ex)
        {
            btnStudents.Enabled = false;
            btnFees.Enabled = false;
            btnTools.Enabled = false;
            btnMessage.Enabled = false;
            gunaCirclePictureBox1.Image = Resources.Brigit_Chelangat;
        }
        public void UpdateFees(bool fe)
        {
            btnStudents.Enabled = false;
            btnExams.Enabled = false;
            btnTools.Enabled = false;
            btnMessage.Enabled = false;
           gunaCirclePictureBox1.Image= Resources.Brigit_Chelangat1;
        }
        public string labelUser
        {
            get{
                return this.label4.Text;
            }
            set
            {
                this.label4.Text = value;
            }
        }
        public string labelRole
        {
            get
            {
                return this.label2.Text;
            }
            set
            {
                this.label2.Text = value;
            }
        }
        
        // Show Menu Function
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        // Open SubMenus 
        private void btnStudents_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSub);
        }

        

        private void btnExams_Click(object sender, EventArgs e)
        {
            showSubMenu(panelExamSub);
        }
        private void btnFees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFeesSub);
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmSMSSend());
            //
            //Other Code
            //
            hideSubMenu();
        }

        private void btnTools_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSub);
        }
        #region ToolsSubMenu
        
        #endregion

        // Check current active form and set run-time properties 
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Open Child Forms 
        // Add Student Form
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmAddStudent());
            //
            //Other Code
            //
            hideSubMenu();
        }
        // View Students form
        private void btnViewStudents_Click(object sender, EventArgs e)
        {
           // openChildForm(new frmViewStudents());
            //
            //Other Code
            //
            hideSubMenu();
        }
        // Edit Exam Info Formss
        private void btnExamInfo_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmExamInfo());
            //
            //Other Code
            //
            hideSubMenu();
        }

        private void btnExamMark_Click(object sender, EventArgs e)
        {
           // openChildForm(new frmExamMark());
            //
            //Other Code
            //
            hideSubMenu();
        }

        private void btnExamResult_Click(object sender, EventArgs e)
        {
           // openChildForm(new frmExamResult());
            //
            //Other Code
            //
            hideSubMenu();
        }
        private void btnFeeBill_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmFeeBill());
            //
            //Other Code
            //
            hideSubMenu();
            //..
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmInfo());
            //
            //Other Code
            //
            hideSubMenu();
            //..
        }
        private void btnPayFees_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmPayFees());
            //..
            //your codes
            //..
            hideSubMenu();
        }

       

        
        private void btnUsers_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmUsers());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnViewPayment_Click(object sender, EventArgs e)
        {
            //openChildForm(new frmViewPayments());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
          //  frmLogin login= new frmLogin();
           // login.Show();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(panelSideMenu.Width==250 & panelSideMenu.Height==661)
            {
                panelSideMenu.Width = 48;
                panelSideMenu.Height =661;
                btnStudents.Visible = false;
                btnExams.Visible = false;
                btnFees.Visible = false;
                btnMessage.Visible = false;
                btnTools.Visible = false;
                btnExit.Visible = false;
            }
            else
            {
                panelSideMenu.Width = 250;
                panelSideMenu.Height = 661;
                btnStudents.Visible = true;
                btnExams.Visible = true;
                btnFees.Visible = true;
                btnMessage.Visible = true;
                btnTools.Visible = true;
                btnExit.Visible = true;
            }
        }

        
        
        
       
        
      

       

        bool IsRegistered(string pno)
        {
            
            try
            {
                // Getting New Messages from Inbox table 
                adapter = new SqlDataAdapter("SELECT* FROM tblStudents WHERE PhoneNo= '" + pno + "'", con);
                ds = new DataSet();
                adapter.Fill(ds, "Parents");
                adapter.Fill(dt);

                int rs = ds.Tables[0].Rows.Count;

                if (rs > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
          // Controls.Add(bw);
           // bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerAsync();
        }


        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
        
        bw.CancelAsync();
            

        }

      
    }
    }
