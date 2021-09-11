using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashSearch
{
    
    class DataBase
    {
        static void Main()
        {
            const string CONN_STR =???? ";Pwd=269f43dc;";
            var data_base = new MySqlConnection(CONN_STR);
            data_base.Open();
​
            ShowInfo("");
            ShowInfo("");
            ShowInfo("");
            var select = Console.ReadLine();
                        
            var sql = $"SELECT ???? FROM tab_ JOIN tab_ ON tab??? = tab_products.id WHERE product_id = {select}";
            var command = new MySqlCommand
            {
                CommandText = sql,
                Connection = data_base
            };
            var ??? = command.ExecuteReader();
​
            if (???.HasRows)
            {
                do
                {
                    ???.Read();
                    var count = ???.GetInt32("count");
                    ShowSuccess($"count = {count}");
                } while (???.NextResult());
            }
            else
            {
                ShowError("Вернулась пустая таблица");
            }
            
            data_base.Close();
        }
    }
}
   
