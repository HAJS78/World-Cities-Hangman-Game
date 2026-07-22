using System;
using System.Data;
using System.Runtime.CompilerServices;
using PlayersDataAcessLayer;

namespace PlayersBuisnessLayer
{
    public class clsPlayer
    {
      
        public int ID { get; set; }
        public string AvatarName { get; set; }
        public string Password {  get; set; }
        public string Age { get; set; }
        public int TotalPoints {  get; set; }
       public enum EnMode { AddNew=0,Update=1};
       
        public EnMode Mode= EnMode.AddNew;

        public enum EnCredentialsMode {Login=0,SignUp=1};
        
        public clsPlayer(int ID ,string AvatarName,string Password,string Age,int TotalPoints) 
        {
        
         this.ID = ID;
         this.AvatarName = AvatarName;
         this.Password = Password;
         this.Age = Age;
         this.TotalPoints = TotalPoints;
         Mode = EnMode.Update;
        }
        public clsPlayer(string AvatarName, string Password, string Age, int TotalPoints)
        {

            
            this.AvatarName = AvatarName;
            this.Password = Password;
            this.Age = Age;
            this.TotalPoints = TotalPoints; 
            Mode = EnMode.AddNew;
        }

        static public clsPlayer Find(string AvatarName,string Password,EnCredentialsMode EnCred) 
        {
            int ID = -1;
            string Age = "";
            int TotalPoints = 0;
            int EnCredID;
            if (EnCred == EnCredentialsMode.Login) 
            {
                EnCredID = 0;


            }
            else 
            {
                EnCredID = 1;


            }
            if(clsPlayerDataAccess.FindPlayerByAvatarNameAndPassword(ref ID,AvatarName,Password,ref Age,ref TotalPoints,EnCredID)) 
            {
             clsPlayer player=new clsPlayer(ID,AvatarName,Password,Age,TotalPoints);
             return player;
            }

            else 
            {
                return null;
            }


        }

        private bool _UpdatePlayer()
        {

            return clsPlayerDataAccess.UpdatePlayerInfo(this.ID,this.Password,this.Age,this.TotalPoints);
        }
        private bool _AddNewPlayerToDatabase() 
        {
            this.ID = clsPlayerDataAccess.AddPlayerToDatabase(AvatarName, Password, Age);
            
            return this.ID != -1;

        }

       
         public bool Save() 
        {

            if (Mode == EnMode.AddNew)
            {
                return (_AddNewPlayerToDatabase());
            }
            else if (Mode == EnMode.Update) 
            {
            
            
             return _UpdatePlayer();
            }
            else 
            {
              return false;
            }






        }
        static public bool PlayerHasAccount(string AvatarName) 
        {

            return clsPlayerDataAccess.PlayerHasAccount(AvatarName);



        }

        static public bool DeletePlayerAccount(string AvatarName)
        {

            return clsPlayerDataAccess.DeletePlayerAccount(AvatarName);
            
        }

        static public DataTable GetLeaderBoard()
        {



            return clsPlayerDataAccess.GetLeaderBoard();




        }

    }
}
