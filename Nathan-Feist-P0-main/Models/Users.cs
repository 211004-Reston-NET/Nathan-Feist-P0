﻿using System;
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
        private List<Orders> _orders = new List<Orders>();


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
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Address can only hold letters and Numbers!");
                }
                _userPhone = value;
            }
        }
        public string UserEmail
        {
            get { return _userEmail; }
            set
            {
                //Main idea - this Regex will find me any number inside of my string
                if (!Regex.IsMatch(value, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    //Will give the user an exception whenever you try to set the city field with a number
                    throw new Exception("Address can only hold letters and Numbers!");
                }
                _userEmail = value;
            }
        }

        public List<Orders> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public string Password { get; set; }

        public override string ToString()
        {
            return $"Customer Name: {UserName} \nCustomer Address: {UserAddress} \nCustomer Email: {UserEmail} \nCustomer Phone: {UserPhone}";




        }


    }
}