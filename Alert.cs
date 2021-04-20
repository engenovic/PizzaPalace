using PizzaPalace.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaPalace
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        public enum alertTypeEnum
        {
            Success,
            Warning,
            Error,
            Info
        }

        private int x, y;
        public void setAlert(string msg, Alert.alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alert f = (Alert)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case Alert.alertTypeEnum.Success:
                    this.GunaPictureBox1.Image = Resources.Checkmark_28px;
                    this.BackColor = Color.FromArgb(0, 192, 90);
                    
                    break;
                case Alert.alertTypeEnum.Warning:
                    this.GunaPictureBox1.Image = Resources.Warning_28px;
                    this.BackColor = Color.FromArgb(255, 121, 70);
                    break;
                case Alert.alertTypeEnum.Error:
                    this.GunaPictureBox1.Image = Resources.Error_28px;
                    this.BackColor = Color.FromArgb(255, 30, 30);
                    break;
                case Alert.alertTypeEnum.Info:
                    this.GunaPictureBox1.Image = Resources.Info_28px;
                    this.BackColor = Color.FromArgb(71, 169, 248);
                    break;
            }
            this.GunaLabel1.Text = msg;

            //this.TopMost = false;
            //this.ShowIcon = false;
            //this.ShowInTaskbar = false;

            this.Show();
            this.action = actionEnum.start;
            this.Timer1.Interval = 1;
            this.Timer1.Start();


        }

        public enum actionEnum
        {
            wait,
            start,
            close
        }

        private Alert.actionEnum action;

       
        private void GunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Timer1.Interval = 1;
            this.action = Alert.actionEnum.close;
        }

        private void Alert_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Alert.actionEnum.wait:
                    this.Timer1.Interval = 5000;
                    this.action = Alert.actionEnum.close;
                    break;
                case Alert.actionEnum.start:
                    this.Timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = Alert.actionEnum.wait;
                        }
                    }
                    break;
                case Alert.actionEnum.close:
                    this.Timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

    }
}
