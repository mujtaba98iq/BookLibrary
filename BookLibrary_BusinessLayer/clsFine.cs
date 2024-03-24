using clsLibraryAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_BusinessLayer
{

    public class clsFine
    {
        enum en_Mode{eAdd, eUpdate}
        en_Mode _Mode = en_Mode.eAdd;
        public int FineID { get; set; }
        public int UserID { get; set; }
        public int BorrowingRecordID { get; set;}
        public short NumberOfLateDays { get; set; }
        public decimal FineAmount { get; set; }
        public bool PaymentStatus { get; set; }

        public clsFine()
        { 
            FineID = -1;
            UserID = -1;
            BorrowingRecordID = -1;
            NumberOfLateDays = 0;
            FineAmount = 0;
            PaymentStatus = false;
            _Mode = en_Mode.eAdd;
        }
        public clsFine(int FineID,int UserID,int BorrowingRecordID,short NumberOfLateDays,
            decimal FineAmount,bool PaymentStatus)
        {
            this.FineID = FineID;
            this.UserID = UserID;
            this.BorrowingRecordID= BorrowingRecordID;
            this.NumberOfLateDays = NumberOfLateDays;
            this.FineAmount = FineAmount;
            this.PaymentStatus = PaymentStatus;
            _Mode= en_Mode.eUpdate;
        }
        private bool _AddNewFine()
        {
            clsFinesData.stFineInfo fineInfo = new clsFinesData.stFineInfo();
            this.FineID = clsFinesData.AddNewFine(fineInfo);
            return this.FineID != 0;
        }
        private bool _UpdateFine()
        {
            clsFinesData.stFineInfo fineInfo = new clsFinesData.stFineInfo();
            return clsFinesData.UpdateFine(this.FineID, fineInfo);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case en_Mode.eAdd:
                    if (_AddNewFine())
                    {
                        _Mode = en_Mode.eUpdate;
                        return true;
                    }
                    else
                        return false;
                case en_Mode.eUpdate:
                    if (_UpdateFine())
                        return true;
                    else
                        return false;
            }
            return false;
        }
        static public bool DeleteFine(int ID)
        {
            return clsFinesData.DeleteFine(ID);
        }
        static public bool IsExist(int ID)
        {
            return clsFinesData.IsExist(ID);
        }
        static public bool SetAsPaid(int ID)
        {
            return clsFinesData.SetAsPaid(ID);
        }
        static public DataTable GetAllFines()
        {
            return clsFinesData.GetAllFines();
        }
        static public clsFine Find(int ID)
        {
            clsFinesData.stFineInfo fineInfo =new clsFinesData.stFineInfo();
            if (clsFinesData.Find(ID, ref fineInfo))
                return new clsFine(ID, fineInfo.UserID, fineInfo.BorrowingRecordID,
                    fineInfo.NumberOfLateDays, fineInfo.FineAmount, fineInfo.PaymentStatus);
            else
                return null;
        }

    }
}
