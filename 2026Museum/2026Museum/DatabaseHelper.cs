using System;
using System.Data;
using System.Data.SqlClient;

namespace _2026MUSEUM
{
    public class Hall
    {
        public int HallID { get; set; }
        public string HallName { get; set; }
        public string Theme { get; set; }
    }

    public class Exhibit
    {
        public int ExhibitID { get; set; }
        public string UniqueNumber { get; set; }
        public string ExhibitName { get; set; }
        public string ExhibitType { get; set; }
        public int HallID { get; set; }
        public string HallName { get; set; }
    }

    public class Visitor
    {
        public int VisitorID { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
    }

    public static class DatabaseHelper
    {
        // Строка подключения - ЗАМЕНИТЕ на свою!
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\MakSSSim\Desktop\снова дистант\лето2026язАебусь\проектирование ИС Луканов и тд\proga\2026Museum\2026Museum\MuseumDB.mdf"";Integrated Security=True";

        // ============ ЗАЛЫ ============
        public static DataTable GetHalls()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Halls", conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddHall(string name, string theme)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Halls (HallName, Theme) VALUES (@name, @theme)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@theme", theme);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateHall(int id, string name, string theme)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Halls SET HallName=@name, Theme=@theme WHERE HallID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@theme", theme);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteHall(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Halls WHERE HallID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ============ ЭКСПОНАТЫ ============
        public static DataTable GetExhibits()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT e.*, h.HallName 
                                FROM Exhibits e 
                                LEFT JOIN Halls h ON e.HallID = h.HallID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddExhibit(string uniqueNumber, string name, string type, int hallId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Exhibits (UniqueNumber, ExhibitName, ExhibitType, HallID) 
                                                  VALUES (@num, @name, @type, @hall)", conn);
                cmd.Parameters.AddWithValue("@num", uniqueNumber);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@hall", hallId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateExhibit(int id, string uniqueNumber, string name, string type, int hallId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Exhibits SET UniqueNumber=@num, ExhibitName=@name, 
                                                  ExhibitType=@type, HallID=@hall WHERE ExhibitID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@num", uniqueNumber);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@hall", hallId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteExhibit(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Exhibits WHERE ExhibitID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ============ ПОСЕТИТЕЛИ ============
        public static DataTable GetVisitors()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Visitors", conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddVisitor(string name, DateTime birthDate, string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Visitors (FullName, BirthDate, Phone) VALUES (@name, @birth, @phone)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birth", birthDate);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateVisitor(int id, string name, DateTime birthDate, string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Visitors SET FullName=@name, BirthDate=@birth, Phone=@phone WHERE VisitorID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@birth", birthDate);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteVisitor(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Visitors WHERE VisitorID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ============ СОТРУДНИКИ ============
        public static DataTable GetEmployees()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees", conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddEmployee(string name, string position, string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees (FullName, Position, Phone) VALUES (@name, @pos, @phone)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pos", position);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateEmployee(int id, string name, string position, string phone)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employees SET FullName=@name, Position=@pos, Phone=@phone WHERE EmployeeID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pos", position);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteEmployee(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        // ============ БИЛЕТЫ ============
        public static DataTable GetTickets()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT t.*, v.FullName as VisitorName 
                        FROM Tickets t 
                        LEFT JOIN Visitors v ON t.VisitorID = v.VisitorID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddTicket(string type, decimal price, int visitorId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tickets (TicketType, Price, VisitorID) VALUES (@type, @price, @visitor)", conn);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@visitor", visitorId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteTicket(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tickets WHERE TicketID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        // ============ ЭКСКУРСИИ ============
        public static DataTable GetExcursions()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT e.*, emp.FullName as GuideName 
                        FROM Excursions e 
                        LEFT JOIN Employees emp ON e.GuideID = emp.EmployeeID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddExcursion(string name, DateTime date, int maxParticipants, int guideId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Excursions (ExcursionName, ExcursionDate, MaxParticipants, GuideID) 
                                          VALUES (@name, @date, @max, @guide)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@max", maxParticipants);
                cmd.Parameters.AddWithValue("@guide", guideId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateExcursion(int id, string name, DateTime date, int maxParticipants, int guideId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Excursions SET ExcursionName=@name, ExcursionDate=@date, 
                                          MaxParticipants=@max, GuideID=@guide WHERE ExcursionID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@max", maxParticipants);
                cmd.Parameters.AddWithValue("@guide", guideId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteExcursion(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Excursions WHERE ExcursionID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}