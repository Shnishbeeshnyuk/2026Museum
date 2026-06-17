namespace _2026Museum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageHalls = new TabPage();
            btnAddHall = new Button();
            btnUpdateHall = new Button();
            btnDeleteHall = new Button();
            txtHallTheme = new TextBox();
            txtHallName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPageExhibits = new TabPage();
            numericHallID = new NumericUpDown();
            txtExhibitType = new TextBox();
            txtExhibitName = new TextBox();
            txtUniqueNumber = new TextBox();
            btnAddExhibit = new Button();
            btnUpdateExhibit = new Button();
            btnDeleteExhibit = new Button();
            dataGridView2 = new DataGridView();
            tabPageVisitors = new TabPage();
            dtpBirthDate = new DateTimePicker();
            txtVisitorPhone = new TextBox();
            txtVisitorName = new TextBox();
            btnAddVisitor = new Button();
            btnUpdateVisitor = new Button();
            btnDeleteVisitor = new Button();
            dataGridView3 = new DataGridView();
            tabPageEmployees = new TabPage();
            txtEmployeePhone = new TextBox();
            txtEmployeePosition = new TextBox();
            txtEmployeeName = new TextBox();
            btnAddEmployee = new Button();
            btnUpdateEmployee = new Button();
            btnDeleteEmployee = new Button();
            dataGridView4 = new DataGridView();
            tabPageTickets = new TabPage();
            numericVisitorID = new NumericUpDown();
            numericTicketPrice = new NumericUpDown();
            cbTicketType = new ComboBox();
            btnAddTicket = new Button();
            btnDeleteTicket = new Button();
            dataGridView5 = new DataGridView();
            tabPageExcursions = new TabPage();
            btnUpdateExcursion = new Button();
            btnAddExcursion = new Button();
            dtpExcursionDate = new DateTimePicker();
            txtExcursionName = new TextBox();
            numericGuideID = new NumericUpDown();
            numericMaxParticipants = new NumericUpDown();
            btnDeleteExcursion = new Button();
            dataGridView6 = new DataGridView();
            btnRefresh = new Button();
            tabControl1.SuspendLayout();
            tabPageHalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageExhibits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericHallID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPageVisitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPageTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericVisitorID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTicketPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabPageExcursions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericGuideID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMaxParticipants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageHalls);
            tabControl1.Controls.Add(tabPageExhibits);
            tabControl1.Controls.Add(tabPageVisitors);
            tabControl1.Controls.Add(tabPageEmployees);
            tabControl1.Controls.Add(tabPageTickets);
            tabControl1.Controls.Add(tabPageExcursions);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(844, 638);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageHalls
            // 
            tabPageHalls.Controls.Add(btnAddHall);
            tabPageHalls.Controls.Add(btnUpdateHall);
            tabPageHalls.Controls.Add(btnDeleteHall);
            tabPageHalls.Controls.Add(txtHallTheme);
            tabPageHalls.Controls.Add(txtHallName);
            tabPageHalls.Controls.Add(label2);
            tabPageHalls.Controls.Add(label1);
            tabPageHalls.Controls.Add(dataGridView1);
            tabPageHalls.Location = new Point(4, 29);
            tabPageHalls.Name = "tabPageHalls";
            tabPageHalls.Padding = new Padding(3);
            tabPageHalls.Size = new Size(836, 605);
            tabPageHalls.TabIndex = 0;
            tabPageHalls.Text = "\"Залы\"";
            tabPageHalls.UseVisualStyleBackColor = true;
            // 
            // btnAddHall
            // 
            btnAddHall.Location = new Point(536, 570);
            btnAddHall.Name = "btnAddHall";
            btnAddHall.Size = new Size(94, 29);
            btnAddHall.TabIndex = 14;
            btnAddHall.Text = "Добавить";
            btnAddHall.UseVisualStyleBackColor = true;
            // 
            // btnUpdateHall
            // 
            btnUpdateHall.Location = new Point(636, 570);
            btnUpdateHall.Name = "btnUpdateHall";
            btnUpdateHall.Size = new Size(94, 29);
            btnUpdateHall.TabIndex = 13;
            btnUpdateHall.Text = "Обновить";
            btnUpdateHall.UseVisualStyleBackColor = true;
            // 
            // btnDeleteHall
            // 
            btnDeleteHall.Location = new Point(736, 570);
            btnDeleteHall.Name = "btnDeleteHall";
            btnDeleteHall.Size = new Size(94, 29);
            btnDeleteHall.TabIndex = 12;
            btnDeleteHall.Text = "Delete";
            btnDeleteHall.UseVisualStyleBackColor = true;
            // 
            // txtHallTheme
            // 
            txtHallTheme.Location = new Point(131, 556);
            txtHallTheme.Name = "txtHallTheme";
            txtHallTheme.Size = new Size(125, 27);
            txtHallTheme.TabIndex = 11;
            // 
            // txtHallName
            // 
            txtHallName.Location = new Point(131, 338);
            txtHallName.Name = "txtHallName";
            txtHallName.Size = new Size(125, 27);
            txtHallName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 563);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 9;
            label2.Text = "Тематика";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 338);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 8;
            label1.Text = "Навзание зала";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(836, 310);
            dataGridView1.TabIndex = 0;
            // 
            // tabPageExhibits
            // 
            tabPageExhibits.Controls.Add(numericHallID);
            tabPageExhibits.Controls.Add(txtExhibitType);
            tabPageExhibits.Controls.Add(txtExhibitName);
            tabPageExhibits.Controls.Add(txtUniqueNumber);
            tabPageExhibits.Controls.Add(btnAddExhibit);
            tabPageExhibits.Controls.Add(btnUpdateExhibit);
            tabPageExhibits.Controls.Add(btnDeleteExhibit);
            tabPageExhibits.Controls.Add(dataGridView2);
            tabPageExhibits.Location = new Point(4, 29);
            tabPageExhibits.Name = "tabPageExhibits";
            tabPageExhibits.Padding = new Padding(3);
            tabPageExhibits.Size = new Size(836, 605);
            tabPageExhibits.TabIndex = 1;
            tabPageExhibits.Text = "\"Экспонаты\"";
            tabPageExhibits.UseVisualStyleBackColor = true;
            // 
            // numericHallID
            // 
            numericHallID.Location = new Point(6, 502);
            numericHallID.Name = "numericHallID";
            numericHallID.Size = new Size(150, 27);
            numericHallID.TabIndex = 22;
            // 
            // txtExhibitType
            // 
            txtExhibitType.Location = new Point(6, 446);
            txtExhibitType.Name = "txtExhibitType";
            txtExhibitType.Size = new Size(125, 27);
            txtExhibitType.TabIndex = 21;
            // 
            // txtExhibitName
            // 
            txtExhibitName.Location = new Point(6, 382);
            txtExhibitName.Name = "txtExhibitName";
            txtExhibitName.Size = new Size(125, 27);
            txtExhibitName.TabIndex = 20;
            // 
            // txtUniqueNumber
            // 
            txtUniqueNumber.Location = new Point(6, 319);
            txtUniqueNumber.Name = "txtUniqueNumber";
            txtUniqueNumber.Size = new Size(125, 27);
            txtUniqueNumber.TabIndex = 18;
            // 
            // btnAddExhibit
            // 
            btnAddExhibit.Location = new Point(534, 570);
            btnAddExhibit.Name = "btnAddExhibit";
            btnAddExhibit.Size = new Size(94, 29);
            btnAddExhibit.TabIndex = 17;
            btnAddExhibit.Text = "Добавить";
            btnAddExhibit.UseVisualStyleBackColor = true;
            // 
            // btnUpdateExhibit
            // 
            btnUpdateExhibit.Location = new Point(634, 570);
            btnUpdateExhibit.Name = "btnUpdateExhibit";
            btnUpdateExhibit.Size = new Size(94, 29);
            btnUpdateExhibit.TabIndex = 16;
            btnUpdateExhibit.Text = "Обновить";
            btnUpdateExhibit.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExhibit
            // 
            btnDeleteExhibit.Location = new Point(734, 570);
            btnDeleteExhibit.Name = "btnDeleteExhibit";
            btnDeleteExhibit.Size = new Size(94, 29);
            btnDeleteExhibit.TabIndex = 15;
            btnDeleteExhibit.Text = "Delete";
            btnDeleteExhibit.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(836, 313);
            dataGridView2.TabIndex = 0;
            // 
            // tabPageVisitors
            // 
            tabPageVisitors.Controls.Add(dtpBirthDate);
            tabPageVisitors.Controls.Add(txtVisitorPhone);
            tabPageVisitors.Controls.Add(txtVisitorName);
            tabPageVisitors.Controls.Add(btnAddVisitor);
            tabPageVisitors.Controls.Add(btnUpdateVisitor);
            tabPageVisitors.Controls.Add(btnDeleteVisitor);
            tabPageVisitors.Controls.Add(dataGridView3);
            tabPageVisitors.Location = new Point(4, 29);
            tabPageVisitors.Name = "tabPageVisitors";
            tabPageVisitors.Padding = new Padding(3);
            tabPageVisitors.Size = new Size(836, 605);
            tabPageVisitors.TabIndex = 2;
            tabPageVisitors.Text = "\"Посетители\"";
            tabPageVisitors.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(6, 376);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(250, 27);
            dtpBirthDate.TabIndex = 25;
            // 
            // txtVisitorPhone
            // 
            txtVisitorPhone.Location = new Point(6, 440);
            txtVisitorPhone.Name = "txtVisitorPhone";
            txtVisitorPhone.Size = new Size(125, 27);
            txtVisitorPhone.TabIndex = 24;
            // 
            // txtVisitorName
            // 
            txtVisitorName.Location = new Point(6, 313);
            txtVisitorName.Name = "txtVisitorName";
            txtVisitorName.Size = new Size(125, 27);
            txtVisitorName.TabIndex = 22;
            // 
            // btnAddVisitor
            // 
            btnAddVisitor.Location = new Point(536, 570);
            btnAddVisitor.Name = "btnAddVisitor";
            btnAddVisitor.Size = new Size(94, 29);
            btnAddVisitor.TabIndex = 17;
            btnAddVisitor.Text = "Добавить";
            btnAddVisitor.UseVisualStyleBackColor = true;
            // 
            // btnUpdateVisitor
            // 
            btnUpdateVisitor.Location = new Point(636, 570);
            btnUpdateVisitor.Name = "btnUpdateVisitor";
            btnUpdateVisitor.Size = new Size(94, 29);
            btnUpdateVisitor.TabIndex = 16;
            btnUpdateVisitor.Text = "Обновить";
            btnUpdateVisitor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteVisitor
            // 
            btnDeleteVisitor.Location = new Point(736, 570);
            btnDeleteVisitor.Name = "btnDeleteVisitor";
            btnDeleteVisitor.Size = new Size(94, 29);
            btnDeleteVisitor.TabIndex = 15;
            btnDeleteVisitor.Text = "Delete";
            btnDeleteVisitor.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(836, 307);
            dataGridView3.TabIndex = 0;
            // 
            // tabPageEmployees
            // 
            tabPageEmployees.Controls.Add(txtEmployeePhone);
            tabPageEmployees.Controls.Add(txtEmployeePosition);
            tabPageEmployees.Controls.Add(txtEmployeeName);
            tabPageEmployees.Controls.Add(btnAddEmployee);
            tabPageEmployees.Controls.Add(btnUpdateEmployee);
            tabPageEmployees.Controls.Add(btnDeleteEmployee);
            tabPageEmployees.Controls.Add(dataGridView4);
            tabPageEmployees.Location = new Point(4, 29);
            tabPageEmployees.Name = "tabPageEmployees";
            tabPageEmployees.Padding = new Padding(3);
            tabPageEmployees.Size = new Size(836, 605);
            tabPageEmployees.TabIndex = 3;
            tabPageEmployees.Text = "\"Сотрудники\"";
            tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // txtEmployeePhone
            // 
            txtEmployeePhone.Location = new Point(6, 448);
            txtEmployeePhone.Name = "txtEmployeePhone";
            txtEmployeePhone.Size = new Size(125, 27);
            txtEmployeePhone.TabIndex = 27;
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Location = new Point(6, 384);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(125, 27);
            txtEmployeePosition.TabIndex = 26;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(6, 321);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(125, 27);
            txtEmployeeName.TabIndex = 25;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(534, 570);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(94, 29);
            btnAddEmployee.TabIndex = 17;
            btnAddEmployee.Text = "Добавить";
            btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Location = new Point(634, 570);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(94, 29);
            btnUpdateEmployee.TabIndex = 16;
            btnUpdateEmployee.Text = "Обновить";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(734, 570);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(94, 29);
            btnDeleteEmployee.TabIndex = 15;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(836, 315);
            dataGridView4.TabIndex = 0;
            // 
            // tabPageTickets
            // 
            tabPageTickets.Controls.Add(numericVisitorID);
            tabPageTickets.Controls.Add(numericTicketPrice);
            tabPageTickets.Controls.Add(cbTicketType);
            tabPageTickets.Controls.Add(btnAddTicket);
            tabPageTickets.Controls.Add(btnDeleteTicket);
            tabPageTickets.Controls.Add(dataGridView5);
            tabPageTickets.Location = new Point(4, 29);
            tabPageTickets.Name = "tabPageTickets";
            tabPageTickets.Padding = new Padding(3);
            tabPageTickets.Size = new Size(836, 605);
            tabPageTickets.TabIndex = 4;
            tabPageTickets.Text = "\"Билеты\"";
            tabPageTickets.UseVisualStyleBackColor = true;
            // 
            // numericVisitorID
            // 
            numericVisitorID.Location = new Point(7, 446);
            numericVisitorID.Name = "numericVisitorID";
            numericVisitorID.Size = new Size(150, 27);
            numericVisitorID.TabIndex = 20;
            // 
            // numericTicketPrice
            // 
            numericTicketPrice.Location = new Point(7, 373);
            numericTicketPrice.Name = "numericTicketPrice";
            numericTicketPrice.Size = new Size(150, 27);
            numericTicketPrice.TabIndex = 19;
            // 
            // cbTicketType
            // 
            cbTicketType.FormattingEnabled = true;
            cbTicketType.Items.AddRange(new object[] { "Взрослый", "Детский", "Свободный", "Экскурсия" });
            cbTicketType.Location = new Point(6, 311);
            cbTicketType.Name = "cbTicketType";
            cbTicketType.Size = new Size(151, 28);
            cbTicketType.TabIndex = 18;
            // 
            // btnAddTicket
            // 
            btnAddTicket.Location = new Point(536, 570);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(94, 29);
            btnAddTicket.TabIndex = 17;
            btnAddTicket.Text = "Добавить";
            btnAddTicket.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Location = new Point(736, 570);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(94, 29);
            btnDeleteTicket.TabIndex = 15;
            btnDeleteTicket.Text = "Delete";
            btnDeleteTicket.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(0, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(836, 305);
            dataGridView5.TabIndex = 0;
            // 
            // tabPageExcursions
            // 
            tabPageExcursions.Controls.Add(btnUpdateExcursion);
            tabPageExcursions.Controls.Add(btnAddExcursion);
            tabPageExcursions.Controls.Add(dtpExcursionDate);
            tabPageExcursions.Controls.Add(txtExcursionName);
            tabPageExcursions.Controls.Add(numericGuideID);
            tabPageExcursions.Controls.Add(numericMaxParticipants);
            tabPageExcursions.Controls.Add(btnDeleteExcursion);
            tabPageExcursions.Controls.Add(dataGridView6);
            tabPageExcursions.Location = new Point(4, 29);
            tabPageExcursions.Name = "tabPageExcursions";
            tabPageExcursions.Padding = new Padding(3);
            tabPageExcursions.Size = new Size(836, 605);
            tabPageExcursions.TabIndex = 5;
            tabPageExcursions.Text = "\"Экскурсии\"";
            tabPageExcursions.UseVisualStyleBackColor = true;
            // 
            // btnUpdateExcursion
            // 
            btnUpdateExcursion.Location = new Point(636, 570);
            btnUpdateExcursion.Name = "btnUpdateExcursion";
            btnUpdateExcursion.Size = new Size(94, 29);
            btnUpdateExcursion.TabIndex = 23;
            btnUpdateExcursion.Text = "Обновить";
            btnUpdateExcursion.UseVisualStyleBackColor = true;
            // 
            // btnAddExcursion
            // 
            btnAddExcursion.Location = new Point(536, 570);
            btnAddExcursion.Name = "btnAddExcursion";
            btnAddExcursion.Size = new Size(94, 29);
            btnAddExcursion.TabIndex = 22;
            btnAddExcursion.Text = "Добавить";
            btnAddExcursion.UseVisualStyleBackColor = true;
            // 
            // dtpExcursionDate
            // 
            dtpExcursionDate.Location = new Point(3, 347);
            dtpExcursionDate.Name = "dtpExcursionDate";
            dtpExcursionDate.Size = new Size(250, 27);
            dtpExcursionDate.TabIndex = 21;
            // 
            // txtExcursionName
            // 
            txtExcursionName.Location = new Point(3, 314);
            txtExcursionName.Name = "txtExcursionName";
            txtExcursionName.Size = new Size(125, 27);
            txtExcursionName.TabIndex = 20;
            // 
            // numericGuideID
            // 
            numericGuideID.Location = new Point(6, 413);
            numericGuideID.Name = "numericGuideID";
            numericGuideID.Size = new Size(150, 27);
            numericGuideID.TabIndex = 19;
            // 
            // numericMaxParticipants
            // 
            numericMaxParticipants.Location = new Point(6, 380);
            numericMaxParticipants.Name = "numericMaxParticipants";
            numericMaxParticipants.Size = new Size(150, 27);
            numericMaxParticipants.TabIndex = 18;
            // 
            // btnDeleteExcursion
            // 
            btnDeleteExcursion.Location = new Point(736, 570);
            btnDeleteExcursion.Name = "btnDeleteExcursion";
            btnDeleteExcursion.Size = new Size(94, 29);
            btnDeleteExcursion.TabIndex = 15;
            btnDeleteExcursion.Text = "Delete";
            btnDeleteExcursion.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(0, 0);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(836, 308);
            dataGridView6.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(713, 667);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(151, 47);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Обновить всё";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 726);
            Controls.Add(btnRefresh);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPageHalls.ResumeLayout(false);
            tabPageHalls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageExhibits.ResumeLayout(false);
            tabPageExhibits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericHallID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPageVisitors.ResumeLayout(false);
            tabPageVisitors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPageEmployees.ResumeLayout(false);
            tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPageTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericVisitorID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTicketPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabPageExcursions.ResumeLayout(false);
            tabPageExcursions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericGuideID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMaxParticipants).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageHalls;
        private DataGridView dataGridView1;
        private TabPage tabPageExhibits;
        private DataGridView dataGridView2;
        private TabPage tabPageVisitors;
        private DataGridView dataGridView3;
        private TabPage tabPageEmployees;
        private DataGridView dataGridView4;
        private TabPage tabPageTickets;
        private DataGridView dataGridView5;
        private TabPage tabPageExcursions;
        private DataGridView dataGridView6;
        private Button btnAddHall;
        private Button btnUpdateHall;
        private Button btnDeleteHall;
        private TextBox txtHallTheme;
        private TextBox txtHallName;
        private Label label2;
        private Label label1;
        private Button btnAddExhibit;
        private Button btnUpdateExhibit;
        private Button btnDeleteExhibit;
        private Button btnAddVisitor;
        private Button btnUpdateVisitor;
        private Button btnDeleteVisitor;
        private Button btnAddEmployee;
        private Button btnUpdateEmployee;
        private Button btnDeleteEmployee;
        private Button btnAddTicket;
        private Button button11;
        private Button btnDeleteTicket;
        private Button button13;
        private Button button14;
        private Button btnDeleteExcursion;
        private TextBox txtExhibitType;
        private TextBox txtExhibitName;
        private TextBox txtUniqueNumber;
        private TextBox txtVisitorPhone;
        private TextBox txtVisitorName;
        private TextBox txtEmployeePhone;
        private TextBox txtEmployeePosition;
        private TextBox txtEmployeeName;
        private NumericUpDown numericHallID;
        private DateTimePicker dtpBirthDate;
        private NumericUpDown numericVisitorID;
        private NumericUpDown numericTicketPrice;
        private ComboBox cbTicketType;
        private DateTimePicker dtpExcursionDate;
        private TextBox txtExcursionName;
        private NumericUpDown numericGuideID;
        private NumericUpDown numericMaxParticipants;
        private Button btnRefresh;
        private Button btnUpdateExcursion;
        private Button btnAddExcursion;
    }
}
