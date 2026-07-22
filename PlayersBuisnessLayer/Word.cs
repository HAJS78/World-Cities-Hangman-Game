using System;
using System.Data;
using PlayersDataAcessLayer;

namespace PlayersBuisnessLayer
{
    static public class clsWord
    {
        
        static public string SelectWordRandomly (string GameLevel) 
        {
          return  clsWordDataAccess.SelectWordRandomly(GameLevel);
           
        
        
        }
    }
}
