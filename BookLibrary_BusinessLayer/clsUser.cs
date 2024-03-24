using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using clsBookLibraryAccessLayer;
namespace BookLibrary_BusinessLayer
{

    public class clsUser
    {
        enum enMode
        {
            eAdd,eUpdate
        }
        enMode _Mode = enMode.eAdd;

        public int ID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public clsUser()
        {
            ID=-1; 
            PersonID=-1;
            UserName = "";
            Password = "";
            IsAdmin = false;
            _Mode = enMode.eAdd;

        }

        public clsUser(int iD, int personID, string userName, string password, bool isAdmin)
        {
            this.ID = iD;
            this.PersonID = personID;
            this.UserName = userName;
            this.Password = password;
            this.IsAdmin = isAdmin;
            _Mode = enMode.eUpdate;

        }

        private bool _AddNewUser()
        {
            clsUsersData.stUserInfo userInfo= new clsUsersData.stUserInfo();
            userInfo.UserName = this.UserName;
            userInfo.Password = this.Password;
            userInfo.IsAdmin = this.IsAdmin;
            userInfo.PersonID = this.PersonID;
            this.ID=clsUsersData.AddNewUser(userInfo);
            return this.ID != -1;
        }

        private bool _UpdateUser()
        {
            clsUsersData.stUserInfo userInfo = new clsUsersData.stUserInfo();
            userInfo.UserName = this.UserName;
            userInfo.Password = this.Password;
            userInfo.IsAdmin = this.IsAdmin;
            userInfo.PersonID = this.PersonID;
            return clsUsersData.UpdateUser(this.ID,userInfo);
            
        }
        static public bool DeleteUser(int ID)
        {
            return clsUsersData.DeleteUser(ID);
        }

        static public clsUser FindUser(int ID)
        {
            clsUsersData.stUserInfo userInfo=new clsUsersData.stUserInfo();
            if (clsUsersData.Find(ID, ref userInfo))
                return new clsUser(ID, userInfo.PersonID, userInfo.UserName, userInfo.Password,userInfo.IsAdmin);
            else
                return null;
        }
        static public clsUser FindUser(string UserName)
        {
            int UserID = -1;
            clsUsersData.stUserInfo userInfo = new clsUsersData.stUserInfo();
            if (clsUsersData.Find(ref UserID,UserName, ref userInfo))
                return new clsUser(UserID, userInfo.PersonID, userInfo.UserName, userInfo.Password, userInfo.IsAdmin);
            else
                return null;
        }

        static public clsUser FindUser(string UserName,string Password)
        {
            clsUsersData.stUserInfo userInfo = new clsUsersData.stUserInfo();
            int UserID = -1;
            if (clsUsersData.Find(ref UserID, ref userInfo.PersonID, UserName,Password,ref userInfo.IsAdmin))
                return new clsUser(UserID, userInfo.PersonID, userInfo.UserName, userInfo.Password, userInfo.IsAdmin);
            else
                return null;
        }
        static public bool Login(string UserName, string Password)
        {
            return clsUsersData.Login(UserName, Password);
             
        }
        static public bool IsExitsByID(int ID)
        {
            return clsUsersData.IsExist(ID);
        }
        static public bool IsExitsByUserName(string UserName)
        {
            return clsUsersData.IsExist(UserName);
        }

        static public DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.eAdd:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.eUpdate;
                        return true;
                    }
                    else
                        return false;
                case enMode.eUpdate:
                    if (_UpdateUser())
                        return true;
                    else
                        return false;
            }
            return false;
        }
    }
}
