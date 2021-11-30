using System;

namespace BD_Connection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BD_SQLconnection.SQLwork sql = new BD_SQLconnection.SQLwork();
            sql.Start();
        }
    }
}
