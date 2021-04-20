namespace PizzaPalace
{
    partial class frmExamResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamResult));
            this.btnClose5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete11 = new Guna.UI.WinForms.GunaButton();
            this.cbxForm = new Guna.UI.WinForms.GunaComboBox();
            this.btnSend23 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPrint12 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.dgvResults = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose5
            // 
            this.btnClose5.FlatAppearance.BorderSize = 0;
            this.btnClose5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose5.ForeColor = System.Drawing.Color.White;
            this.btnClose5.Location = new System.Drawing.Point(3, 12);
            this.btnClose5.Name = "btnClose5";
            this.btnClose5.Size = new System.Drawing.Size(25, 25);
            this.btnClose5.TabIndex = 14;
            this.btnClose5.Text = "X";
            this.btnClose5.UseVisualStyleBackColor = true;
            this.btnClose5.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClose5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 47);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(201, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "|  Examination Results  |";
            // 
            // btnDelete11
            // 
            this.btnDelete11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete11.AnimationHoverSpeed = 0.07F;
            this.btnDelete11.AnimationSpeed = 0.03F;
            this.btnDelete11.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete11.BaseColor = System.Drawing.Color.Red;
            this.btnDelete11.BorderColor = System.Drawing.Color.Black;
            this.btnDelete11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete11.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete11.ForeColor = System.Drawing.Color.White;
            this.btnDelete11.Image = global::PizzaPalace.Properties.Resources.replace_24px;
            this.btnDelete11.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete11.Location = new System.Drawing.Point(517, 81);
            this.btnDelete11.Name = "btnDelete11";
            this.btnDelete11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete11.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete11.OnHoverImage = null;
            this.btnDelete11.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete11.Radius = 4;
            this.btnDelete11.Size = new System.Drawing.Size(99, 42);
            this.btnDelete11.TabIndex = 27;
            this.btnDelete11.Text = "Clear ALL";
            this.btnDelete11.Click += new System.EventHandler(this.btnDelete11_Click);
            // 
            // cbxForm
            // 
            this.cbxForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxForm.BackColor = System.Drawing.Color.Transparent;
            this.cbxForm.BaseColor = System.Drawing.Color.White;
            this.cbxForm.BorderColor = System.Drawing.Color.Silver;
            this.cbxForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxForm.FocusedColor = System.Drawing.Color.Empty;
            this.cbxForm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxForm.ForeColor = System.Drawing.Color.Black;
            this.cbxForm.FormattingEnabled = true;
            this.cbxForm.Location = new System.Drawing.Point(74, 48);
            this.cbxForm.Name = "cbxForm";
            this.cbxForm.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxForm.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxForm.Size = new System.Drawing.Size(114, 26);
            this.cbxForm.TabIndex = 25;
            this.cbxForm.SelectedIndexChanged += new System.EventHandler(this.cbxForm_SelectedIndexChanged);
            // 
            // btnSend23
            // 
            this.btnSend23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend23.AnimationHoverSpeed = 0.07F;
            this.btnSend23.AnimationSpeed = 0.03F;
            this.btnSend23.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.btnSend23.BaseColor2 = System.Drawing.Color.Yellow;
            this.btnSend23.BorderColor = System.Drawing.Color.Black;
            this.btnSend23.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend23.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend23.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend23.ForeColor = System.Drawing.Color.White;
            this.btnSend23.Image = global::PizzaPalace.Properties.Resources.email_send_24px;
            this.btnSend23.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend23.Location = new System.Drawing.Point(517, 6);
            this.btnSend23.Name = "btnSend23";
            this.btnSend23.OnHoverBaseColor1 = System.Drawing.Color.Yellow;
            this.btnSend23.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.btnSend23.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend23.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend23.OnHoverImage = null;
            this.btnSend23.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend23.Size = new System.Drawing.Size(99, 42);
            this.btnSend23.TabIndex = 24;
            this.btnSend23.Text = "Publish";
            this.btnSend23.Click += new System.EventHandler(this.btnSend23_Click);
            // 
            // btnPrint12
            // 
            this.btnPrint12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrint12.AnimationHoverSpeed = 0.07F;
            this.btnPrint12.AnimationSpeed = 0.03F;
            this.btnPrint12.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPrint12.BaseColor2 = System.Drawing.Color.Violet;
            this.btnPrint12.BorderColor = System.Drawing.Color.Black;
            this.btnPrint12.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint12.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint12.ForeColor = System.Drawing.Color.White;
            this.btnPrint12.Image = global::PizzaPalace.Properties.Resources.print_24px;
            this.btnPrint12.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint12.Location = new System.Drawing.Point(328, 32);
            this.btnPrint12.Name = "btnPrint12";
            this.btnPrint12.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnPrint12.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnPrint12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint12.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint12.OnHoverImage = null;
            this.btnPrint12.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint12.Size = new System.Drawing.Size(99, 42);
            this.btnPrint12.TabIndex = 21;
            this.btnPrint12.Text = "Print";
            this.btnPrint12.Click += new System.EventHandler(this.btnPrint12_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(30, 53);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Form:";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.cbxForm);
            this.gunaPanel1.Controls.Add(this.btnDelete11);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.btnSend23);
            this.gunaPanel1.Controls.Add(this.btnPrint12);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 47);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(684, 126);
            this.gunaPanel1.TabIndex = 28;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvResults.DoubleBuffered = true;
            this.dgvResults.EnableHeadersVisualStyles = false;
            this.dgvResults.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResults.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.dgvResults.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResults.Location = new System.Drawing.Point(0, 196);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResults.RowTemplate.DividerHeight = 1;
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(684, 235);
            this.dgvResults.TabIndex = 35;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(91, 17);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(70, 17);
            this.gunaLabel2.TabIndex = 28;
            this.gunaLabel2.Text = "Filter Grid";
            // 
            // frmExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExamResult";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmExamResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton btnPrint12;
        private Guna.UI.WinForms.GunaGradientButton btnSend23;
        private Guna.UI.WinForms.GunaComboBox cbxForm;
        private Guna.UI.WinForms.GunaButton btnDelete11;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvResults;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}