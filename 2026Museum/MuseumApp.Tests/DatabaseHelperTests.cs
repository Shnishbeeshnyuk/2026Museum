using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Data;
using System.IO;

using _2026MUSEUM;

namespace MuseumApp.Tests
{
    public class DatabaseHelperTests
    {
        [Fact]
        public void GetHalls_ShouldReturnDataTable()
        {
            var result = _2026MUSEUM.DatabaseHelper.GetHalls();
            Assert.NotNull(result);
            Assert.IsType<DataTable>(result);
        }

        [Fact]
        public void AddHall_ShouldIncreaseCount()
        {
            int countBefore = _2026MUSEUM.DatabaseHelper.GetHalls().Rows.Count;
            _2026MUSEUM.DatabaseHelper.AddHall("Тестовый зал", "Тест");
            int countAfter = _2026MUSEUM.DatabaseHelper.GetHalls().Rows.Count;

            Assert.Equal(countBefore + 1, countAfter);

            // Очищаем тестовые данные
            var dt = _2026MUSEUM.DatabaseHelper.GetHalls();
            foreach (DataRow row in dt.Rows)
            {
                if (row["HallName"].ToString() == "Тестовый зал")
                {
                    _2026MUSEUM.DatabaseHelper.DeleteHall((int)row["HallID"]);
                    break;
                }
            }
        }

        [Fact]
        public void DeleteHall_ShouldDecreaseCount()
        {
            _2026MUSEUM.DatabaseHelper.AddHall("Зал для удаления", "Тест");

            var dt = _2026MUSEUM.DatabaseHelper.GetHalls();
            int idToDelete = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["HallName"].ToString() == "Зал для удаления")
                {
                    idToDelete = (int)row["HallID"];
                    break;
                }
            }

            int countBefore = _2026MUSEUM.DatabaseHelper.GetHalls().Rows.Count;
            _2026MUSEUM.DatabaseHelper.DeleteHall(idToDelete);
            int countAfter = _2026MUSEUM.DatabaseHelper.GetHalls().Rows.Count;

            Assert.Equal(countBefore - 1, countAfter);
        }
    }
}
