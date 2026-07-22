using System;
using System.Data;
using PlayersDataAcessLayer;

namespace PlayersBuisnessLayer
{
    public class clsGameSession
    {
        
        

        
        static private int _AvatarNameToPlayerID(string AvatarName) 
        {

            return clsGameSessionDataAccess.AvatarNameToPlayerID(AvatarName);


        }

        
        static public DataTable GetPlayerActivities(string AvatarName, string Password)
        {

      

            return clsGameSessionDataAccess.GetPlayerActivities(AvatarName,Password);




        }

        static public  bool Save(string AvatarName, string word,int collectedpoints, DateTime sessiondate) 
        {
            int currentPlayerID = _AvatarNameToPlayerID(AvatarName);
          return (clsGameSessionDataAccess.Save(currentPlayerID,word, collectedpoints, sessiondate)!=-1);
        
        
        }
    }
}
