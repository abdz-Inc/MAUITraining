using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITraining
{
    public enum UserType
    {
        NormalUser,
        Admin
    }

    internal class User
    {
        private string id;
        private string name;
        private string phonenumber;


        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Id cannot be Empty");
                }
                id = value;
            }

        }
        public string Name
        {
            get => name;
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be Empty");
                }
                name = value;
            }
        }
        
        public string Phonenumber
        {
            get => phonenumber;
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Phonenumber cannot be Empty");
                }
                phonenumber = value;
            }
        }

        public UserType Type { get; set; }

        public User() { }

        public User(string id, string name, string phonenumber, UserType usertype)
        {
            Id = id;
            Name = name;
            Phonenumber = phonenumber;
            Type = usertype;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {name}, Phonenumber : {Phonenumber}, UserType : {Type}";
        }


    }
}
