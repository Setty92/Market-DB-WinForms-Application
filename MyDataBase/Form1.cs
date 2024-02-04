using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mime;
using System.Windows.Forms;

namespace MyDataBase
{
    public class ComboBoxItem
    {
        public string NameGood { get; set; }

        public override string ToString()
        {
            return NameGood;
        }
    }
    public partial class Form1 : Form
    {
        public const string ConnectionString = "Server=192.168.56.104; Database=MarcketDB; User Id=sa; Password = Root1Root1";
        public Form1()
        {
            InitializeComponent();
            FillComboBoxes();
            DisplayStatistics();
        }

        private void FillComboBoxes()
        {
            string query = @"SELECT NameGood FROM Goods";
            GoodNameDelCB.Items.Clear();
            GoodNameEditCB.Items.Clear();
            comboBox1.Items.Clear();
            comboBox3.Items.Clear();
            
            CorpNameEditCB.Items.Clear();
            comboBox2.Items.Clear();
            
            comboBox4.Items.Clear();
            
            comboBox5.Items.Clear();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nameGood = Convert.ToString(reader["NameGood"]);

                            ComboBoxItem item = new ComboBoxItem()
                            {
                                NameGood = nameGood
                            };
                            
                            GoodNameDelCB.Items.Add(item);
                            GoodNameEditCB.Items.Add(item);
                            comboBox1.Items.Add(item);
                            comboBox3.Items.Add(item);
                        }
                    }
                }
            }

            query = @"SELECT NameCorp FROM Corps";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nameGood = Convert.ToString(reader["NameCorp"]);

                            ComboBoxItem item = new ComboBoxItem()
                            {
                                NameGood = nameGood
                            };
                            
                            CorpNameEditCB.Items.Add(item);
                            comboBox2.Items.Add(item);
                        }
                    }
                }
            }
            
            query = @"SELECT IdContract FROM Contracts";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nameGood = Convert.ToString(reader["IdContract"]);

                            ComboBoxItem item = new ComboBoxItem()
                            {
                                NameGood = nameGood
                            };
                            
                            comboBox4.Items.Add(item);
                        }
                    }
                }
            }
            
            query = @"SELECT IdPlace FROM Storage";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nameGood = Convert.ToString(reader["IdPlace"]);

                            ComboBoxItem item = new ComboBoxItem()
                            {
                                NameGood = nameGood
                            };
                            
                            comboBox5.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void DisplayStatistics()
        {
            string query = @"SELECT MAX(CostGood) As MaxCost,
                                    AVG(CostGood) As AvgCost,
                                    SUM(CostGood) As TotalCost FROM Goods";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal maxCost = Convert.ToDecimal(reader["MaxCost"]);
                            decimal avgCost = Convert.ToDecimal(reader["AvgCost"]);
                            decimal totalCost = Convert.ToDecimal(reader["TotalCost"]);

                            MaxCostText.Text = $"Максимальная стоимость: {maxCost}";
                            AvgCostText.Text = $"Средняя стоимость: {avgCost}";
                            totalCostText.Text = $"Полная стоимость всех товаров: {totalCost}";
                        }
                    }
                }
            }
        }
        
        private void LoadData(string param1,string tableName, string param2)
        {
            string query = $"SELECT {param1} FROM {tableName} {param2}";
        
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void AddData(string tableName, string params1, string params2)
        {
            string query = $"INSERT INTO {tableName} {params1} VALUES {params2};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteData(string tableName, string param1, string param2)
        {
            string query = $"DELETE FROM {tableName} WHERE {param1} = {param2}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void EditData(string tableName, string param1, string param2)
        {
            string query = $"UPDATE {tableName} SET {param1} WHERE {param2}";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            } 
        }
        
        private void LoadStorageButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string query = $"WITH GoodsNames AS (SELECT IdGood, NameGood  FROM Goods) SELECT s.IdPlace, g.NameGood AS GoodsName, s.IdContract, s.Have FROM Storage s JOIN GoodsNames g ON s.IdGood = g.IdGood UNION SELECT s.IdPlace, g.NameGood AS GoodsName, s.IdContract, s.Have FROM Storage s JOIN GoodsNames g ON s.IdGood = g.IdGood;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            };
        }

        private void LoadGoodsButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            LoadData("NameGood, CostGood","Goods", "");
            DisplayStatistics();
        }


        private void GoodOrderNameButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            LoadData("NameGood, CostGood","Goods", "ORDER BY NameGood");
        }

        private void GoodOrgerCostButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            LoadData("NameGood, CostGood","Goods", "ORDER BY CostGood");
        }

        private void GoodsInCountButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string query = $"EXEC GoodsInCount";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void GoodAddButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string name = NameGoodTextBox.Text;
            string cost = CostGoodTextBox.Text;
            AddData("Goods", "(NameGood, CostGood)", $"('{name}', {cost})");
            LoadData("NameGood, CostGood","Goods", "");
            FillComboBoxes();
        }


        private void GoodDeleteButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string name = GoodNameDelCB.Text;
            DeleteData("Goods", "NameGood", $"'{name}'");
            LoadData("NameGood, CostGood","Goods", "");
            FillComboBoxes();
        }

        private void GoodEditButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string name = GoodNameEditCB.Text;
            string cost = GoodCostEdit.Text;
            EditData("Goods", $" CostGood = {cost}", $"NameGood = '{name}'");
            LoadData("NameGood, CostGood","Goods", "");
            FillComboBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void LoadContractButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string query = $"SELECT c.IdContract, t.NameGood AS GoodsName, p.NameCorp AS NameCorp, c.CostContract FROM Contracts c JOIN Goods t On c.IdGood = t.IdGood JOIN Corps p ON c.IdCorp = p.IdCorp;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            };
        }


        private void ContractOrderCostButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string query = $"SELECT c.IdContract, t.NameGood AS GoodsName, p.NameCorp AS NameCorp, c.CostContract FROM Contracts c JOIN Goods t On c.IdGood = t.IdGood JOIN Corps p ON c.IdCorp = p.IdCorp ORDER BY CostContract;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            };
        }

        private void LoadCorpsButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            LoadData("*","Corps", "");
        }

        private void LoadCorpsButton_Click_1(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            LoadData("UPPER(NameCorp) AS UpperNameCorp, EmailCorp","Corps", "");
        }

        private void CorpsOrderNameButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            LoadData("NameCorp, EmailCorp","Corps", "ORDER BY NameCorp");
        }

        private void StorageFullButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string query = $"WITH GoodNames AS (SELECT IdGood, NameGood FROM Goods) SELECT s.IdPlace, t.NameGood AS GoodsName, s.IdContract, s.Have FROM Storage s JOIN Goods t On s.IdGood = t.IdGood WHERE have = 1;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            };
        }

        private void StorageFreeButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string query = $"WITH GoodNames AS (SELECT IdGood, NameGood FROM Goods) SELECT s.IdPlace, t.NameGood AS GoodsName, s.IdContract, s.Have FROM Storage s JOIN Goods t On s.IdGood = t.IdGood WHERE have = 0;";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
            };
        }

        private void StorageAddButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string NameGood = comboBox3.Text;
            string IdContract = comboBox4.Text;
            string query = $"EXEC InsertIntoStorage @GoodsName = '{NameGood}',\n    @ContractId = '{IdContract}';";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            LoadData("*", "Storage", "WHERE Have = 0");
            FillComboBoxes();
        }

        private void StorageDeleteButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string id = comboBox5.Text;
            DeleteData("Storage", "IdPlace", $"{id}");
            LoadData("*", "Storage", "WHERE Have = 0");
            FillComboBoxes();
        }


        private void StorageEditButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            //string idPlace = textBox3.Text;
            //string idGood = textBox2.Text;
            //string idContract = textBox1.Text;
            
            //EditData("Storage", $"idGood = {idGood}, IdContract = {idContract}", $"IdPlace = {idPlace}");
            //LoadData("*", "Storage", "WHERE Have = 0");
        }

        private void ContractAddButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string NameGood = comboBox1.Text;
            string NameCorp = comboBox2.Text;
            string Cost = textBox10.Text;
            string query = $"EXEC InsertContract @GoodsName = '{NameGood}',\n    @SupplierName = '{NameCorp}',\n    @ContractCost = {Cost};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            LoadData("*","Contracts", "");
            FillComboBoxes();
        }


        private void CorpAddButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string name = textBox12.Text;
            string email = textBox11.Text;
            AddData("Corps", "(NameCorp, EmailCorp)", $"('{name}', '{email}')");
            LoadData("*","Corps", "");
            FillComboBoxes();
        }


        private void CorpEditButton_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            string name = CorpNameEditCB.Text;
            string email = textBox7.Text;
            
            EditData("Corps", $"NameCorp = '{name}', EmailCorp = '{email}'", $"NameCorp = '{name}'");
            LoadData("*","Corps", "");
            FillComboBoxes();
        }

        
    }
    
    
}