using System;
using System.Data;
using System.Data.SqlClient;
namespace PlayersDataAcessLayer
{
    static public class clsWordDataAccess
    {
        static Random rnd = new Random();

        public static string  SelectWordRandomly(string GameLevel) 
        {
            string RandomlyChosenWord = "";

            DataTable WListdt=new DataTable();
            SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select word from words where wordlevel=@GameLevel";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@GameLevel",GameLevel);
            try 
            {
             connection.Open();
             SqlDataReader wlist = command.ExecuteReader();
                if (wlist.HasRows) 
                {
                    WListdt.Load(wlist);


                } 
            wlist.Close();
            
            }

            catch 
            {
            
            }
            finally 
            {
            connection.Close();
            }
           int WordsCount = WListdt.Rows.Count;
           int randomrownumber=rnd.Next(0,WordsCount);
           RandomlyChosenWord = WListdt.Rows[randomrownumber][0].ToString();
           return RandomlyChosenWord;


        }
    }
}
