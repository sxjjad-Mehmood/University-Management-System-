namespace universitymangementsystem
{
    partial class professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(professor));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label21 = new Label();
            DepId = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            PfQual = new ComboBox();
            label16 = new Label();
            DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            PfDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            panel2 = new Panel();
            label14 = new Label();
            label15 = new Label();
            PfSal = new TextBox();
            PfGen = new ComboBox();
            label13 = new Label();
            Dep = new TextBox();
            label12 = new Label();
            label11 = new Label();
            PfAdd = new TextBox();
            label10 = new Label();
            PfName = new TextBox();
            panel12 = new Panel();
            label20 = new Label();
            label19 = new Label();
            label9 = new Label();
            pictureBox10 = new PictureBox();
            label8 = new Label();
            pictureBox9 = new PictureBox();
            label7 = new Label();
            pictureBox8 = new PictureBox();
            label5 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label22 = new Label();
            PfExp = new TextBox();
            panel1 = new Panel();
            SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            PfDGv = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PfDGv).BeginInit();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(427, 163);
            label21.Name = "label21";
            label21.Size = new Size(65, 18);
            label21.TabIndex = 164;
            label21.Text = "Dept Id";
            // 
            // DepId
            // 
            DepId.FormattingEnabled = true;
            DepId.Location = new Point(442, 184);
            DepId.Name = "DepId";
            DepId.Size = new Size(103, 33);
            DepId.TabIndex = 163;
            DepId.SelectionChangeCommitted += DepId_SelectionChangeCommitted;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(600, 165);
            label18.Name = "label18";
            label18.Size = new Size(59, 18);
            label18.TabIndex = 162;
            label18.Text = "Salary";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(230, 156);
            label17.Name = "label17";
            label17.Size = new Size(103, 18);
            label17.TabIndex = 161;
            label17.Text = "Department";
            // 
            // PfQual
            // 
            PfQual.FormattingEnabled = true;
            PfQual.Items.AddRange(new object[] { "Masters", "PHD" });
            PfQual.Location = new Point(981, 122);
            PfQual.Name = "PfQual";
            PfQual.Size = new Size(103, 33);
            PfQual.TabIndex = 160;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(423, 82);
            label16.Name = "label16";
            label16.Size = new Size(45, 18);
            label16.TabIndex = 159;
            label16.Text = "DOB";
            // 
            // DeleteBtn
            // 
            DeleteBtn.ActiveBorderThickness = 1;
            DeleteBtn.ActiveCornerRadius = 20;
            DeleteBtn.ActiveFillColor = Color.Red;
            DeleteBtn.ActiveForecolor = Color.White;
            DeleteBtn.ActiveLineColor = Color.Red;
            DeleteBtn.BackColor = Color.White;
            DeleteBtn.BackgroundImage = (Image)resources.GetObject("DeleteBtn.BackgroundImage");
            DeleteBtn.ButtonText = "Delete";
            DeleteBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.SeaGreen;
            DeleteBtn.IdleBorderThickness = 1;
            DeleteBtn.IdleCornerRadius = 20;
            DeleteBtn.IdleFillColor = Color.White;
            DeleteBtn.IdleForecolor = Color.Red;
            DeleteBtn.IdleLineColor = Color.Red;
            DeleteBtn.Location = new Point(870, 268);
            DeleteBtn.Margin = new Padding(4, 4, 4, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(168, 40);
            DeleteBtn.TabIndex = 158;
            DeleteBtn.TextAlign = ContentAlignment.MiddleCenter;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // PfDOB
            // 
            PfDOB.Checked = true;
            PfDOB.CustomizableEdges = customizableEdges1;
            PfDOB.FillColor = Color.Red;
            PfDOB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PfDOB.Format = DateTimePickerFormat.Long;
            PfDOB.Location = new Point(423, 118);
            PfDOB.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            PfDOB.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            PfDOB.Name = "PfDOB";
            PfDOB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PfDOB.Size = new Size(284, 35);
            PfDOB.TabIndex = 155;
            PfDOB.Value = new DateTime(2023, 12, 23, 11, 42, 28, 468);
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(241, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 3);
            panel2.TabIndex = 154;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(722, 86);
            label14.Name = "label14";
            label14.Size = new Size(68, 18);
            label14.TabIndex = 153;
            label14.Text = "Gender";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(697, 86);
            label15.Name = "label15";
            label15.Size = new Size(0, 18);
            label15.TabIndex = 152;
            // 
            // PfSal
            // 
            PfSal.Location = new Point(590, 186);
            PfSal.Name = "PfSal";
            PfSal.Size = new Size(150, 31);
            PfSal.TabIndex = 151;
            // 
            // PfGen
            // 
            PfGen.FormattingEnabled = true;
            PfGen.Items.AddRange(new object[] { "Male", "Female" });
            PfGen.Location = new Point(722, 120);
            PfGen.Name = "PfGen";
            PfGen.Size = new Size(103, 33);
            PfGen.TabIndex = 150;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(981, 86);
            label13.Name = "label13";
            label13.Size = new Size(108, 18);
            label13.TabIndex = 149;
            label13.Text = "Qualification";
            // 
            // Dep
            // 
            Dep.Location = new Point(230, 186);
            Dep.Name = "Dep";
            Dep.Size = new Size(187, 31);
            Dep.TabIndex = 148;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(831, 86);
            label12.Name = "label12";
            label12.Size = new Size(75, 18);
            label12.TabIndex = 147;
            label12.Text = "Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(850, 82);
            label11.Name = "label11";
            label11.Size = new Size(0, 18);
            label11.TabIndex = 146;
            // 
            // PfAdd
            // 
            PfAdd.Location = new Point(831, 120);
            PfAdd.Multiline = true;
            PfAdd.Name = "PfAdd";
            PfAdd.Size = new Size(144, 112);
            PfAdd.TabIndex = 145;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(230, 86);
            label10.Name = "label10";
            label10.Size = new Size(145, 18);
            label10.TabIndex = 144;
            label10.Text = "Professsor Name";
            // 
            // PfName
            // 
            PfName.Location = new Point(230, 122);
            PfName.Name = "PfName";
            PfName.Size = new Size(187, 31);
            PfName.TabIndex = 143;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Control;
            panel12.Location = new Point(81, 320);
            panel12.Name = "panel12";
            panel12.Size = new Size(111, 3);
            panel12.TabIndex = 142;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(192, 192, 0);
            label20.Location = new Point(423, -3);
            label20.Name = "label20";
            label20.Size = new Size(375, 32);
            label20.TabIndex = 141;
            label20.Text = "University Management System";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Italic, GraphicsUnit.Point);
            label19.ForeColor = Color.Transparent;
            label19.Location = new Point(442, -6);
            label19.Name = "label19";
            label19.Size = new Size(248, 18);
            label19.TabIndex = 140;
            label19.Text = "University Mangement System";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.SlateGray;
            label9.Location = new Point(90, 561);
            label9.Name = "label9";
            label9.Size = new Size(77, 18);
            label9.TabIndex = 139;
            label9.Text = "Colleges";
            label9.Click += label9_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(29, 541);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(48, 50);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 138;
            pictureBox10.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.SlateGray;
            label8.Location = new Point(81, 629);
            label8.Name = "label8";
            label8.Size = new Size(64, 18);
            label8.TabIndex = 137;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(27, 612);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(48, 50);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 136;
            pictureBox9.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(81, 496);
            label7.Name = "label7";
            label7.Size = new Size(59, 18);
            label7.TabIndex = 135;
            label7.Text = "Salary";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(27, 478);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(48, 50);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 134;
            pictureBox8.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.SlateGray;
            label5.Location = new Point(81, 433);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 133;
            label5.Text = "Fees";
            label5.Click += label5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(27, 415);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 132;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.SlateGray;
            label6.Location = new Point(81, 362);
            label6.Name = "label6";
            label6.Size = new Size(75, 18);
            label6.TabIndex = 131;
            label6.Text = "Courses";
            label6.Click += label6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(27, 345);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(48, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 130;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(81, 299);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 129;
            label4.Text = "Professor";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(27, 281);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 128;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(81, 234);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 127;
            label3.Text = "Department";
            label3.Click += label3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(27, 217);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 126;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(81, 176);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 125;
            label2.Text = "Student";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(27, 153);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 124;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SlateGray;
            label1.Location = new Point(81, 109);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 123;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 122;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(991, 171);
            label22.Name = "label22";
            label22.Size = new Size(98, 18);
            label22.TabIndex = 167;
            label22.Text = "Experience";
            // 
            // PfExp
            // 
            PfExp.Location = new Point(991, 201);
            PfExp.Name = "PfExp";
            PfExp.Size = new Size(105, 31);
            PfExp.TabIndex = 166;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(217, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 738);
            panel1.TabIndex = 169;
            // 
            // SaveBtn
            // 
            SaveBtn.ActiveBorderThickness = 1;
            SaveBtn.ActiveCornerRadius = 20;
            SaveBtn.ActiveFillColor = Color.Red;
            SaveBtn.ActiveForecolor = Color.White;
            SaveBtn.ActiveLineColor = Color.Red;
            SaveBtn.BackColor = Color.White;
            SaveBtn.BackgroundImage = (Image)resources.GetObject("SaveBtn.BackgroundImage");
            SaveBtn.ButtonText = "Save";
            SaveBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.SeaGreen;
            SaveBtn.IdleBorderThickness = 1;
            SaveBtn.IdleCornerRadius = 20;
            SaveBtn.IdleFillColor = Color.White;
            SaveBtn.IdleForecolor = Color.Red;
            SaveBtn.IdleLineColor = Color.Red;
            SaveBtn.Location = new Point(377, 268);
            SaveBtn.Margin = new Padding(4, 4, 4, 4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(168, 40);
            SaveBtn.TabIndex = 170;
            SaveBtn.TextAlign = ContentAlignment.MiddleCenter;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.ActiveBorderThickness = 1;
            EditBtn.ActiveCornerRadius = 20;
            EditBtn.ActiveFillColor = Color.Red;
            EditBtn.ActiveForecolor = Color.White;
            EditBtn.ActiveLineColor = Color.Red;
            EditBtn.BackColor = Color.White;
            EditBtn.BackgroundImage = (Image)resources.GetObject("EditBtn.BackgroundImage");
            EditBtn.ButtonText = "Edit";
            EditBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.SeaGreen;
            EditBtn.IdleBorderThickness = 1;
            EditBtn.IdleCornerRadius = 20;
            EditBtn.IdleFillColor = Color.White;
            EditBtn.IdleForecolor = Color.Red;
            EditBtn.IdleLineColor = Color.Red;
            EditBtn.Location = new Point(619, 268);
            EditBtn.Margin = new Padding(4, 4, 4, 4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(168, 40);
            EditBtn.TabIndex = 171;
            EditBtn.TextAlign = ContentAlignment.MiddleCenter;
            EditBtn.Click += EditBtn_Click;
            // 
            // PfDGv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            PfDGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PfDGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PfDGv.ColumnHeadersHeight = 35;
            PfDGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PfDGv.DefaultCellStyle = dataGridViewCellStyle3;
            PfDGv.GridColor = Color.Red;
            PfDGv.Location = new Point(241, 345);
            PfDGv.Name = "PfDGv";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Red;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            PfDGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            PfDGv.RowHeadersVisible = false;
            PfDGv.RowHeadersWidth = 62;
            PfDGv.RowTemplate.Height = 33;
            PfDGv.Size = new Size(913, 362);
            PfDGv.TabIndex = 172;
            PfDGv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            PfDGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            PfDGv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            PfDGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            PfDGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            PfDGv.ThemeStyle.BackColor = Color.White;
            PfDGv.ThemeStyle.GridColor = Color.Red;
            PfDGv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            PfDGv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            PfDGv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PfDGv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            PfDGv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PfDGv.ThemeStyle.HeaderStyle.Height = 35;
            PfDGv.ThemeStyle.ReadOnly = false;
            PfDGv.ThemeStyle.RowsStyle.BackColor = Color.White;
            PfDGv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PfDGv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PfDGv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            PfDGv.ThemeStyle.RowsStyle.Height = 33;
            PfDGv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            PfDGv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            PfDGv.CellContentClick += PfDGv_CellContentClick;
            // 
            // professor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1203, 742);
            Controls.Add(PfDGv);
            Controls.Add(EditBtn);
            Controls.Add(SaveBtn);
            Controls.Add(panel1);
            Controls.Add(label22);
            Controls.Add(PfExp);
            Controls.Add(label21);
            Controls.Add(DepId);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(PfQual);
            Controls.Add(label16);
            Controls.Add(DeleteBtn);
            Controls.Add(PfDOB);
            Controls.Add(panel2);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(PfSal);
            Controls.Add(PfGen);
            Controls.Add(label13);
            Controls.Add(Dep);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(PfAdd);
            Controls.Add(label10);
            Controls.Add(PfName);
            Controls.Add(panel12);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label9);
            Controls.Add(pictureBox10);
            Controls.Add(label8);
            Controls.Add(pictureBox9);
            Controls.Add(label7);
            Controls.Add(pictureBox8);
            Controls.Add(label5);
            Controls.Add(pictureBox6);
            Controls.Add(label6);
            Controls.Add(pictureBox7);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "professor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "professor";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PfDGv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label21;
        private ComboBox DepId;
        private Label label18;
        private Label label17;
        private ComboBox PfQual;
        private Label label16;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker PfDOB;
        private Panel panel2;
        private Label label14;
        private Label label15;
        private TextBox PfSal;
        private ComboBox PfGen;
        private Label label13;
        private TextBox Dep;
        private Label label12;
        private Label label11;
        private TextBox PfAdd;
        private Label label10;
        private TextBox PfName;
        private Panel panel12;
        private Label label20;
        private Label label19;
        private Label label9;
        private PictureBox pictureBox10;
        private Label label8;
        private PictureBox pictureBox9;
        private Label label7;
        private PictureBox pictureBox8;
        private Label label5;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox7;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label22;
        private TextBox PfExp;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Guna.UI2.WinForms.Guna2DataGridView PfDGv;
    }
}