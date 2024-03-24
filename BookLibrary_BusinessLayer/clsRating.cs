using clsLibraryAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_BusinessLayer
{
    public class clsRating
    {
       
        static public bool RateABook(int BookID, int UserID, int Rate)
        {
           return clsRatingsData.RateABook(BookID,UserID,Rate);
        }
        static public short GetBookRate(int BookID)
        {
            return clsRatingsData.GetBookRate(BookID);
        }
        static public short GetBookRate(int BookID,int UserID)
        {
            return clsRatingsData.GetBookRate(BookID,UserID);
        }
        static public bool CanRate(int BookID, int UserID)
        {
            return clsRatingsData.CanRate(BookID, UserID);
        }

    }
}
