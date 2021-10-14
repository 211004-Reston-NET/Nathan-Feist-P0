using System;

namespace Models
{
    public class User
    {
        string _ID;
        string _name;
        string _address;
        string _email;
        string _phoneNumber;


        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            string user =
            $@"User ID: {ID}
            Name: {Name}
            Shipping Address: {Address}
            Email: {Email}
            Phone Number: {PhoneNumber}
            ";
            return user;
        }

    }

}