using System;
using System.Data;
using System.Data.SqlClient;

namespace PlayersDataAcessLayer
{
    static public class clsPlayerDataAccess
    {
        static private bool _CheckPassword(string DBpassword,string EnteredPassword) 
        {
        
         return EnteredPassword == DBpassword;  
        
        }
        static public bool FindPlayerByAvatarNameAndPassword(ref int ID, string AvatarName, string EnteredPassword, ref string Age,ref int TotalPoints,int EnCredID)
        {
            bool IsFound = false;
            string DBPassword = "";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Players where AvatarName=@AvatarName ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AvatarName", AvatarName);
          

            try
            {
                connection.Open();
                SqlDataReader Resultset = command.ExecuteReader();
                if (Resultset.Read())
                {
                    IsFound = true;
                    ID = (int)Resultset["PlayerID"];
                    DBPassword=(string)Resultset["Password"];
                    if (Resultset["Age"] != DBNull.Value)
                    {
                        Age = (string)Resultset["Age"];
                    }
                    else
                    {
                        Age = "";
                    }
                    TotalPoints = (int)Resultset["TotalPoints"];

                }
                Resultset.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }

            finally
            {
                connection.Close();

            }

            if (EnCredID == 0)
            {
                return IsFound && _CheckPassword(DBPassword, EnteredPassword);
            }

            else if (EnCredID == 1)
            {
                return IsFound ;

            }
            else 
            {
                return false ;
            }

        }
        static public int AddPlayerToDatabase(string AvatarName, string Password, string Age)
        {
            int PlayerID = -1;
            int TotalPoints = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into Players(AvatarName,Password,Age,TotalPoints) values (@AvatarName,@Password,@Age,@TotalPoints);select scope_identity();";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@AvatarName", AvatarName);
            Command.Parameters.AddWithValue("@Password", Password);
            if (Age != null)
            {
                Command.Parameters.AddWithValue("@Age", Age);
            }
            else
            {
                Command.Parameters.AddWithValue("@Age", DBNull.Value);

            }
            Command.Parameters.AddWithValue("@TotalPoints", TotalPoints);

            try

            {
                connection.Open();
                object generatedID = Command.ExecuteScalar();
                if (generatedID != null && int.TryParse(generatedID.ToString(), out int ID))
                {
                    PlayerID = ID;

                }


            }

            catch (Exception ex)
            {
                PlayerID = -1;
            }

            finally
            {

                connection.Close();
            }

            return PlayerID;

        }

        static public bool UpdatePlayerInfo(int ID, string Password, string Age,int TotalPoints)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update Players set Password=@Password ,Age=@Age,TotalPoints=@TotalPoints where PlayerID=@ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@TotalPoints", TotalPoints);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                RowAffected = 0;
            }

            finally
            {
                connection.Close();


            }
            return RowAffected > 0;

        }



        static public bool DeletePlayerAccount(string AvatarName)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete Players where AvatarName=@AvatarName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AvatarName", AvatarName);
            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                RowAffected = 0;
            }

            finally
            {
                connection.Close();


            }
            return RowAffected > 0;
        }

        static public bool PlayerHasAccount(string AvatarName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select found=1 from Players where AvatarName=@AvatarName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AvatarName", AvatarName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }

            catch
            {
                IsFound = false;
            }

            finally
            {

                connection.Close();

            }

            return IsFound;
        }


        static public DataTable GetLeaderBoard()
        {

            DataTable LeaderBoard = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select AvatarName,TotalPoints from Players order by TotalPoints desc ";

            SqlCommand command = new SqlCommand(query, connection);

           
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    LeaderBoard.Load(reader);
                }

                reader.Close();
            }
            catch
            {


            }
            finally
            {

                connection.Close();

            }

            return LeaderBoard;


        }




    }

    

 }
