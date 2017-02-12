using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftSphinxly
{
    class ShowData
    {

        public Article[] allRecords = null;
        private SqlConnection conn = new SqlConnection();
        public BindingList<Article> list = new BindingList<Article>();

        public ShowData()
        {
            ConnectSQL();
        }

        private void ConnectSQL()
        {
            // Replace this with your connection and also set up a table.. server, table, user and pass.s
            conn.ConnectionString =
      "Data Source=" +
      "Initial Catalog=;" +
      "User id=;" +
      "Password=;";
            // .NET DataProvider -- Standard Connection with username and password
            conn.Open();
        }
        public void DeleteRow(String name)
        {
            // Kontrollera så vi inte har 0 (eller mindre) items i listan.
            if (list.Count <= 0 == false)
            {
                string sql = @"DELETE FROM Articles WHERE name = '" + name + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                LoadSQL();
            }   
        }
        public void ClearList()
        {
            list.Clear();
        }
        public void LoadSQL()
        {
            String sql = @"SELECT name,description,price,id
               FROM Articles";
            using (var command = new SqlCommand(sql, conn))
            {
                using (var reader = command.ExecuteReader())
                {
                    // kör SQL query med SQL DATA READER från COMMAND och ange värden för Article medlemsvariabler.
                    while (reader.Read())
                        list.Add(new Article { Name = reader.GetString(0), Description = reader.GetString(1), Price = reader.GetFloat(2), ID = reader.GetInt32(3) });
                }
            }
        }

        // Add records through sql
        public void AddRecords()
        {
            string sql = @"INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (1, N'Stol', N'Gammal stol', 459.99)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (2, N'Soffa', N'Stor soffa', 900)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (3, N'Bord', N'40x30x', 39000)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (4, N'Kaffebord', N'Litet kaffebord', 300)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (5, N'Matta', N'Liten Matte', 490)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (6, N'Lampa', N'Stark lampa, vitt huvud', 500)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (7, N'Stolsben', N'Ett svart stolsben 3x10', 99)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (8, N'Rund matta', N'En cirkelformad matta i skönt material.', 44.9)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (9, N'Bokhylla', N'En bokhylla från Japan.', 4999.9)
INSERT INTO [dbo].[Articles] ([Id], [name], [description], [price]) VALUES (10, N'Högtalarstativ', N'Perfekt för högtalare. Skapad i Shanghai.', 1800.99)
";
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();

            LoadSQL();
        }
    }
}
