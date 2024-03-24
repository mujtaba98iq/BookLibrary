using clsLibraryAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_BusinessLayer
{
    public class clsBookCoppies
    {
        enum enMode
        {
            eAdd, eUpdate
        }
        enMode _Mode = enMode.eAdd;
        public int CoppyID { get; set; }
        public int BookID { get; set; }
        public bool IsAvailable { get; set; }

        public clsBookCoppies() 
        {
            CoppyID = 0;
            BookID = 0;
            IsAvailable = false;
            _Mode = enMode.eAdd;

        }
        public clsBookCoppies (int CoppyID,int BookID,bool IsAvailable)
        {
            this.CoppyID=CoppyID;
            this.BookID=BookID;
            this.IsAvailable=IsAvailable;
            _Mode=enMode.eUpdate;
        }

        public static bool AddBookCoppies(int BookID, short Quantity)
        {
            return clsBookCoppiesData.AddBookCoppies(BookID, Quantity);
        }

        public static clsBookCoppies FindCoppy(int CoppyID)
        {
            int BookID = -1;
            bool IsAvailable = false;
            if( clsBookCoppiesData.Find(CoppyID,ref BookID,ref IsAvailable))
                return new clsBookCoppies(CoppyID,BookID,IsAvailable);
            else
                return null;
        }
        public static bool IsBookAvailable(int BookID)
        {
            return clsBookCoppiesData.IsBookAvailable(BookID);
        }

        public static int GetTopAvailableCoppy(int BookID)
        {
            return clsBookCoppiesData.GetTopAvailableCoppy(BookID);
        }
        public static bool SetAsUnAvailable(int BookID)
        {
            return clsBookCoppiesData.SetAsUnAvailable(BookID);
        }
        public static bool SetAsAvailable(int BookID)
        {
            return clsBookCoppiesData.SetAsAvailable(BookID);
        }

    }
}
