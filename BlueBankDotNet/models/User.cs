using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBankDotNet.models
{
    class User
    {
        public User(){}

        public User(string _name, string _password, int _age, string _address)
        {
            Name = _name;
            Password = _password;
            Age = _age;
            Address = _address;
        }

        public string Name;
        public string Password;
        public int Age;
        public string Address;
        
    }
}
