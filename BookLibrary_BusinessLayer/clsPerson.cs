using clsBookLibraryAccessLayer;
using clsLibraryAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew, Update };
        public enMode _Mode;

        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public bool Gendor { get; set; }
        public string PersonalPicture { get; set; } 

        public clsPerson() 
        { 
            PersonID = -1;
            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            DateOfBirth = DateTime.MinValue;
            Address = string.Empty;
            Gendor = false;
            PersonalPicture = string.Empty;
            _Mode = enMode.AddNew;

        }
        public clsPerson(int PersonID,string Name,string Email,string Phone,
            DateTime DateOfBirth,string Address,bool Gendor,string PersonalPicture)
        {
            this.PersonID = PersonID;
            this.Name = Name;
            this.Email = Email;
            this.Phone = Phone;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.Gendor = Gendor;
            this.PersonalPicture = PersonalPicture;
            _Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            clsPersonData.stPersonInfo personInfo = new clsPersonData.stPersonInfo();
            personInfo.Name = this.Name;
            personInfo.Email = this.Email;
            personInfo.Phone = this.Phone;
            personInfo.DateOfBirth = this.DateOfBirth;
            personInfo.Address = this.Address;
            personInfo.Gendor = this.Gendor;
            personInfo.PersonalPicture = this.PersonalPicture;

            this.PersonID = clsPersonData.AddNewPerson(personInfo);
            return this.PersonID != -1;
        }
        private bool _UpdatePerson()
        {
            clsPersonData.stPersonInfo personInfo = new clsPersonData.stPersonInfo();
            personInfo.Name = this.Name;
            personInfo.Email = this.Email;
            personInfo.Phone = this.Phone;
            personInfo.DateOfBirth = this.DateOfBirth;
            personInfo.Address = this.Address;
            personInfo.Gendor = this.Gendor;
            personInfo.PersonalPicture = this.PersonalPicture;

            return clsPersonData.UpdatePerson(this.PersonID, personInfo);

        }
        static public bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        static public clsPerson FindPerson(int ID)
        {
            clsPersonData.stPersonInfo personInfo = new clsPersonData.stPersonInfo();
            if (clsPersonData.Find(ID, ref personInfo))
                return new clsPerson(ID, personInfo.Name, personInfo.Email, personInfo.Phone, personInfo.DateOfBirth,
                    personInfo.Address,personInfo.Gendor,personInfo.PersonalPicture);
            else
                return null;
        }

        static public bool IsExitsByID(int ID)
        {
            return clsPersonData.IsExist(ID);
        }

        static public DataTable GetAllPersons()
        {
            return clsPersonData.GetAllPerson();
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    if (_UpdatePerson())
                        return true;
                    else
                        return false;
            }
            return false;
        }






    }
}
