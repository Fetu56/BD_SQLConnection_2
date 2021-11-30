using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BD_SQLconnection
{
    class SQLwork
    {
        private SqlConnection cn;
        public SQLwork(string name = "sql5080.site4now.net", string initDB = "db_a7d303_fet")
        {
            cn = new SqlConnection($"Data Source={name};Initial Catalog={initDB};Integrated Security=False;User id=db_a7d303_fet_admin;Password=EgorPrivet123");
        }
        public void Start()
        {
            cn.Open();

            

            using (SqlCommand command = new SqlCommand($"CREATE TABLE CATEGORY([id] INT PRIMARY KEY IDENTITY, [name] VARCHAR(15) NOT NULL, [desc] TEXT NULL);", cn))
            {
                try
                {
                    int res = command.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Table CATEGORY created");
                    }
                }
                catch (SqlException) { Console.WriteLine("Table CATEGORY arleady exist!"); }
            }
            using (SqlCommand command = new SqlCommand($"CREATE TABLE PRODUCT([id] INT IDENTITY, [name] VARCHAR(15) NOT NULL, [id_category] INT NOT NULL, [cost] INT NULL, FOREIGN KEY([id_category]) REFERENCES CATEGORY ([id]));", cn))
            {
                try
                {
                    int res = command.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Table PRODUCT created");
                    }
                }
                catch (SqlException) { Console.WriteLine("Table PRODUCT arleady exist!"); }
            }
            while (!Environment.HasShutdownStarted)
            {
                try
                {
                    Console.WriteLine("Выберите опцию: Продолжить работу с таблицами Продукт и Категория - 0, получение всех баз данных на сервере - 1:");
                    if(Console.ReadLine().StartsWith("0"))
                    {
                        Console.WriteLine("Выберите таблицу: Category - 0, Product - 1:");
                        string res = Console.ReadLine().StartsWith("1") ? "PRODUCT" : "CATEGORY";
                        Console.WriteLine($"Выберете действие(1 - введение значений {res}, 2 - удаление значений {res}, 3 - получить данные с таблицы {res}, 0 - выход):");
                        Option option = (Option)int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case Option.input:
                                Input(res, res == "PRODUCT" ? 3 : 2);
                                break;
                            case Option.delete:
                                Delete(res, "[id]");
                                break;
                            case Option.get:
                                Get(res);
                                break;
                            case Option.exit:
                                return;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        List<string> dbs = new List<string>();
                        Console.WriteLine("Базы данных:");
                        using (SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", cn))
                        {
                            using (IDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    dbs.Add(dr[0].ToString());
                                }
                            }
                        }
                        dbs.ForEach(Console.WriteLine);
                        for(int i = 0; i < dbs.Count; i++)
                        {
                            Console.WriteLine();
                            List<string> tbs = new List<string>();
                            Console.WriteLine($"Таблицы в {dbs[i]}:");
                            using (SqlCommand cmd = new SqlCommand($"USE {dbs[i]};SELECT name FROM sys.Tables", cn))
                            {
                                using (IDataReader dr = cmd.ExecuteReader())
                                {
                                    while (dr.Read())
                                    {
                                        tbs.Add(dr[0].ToString());
                                    }
                                }
                            }
                            tbs.ForEach(Console.WriteLine);
                        }
                       
                        
                        Console.WriteLine();
                        DataTable t = cn.GetSchema("Tables");
                        Console.WriteLine(t.TableName);
                        Console.Read();
                        Console.Read();
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                finally
                {
                    Console.WriteLine();
                    GC.Collect();
                }
            }
        }
        private bool Input(string tableNM, int count = 2)
        {
            bool res = false;
            Console.WriteLine($"Введите значение для вставки в таблицу {tableNM}(для выхода введите '!'):");
            string inp = Console.ReadLine();
            List<string> rowsValues = new List<string>();
            while (inp != "!")
            {
                rowsValues.Add(inp);
                inp = Console.ReadLine();
            }
            string comm = $"INSERT INTO {tableNM} VALUES";
            if(count == 2)
            {
                rowsValues.ForEach(x => comm += $"('{x.Split(' ')[0]}', '" + (x.Split(' ').Length > 1 ? x.Split(' ')[1] : 0) + $"'),");
            }
            else if(count == 3)
            {
                rowsValues.ForEach(x => comm += $"('{x.Split(' ')[0]}', '" + (x.Split(' ').Length > 1 ? x.Split(' ')[1] : 0) + $"', '{(x.Split(' ').Length > 2 ? x.Split(' ')[2] : 0)}'),");
            }
            comm = comm.Remove(comm.Length - 1);
            using (SqlCommand command = new SqlCommand(comm, cn))
            {
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    res = true;
                }
            }
            return res;
        }
        private bool Get(string tableNM)
        {
            bool res = false;
            List<KeyValuePair<string, string>> valueList = new List<KeyValuePair<string, string>>();
            using (SqlCommand command = new SqlCommand($"SELECT * FROM {tableNM}", cn))
            {
                var data = command.ExecuteReader();
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        object id = data.GetValue(0);
                        StringBuilder val = new StringBuilder();
                        for (int i = 1; i < data.FieldCount; i++)
                        {
                            val.Append("\t" + data.GetValue(i));
                        }
                        valueList.Add(new KeyValuePair<string, string>(id.ToString(), val.ToString())); ;
                    }
                }
                data.Close();
            }
            if (valueList.Count > 0)
            {
                Console.WriteLine("Постоянный вывод или временный? Постоянный - 0, Временный - 1");
                if (Console.ReadLine().StartsWith("0"))
                {
                    Task displaying = new Task(() => DisplayAll(tableNM));
                    List<KeyValuePair<string, string>> valueList1 = null;
                    displaying.Start();
                    while (displaying.Status == TaskStatus.Running || displaying.Status == TaskStatus.WaitingToRun)
                    {
                        Thread.Sleep(1500);
                        List<KeyValuePair<string, string>> valueListNew = new List<KeyValuePair<string, string>>();
                        using (SqlCommand command = new SqlCommand($"SELECT * FROM {tableNM}", cn))
                        {
                            var data = command.ExecuteReader();
                            if (data.HasRows)
                            {
                                while (data.Read())
                                {
                                    object id = data.GetValue(0);
                                    StringBuilder val = new StringBuilder();
                                    for (int i = 1; i < data.FieldCount; i++)
                                    {
                                        val.Append("\t" + data.GetValue(i));
                                    }
                                    valueListNew.Add(new KeyValuePair<string, string>(id.ToString(), val.ToString())); ;
                                }
                            }
                            data.Close();
                        }
                        if (valueList1 != valueListNew)
                        {
                            Console.Clear();
                            Console.WriteLine("Для выхода введите \'!\':");
                            valueListNew.ForEach(InputNote);
                            valueList1 = valueListNew;
                            GC.Collect();
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine($"Выберите индекс для получения данных, от 0 до {valueList.Count - 1} или для вывода всех заметок введите \'!\':");
                    string inp = Console.ReadLine();
                    if (inp.StartsWith("!"))
                    {
                        valueList.ForEach(InputNote);
                        res = true;
                    }
                    else if (int.Parse(inp) < valueList.Count)
                    {
                        InputNote(valueList[int.Parse(inp)]);
                        res = true;
                    }
                    Console.WriteLine();
                }
                
            }
            return res;
        }
        private void DisplayAll(string tableNM)
        {
            while (!Console.ReadLine().StartsWith("!"))
            {

            }
            Console.Clear();
        }
        private void InputNote(KeyValuePair<string, string> pair)
        {
            Console.WriteLine("{0}.\t\t\t{1}", pair.Key, pair.Value);
        }
        private bool Delete(string tableNM, string idColName)
        {
            bool res = false;
            Console.WriteLine($"Введите id для удаления в таблице {tableNM}(для выхода введите '!'):");
            string inp = Console.ReadLine();
            List<string> rowsValues = new List<string>();
            while (inp != "!")
            {
                if (Char.IsNumber(inp, 0))
                    rowsValues.Add(inp);
                inp = Console.ReadLine();
            }
            string comm = $"DELETE FROM {tableNM} WHERE ";
            rowsValues.ForEach(x => comm += $"{idColName}='{x}' OR ");
            comm = comm.Remove(comm.Length - 4, 4);

            using (SqlCommand command = new SqlCommand(comm, cn))
            {
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    res = true;
                }
            }
            return res;
        }
    }
}