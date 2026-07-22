using System;
using System.Data;
using System.Data.SqlClient;

namespace PlayersDataAcessLayer
{
    public class clsGameSessionDataAccess
    {

        static public int AvatarNameToPlayerID(string AvatarName)
        {
            int PlayerID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select PlayerID from Players where AvatarName=@AvatarName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AvatarName", AvatarName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();  //MOVE TO THE FIRST ROW
                    PlayerID = Convert.ToInt32(reader["PlayerID"]);
                }
                else
                {
                    PlayerID = -1;

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



        

        static public DataTable GetPlayerActivities(string AvatarName, string Password)
        {
            DataTable activities = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select gamesessions.CollectedPoints,words.WordLevel,gamesessions.DateTime from gamesessions " + "inner join players on gamesessions.PlayerID=players.PlayerID" +
               " inner join words on gamesessions.WordID=words.ID" + " where Players.AvatarName=@AvatarName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AvatarName",AvatarName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    activities.Load(reader);
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

            return activities;
        }



       static private int _GetWordID(string word)
        {
            int wordID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select ID from words where words.Word=@word";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@word", word);
            try
            {
                connection.Open();
                object WID = command.ExecuteScalar();

                if (WID != null && int.TryParse(WID.ToString(), out int GWID))
                {
                    wordID = GWID;
                }
            }
            catch
            {

                wordID = -1;
            }
            finally
            {

                connection.Close();

            }

           

            return wordID;
           

        }


    
       static public int Save(int currentPlayerID,string word, int collectedpoints, DateTime sessiondate) 
        {
            int WordID = _GetWordID(word);
            int GameSessionID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into gamesessions(PlayerID,WordID,CollectedPoints,DateTime) values (@currentPlayerID,@WordID,@collectedpoints,@sessiondate);select scope_identity();";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@currentPlayerID", currentPlayerID);
            Command.Parameters.AddWithValue("@WordID",WordID);
            Command.Parameters.AddWithValue("@collectedpoints", collectedpoints);
          
            if (sessiondate != null)
            {
                Command.Parameters.AddWithValue("@sessiondate", sessiondate);
            }
            else
            {
                Command.Parameters.AddWithValue("@sessiondate", DBNull.Value);

            }

            try

            {
                connection.Open();
                object generatedID = Command.ExecuteScalar();
                if (generatedID != null && int.TryParse(generatedID.ToString(), out int ID))
                {
                    GameSessionID = ID;

                }


            }

            catch (Exception ex)
            {
                GameSessionID = -1;
            }

            finally
            {

                connection.Close();
            }

            return GameSessionID;

        }
    }

}
