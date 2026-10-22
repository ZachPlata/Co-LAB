using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace UESkillExchange
{
    public static class DbHelper
    {
        public static int CurrentUserId { get; set; } = 1;
        public static string CurrentUserName { get; set; } = "Zach Plata";
        public static string CurrentUserRole { get; set; } = "Student";

        public static string ConnectionString { get; set; } =
            "server=localhost; database= db_skillexchange; uid=root";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
