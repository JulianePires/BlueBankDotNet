using System;
using System.Collections.Generic;
using System.Text;

namespace BlueBankDotNet.models
{
    class Account : User
    {

        public Account(string _name, string _password, int _age, string _address, float _balance) : base(_name, _password, _age, _address)
        {
            Balance = _balance;
        }

        public float Balance;

		public void updateBalance(float value)
        {
			Balance = value;
        }

        public void updateName(string name)
        {
            Name = name;
        }

        public void updatePassword(string password)
        {
            Password = password;
        }

        public void updateAge(int age)
        {
            Age = age;
        }

        public void updateAddress(string address)
        {
            Address = address;
        }
    }
}
