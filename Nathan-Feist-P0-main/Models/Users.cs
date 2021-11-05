using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Models
{
    public class Users
    {


        //This is a field
        private int _userId;
        private string _userName;
        private string _userAddress;
        private string _userPhone;
        private string _userEmail;
        private List<Users> _users = new List<Users>();



        //This is a property that uses the field called _name
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[a-zA-Z]+(\s[a-zA-Z]+)?$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Name can only hold letters!");
                }
                _userName = value;
            }
        }

        public string UserAddress
        {
            get { return _userAddress; }
            set
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[A-Za-z0-9'\.\-\s\,]"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Address can only hold letters and Numbers!");
                }
                _userAddress = value;
            }
        }
        public string UserPhone
        {
            get { return _userPhone; }
            set
                        {
                if (!Regex.IsMatch(value, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"))
                {
                    throw new Exception("Invaild Phone Number Format!");
                }
                _userPhone = value;
            }       
        }
        public string UserEmail
        {
            get { return _userEmail; }
            set
            {
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"))
                {
                    throw new Exception("Invaild E-Mail Address!");
                }
                _userEmail = value;
            }
        }

        public List<Users> User { get { return _users; } set { _users = value; } }

        public override string ToString()
        {
            return $"CustomerID: {UserId}\n Name: {UserName}\nAddress: {UserAddress}\nE-mail: {UserEmail}\nPhone: {UserPhone}";
        }


    }
}