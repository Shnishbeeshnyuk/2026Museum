using _2026MUSEUM;
using System;
using System.Data;
using System.Windows.Forms;

namespace _2026Museum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHalls();
        }

        // ============================================================
        //  ЗАЛЫ
        // ============================================================
        private void LoadHalls()
        {
            dataGridView1.DataSource = DatabaseHelper.GetHalls();
            dataGridView1.Columns["HallID"].HeaderText = "ID";
            dataGridView1.Columns["HallName"].HeaderText = "Название зала";
            dataGridView1.Columns["Theme"].HeaderText = "Тематика";
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            string name = txtHallName.Text.Trim();
            string theme = txtHallTheme.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(theme))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            DatabaseHelper.AddHall(name, theme);
            MessageBox.Show("Зал добавлен!");
            txtHallName.Clear();
            txtHallTheme.Clear();
            LoadHalls();
        }

        private void btnUpdateHall_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HallID"].Value);
            string name = txtHallName.Text.Trim();
            string theme = txtHallTheme.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(theme))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            DatabaseHelper.UpdateHall(id, name, theme);
            MessageBox.Show("Зал обновлён!");
            txtHallName.Clear();
            txtHallTheme.Clear();
            LoadHalls();
        }

        private void btnDeleteHall_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["HallID"].Value);

            if (MessageBox.Show("Удалить зал?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.DeleteHall(id);
                MessageBox.Show("Зал удалён!");
                txtHallName.Clear();
                txtHallTheme.Clear();
                LoadHalls();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtHallName.Text = row.Cells["HallName"].Value.ToString();
                txtHallTheme.Text = row.Cells["Theme"].Value.ToString();
            }
        }

        // ============================================================
        //  ЭКСПОНАТЫ
        // ============================================================
        private void LoadExhibits()
        {
            dataGridView2.DataSource = DatabaseHelper.GetExhibits();
            dataGridView2.Columns["ExhibitID"].HeaderText = "ID";
            dataGridView2.Columns["UniqueNumber"].HeaderText = "Уник. номер";
            dataGridView2.Columns["ExhibitName"].HeaderText = "Название";
            dataGridView2.Columns["ExhibitType"].HeaderText = "Тип";
            dataGridView2.Columns["HallID"].HeaderText = "ID зала";
            dataGridView2.Columns["HallName"].HeaderText = "Зал";
        }

        private void btnAddExhibit_Click(object sender, EventArgs e)
        {
            string number = txtUniqueNumber.Text.Trim();
            string name = txtExhibitName.Text.Trim();
            string type = txtExhibitType.Text.Trim();
            int hallId = (int)numericHallID.Value;

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            DatabaseHelper.AddExhibit(number, name, type, hallId);
            MessageBox.Show("Экспонат добавлен!");
            txtUniqueNumber.Clear();
            txtExhibitName.Clear();
            txtExhibitType.Clear();
            numericHallID.Value = 1;
            LoadExhibits();
        }

        private void btnUpdateExhibit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ExhibitID"].Value);
            string number = txtUniqueNumber.Text.Trim();
            string name = txtExhibitName.Text.Trim();
            string type = txtExhibitType.Text.Trim();
            int hallId = (int)numericHallID.Value;

            DatabaseHelper.UpdateExhibit(id, number, name, type, hallId);
            MessageBox.Show("Экспонат обновлён!");
            txtUniqueNumber.Clear();
            txtExhibitName.Clear();
            txtExhibitType.Clear();
            numericHallID.Value = 1;
            LoadExhibits();
        }

        private void btnDeleteExhibit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells["ExhibitID"].Value);

            if (MessageBox.Show("Удалить экспонат?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.DeleteExhibit(id);
                MessageBox.Show("Экспонат удалён!");
                txtUniqueNumber.Clear();
                txtExhibitName.Clear();
                txtExhibitType.Clear();
                numericHallID.Value = 1;
                LoadExhibits();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txtUniqueNumber.Text = row.Cells["UniqueNumber"].Value.ToString();
                txtExhibitName.Text = row.Cells["ExhibitName"].Value.ToString();
                txtExhibitType.Text = row.Cells["ExhibitType"].Value.ToString();
                numericHallID.Value = Convert.ToInt32(row.Cells["HallID"].Value);
            }
        }

        // ============================================================
        //  ПОСЕТИТЕЛИ
        // ============================================================
        private void LoadVisitors()
        {
            dataGridView3.DataSource = DatabaseHelper.GetVisitors();
            dataGridView3.Columns["VisitorID"].HeaderText = "ID";
            dataGridView3.Columns["FullName"].HeaderText = "ФИО";
            dataGridView3.Columns["BirthDate"].HeaderText = "Дата рождения";
            dataGridView3.Columns["Phone"].HeaderText = "Телефон";
        }

        private void btnAddVisitor_Click(object sender, EventArgs e)
        {
            string name = txtVisitorName.Text.Trim();
            DateTime birth = dtpBirthDate.Value;
            string phone = txtVisitorPhone.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }

            DatabaseHelper.AddVisitor(name, birth, phone);
            MessageBox.Show("Посетитель добавлен!");
            txtVisitorName.Clear();
            txtVisitorPhone.Clear();
            dtpBirthDate.Value = DateTime.Now;
            LoadVisitors();
        }

        private void btnUpdateVisitor_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView3.CurrentRow.Cells["VisitorID"].Value);
            string name = txtVisitorName.Text.Trim();
            DateTime birth = dtpBirthDate.Value;
            string phone = txtVisitorPhone.Text.Trim();

            DatabaseHelper.UpdateVisitor(id, name, birth, phone);
            MessageBox.Show("Посетитель обновлён!");
            txtVisitorName.Clear();
            txtVisitorPhone.Clear();
            dtpBirthDate.Value = DateTime.Now;
            LoadVisitors();
        }

        private void btnDeleteVisitor_Click(object sender, EventArgs e)
        {
            if (dataGridView3.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView3.CurrentRow.Cells["VisitorID"].Value);

            if (MessageBox.Show("Удалить посетителя?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.DeleteVisitor(id);
                MessageBox.Show("Посетитель удалён!");
                txtVisitorName.Clear();
                txtVisitorPhone.Clear();
                dtpBirthDate.Value = DateTime.Now;
                LoadVisitors();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                txtVisitorName.Text = row.Cells["FullName"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                txtVisitorPhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        // ============================================================
        //  СОТРУДНИКИ
        // ============================================================
        private void LoadEmployees()
        {
            dataGridView4.DataSource = DatabaseHelper.GetEmployees();
            dataGridView4.Columns["EmployeeID"].HeaderText = "ID";
            dataGridView4.Columns["FullName"].HeaderText = "ФИО";
            dataGridView4.Columns["Position"].HeaderText = "Должность";
            dataGridView4.Columns["Phone"].HeaderText = "Телефон";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtEmployeeName.Text.Trim();
            string position = txtEmployeePosition.Text.Trim();
            string phone = txtEmployeePhone.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Заполните ФИО и должность!");
                return;
            }

            DatabaseHelper.AddEmployee(name, position, phone);
            MessageBox.Show("Сотрудник добавлен!");
            txtEmployeeName.Clear();
            txtEmployeePosition.Clear();
            txtEmployeePhone.Clear();
            LoadEmployees();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells["EmployeeID"].Value);
            string name = txtEmployeeName.Text.Trim();
            string position = txtEmployeePosition.Text.Trim();
            string phone = txtEmployeePhone.Text.Trim();

            DatabaseHelper.UpdateEmployee(id, name, position, phone);
            MessageBox.Show("Сотрудник обновлён!");
            txtEmployeeName.Clear();
            txtEmployeePosition.Clear();
            txtEmployeePhone.Clear();
            LoadEmployees();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView4.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells["EmployeeID"].Value);

            if (MessageBox.Show("Удалить сотрудника?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.DeleteEmployee(id);
                MessageBox.Show("Сотрудник удалён!");
                txtEmployeeName.Clear();
                txtEmployeePosition.Clear();
                txtEmployeePhone.Clear();
                LoadEmployees();
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
                txtEmployeeName.Text = row.Cells["FullName"].Value.ToString();
                txtEmployeePosition.Text = row.Cells["Position"].Value.ToString();
                txtEmployeePhone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        // ============================================================
        //  БИЛЕТЫ
        // ============================================================
        private void LoadTickets()
        {
            dataGridView5.DataSource = DatabaseHelper.GetTickets();
            dataGridView5.Columns["TicketID"].HeaderText = "ID";
            dataGridView5.Columns["TicketType"].HeaderText = "Тип";
            dataGridView5.Columns["Price"].HeaderText = "Цена";
            dataGridView5.Columns["SaleDate"].HeaderText = "Дата продажи";
            dataGridView5.Columns["VisitorID"].HeaderText = "ID посетителя";
            dataGridView5.Columns["VisitorName"].HeaderText = "Посетитель";
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            string type = cbTicketType.Text;
            decimal price = numericTicketPrice.Value;
            int visitorId = (int)numericVisitorID.Value;

            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Выберите тип билета!");
                return;
            }

            DatabaseHelper.AddTicket(type, price, visitorId);
            MessageBox.Show("Билет добавлен!");
            cbTicketType.SelectedIndex = -1;
            numericTicketPrice.Value = 0;
            numericVisitorID.Value = 1;
            LoadTickets();
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (dataGridView5.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView5.CurrentRow.Cells["TicketID"].Value);

            if (MessageBox.Show("Удалить билет?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.DeleteTicket(id);
                MessageBox.Show("Билет удалён!");
                cbTicketType.SelectedIndex = -1;
                numericTicketPrice.Value = 0;
                numericVisitorID.Value = 1;
                LoadTickets();
            }
        }

        // ============================================================
        //  ЭКСКУРСИИ
        // ============================================================
        private void LoadExcursions()
        {
            dataGridView6.DataSource = DatabaseHelper.GetExcursions();
            dataGridView6.Columns["ExcursionID"].HeaderText = "ID";
            dataGridView6.Columns["ExcursionName"].HeaderText = "Название";
            dataGridView6.Columns["ExcursionDate"].HeaderText = "Дата и время";
            dataGridView6.Columns["MaxParticipants"].HeaderText = "Макс. участников";
            dataGridView6.Columns["GuideID"].HeaderText = "ID экскурсовода";
            dataGridView6.Columns["GuideName"].HeaderText = "Экскурсовод";
        }

        private void btnAddExcursion_Click(object sender, EventArgs e)
        {
            string name = txtExcursionName.Text.Trim();
            DateTime date = dtpExcursionDate.Value;
            int max = (int)numericMaxParticipants.Value;
            int guideId = (int)numericGuideID.Value;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Введите название экскурсии!");
                return;
            }

            DatabaseHelper.AddExcursion(name, date, max, guideId);
            MessageBox.Show("Экскурсия добавлена!");
            txtExcursionName.Clear();
            dtpExcursionDate.Value = DateTime.Now;
            numericMaxParticipants.Value = 10;
            numericGuideID.Value = 1;
            LoadExcursions();
        }

        private void btnUpdateExcursion_Click(object sender, EventArgs e)
        {
            if (dataGridView6.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView6.CurrentRow.Cells["ExcursionID"].Value);
            string name = txtExcursionName.Text.Trim();
            DateTime date = dtpExcursionDate.Value;
            int max = (int)numericMaxParticipants.Value;
            int guideId = (int)numericGuideID.Value;

            DatabaseHelper.UpdateExcursion(id, name, date, max, guideId);
            MessageBox.Show("Экскурсия обновлена!");
            txtExcursionName.Clear();
            dtpExcursionDate.Value = DateTime.Now;
            numericMaxParticipants.Value = 10;
            numericGuideID.Value = 1;
            LoadExcursions();
        }

        private void btnDeleteExcursion_Click(object sender, EventArgs e)
        {
            if (dataGridView6.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись в таблице!");
                return;
            }

            int id = Convert.ToInt32(dataGridView6.CurrentRow.Cells["ExcursionID"].Value);

            if (MessageBox.Show("Удалить экскурсию?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseHelper.DeleteExcursion(id);
                MessageBox.Show("Экскурсия удалена!");
                txtExcursionName.Clear();
                dtpExcursionDate.Value = DateTime.Now;
                numericMaxParticipants.Value = 10;
                numericGuideID.Value = 1;
                LoadExcursions();
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView6.Rows[e.RowIndex];
                txtExcursionName.Text = row.Cells["ExcursionName"].Value.ToString();
                dtpExcursionDate.Value = Convert.ToDateTime(row.Cells["ExcursionDate"].Value);
                numericMaxParticipants.Value = Convert.ToInt32(row.Cells["MaxParticipants"].Value);
                numericGuideID.Value = Convert.ToInt32(row.Cells["GuideID"].Value);
            }
        }

        // ============================================================
        //  ПЕРЕКЛЮЧЕНИЕ ВКЛАДОК
        // ============================================================
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageHalls)
                LoadHalls();
            else if (tabControl1.SelectedTab == tabPageExhibits)
                LoadExhibits();
            else if (tabControl1.SelectedTab == tabPageVisitors)
                LoadVisitors();
            else if (tabControl1.SelectedTab == tabPageEmployees)
                LoadEmployees();
            else if (tabControl1.SelectedTab == tabPageTickets)
                LoadTickets();
            else if (tabControl1.SelectedTab == tabPageExcursions)
                LoadExcursions();
        }

        // Кнопка "Обновить все" (если есть)
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageHalls)
                LoadHalls();
            else if (tabControl1.SelectedTab == tabPageExhibits)
                LoadExhibits();
            else if (tabControl1.SelectedTab == tabPageVisitors)
                LoadVisitors();
            else if (tabControl1.SelectedTab == tabPageEmployees)
                LoadEmployees();
            else if (tabControl1.SelectedTab == tabPageTickets)
                LoadTickets();
            else if (tabControl1.SelectedTab == tabPageExcursions)
                LoadExcursions();

            MessageBox.Show("Данные обновлены!");
        }
    }
}
