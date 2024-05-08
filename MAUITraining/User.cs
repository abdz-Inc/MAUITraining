using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITraining
{
    internal class User
    {
        private string id;
        private string name;
        private string phonenumber;

        public string Id { 
            get => id;
            set {
                id = value;
            }

            }
        public string Name { 
            get => name; 
            set {
                name = value;
                if (name == string.Empty){
                    throw new ArgumentException("Name cannot be Empty");
                }
            } }
        public string Phonenumber
        {
            get => phonenumber; 
            set
            {
                phonenumber = value;
                if (phonenumber == string.Empty)
                {
                    throw new ArgumentException("Phonenumber cannot be Empty");
                }
            }
        }

        public User() { }

        public User(string id,string name, string phonenumber )
        {
            Id = id;
            Name = name;
            Phonenumber = phonenumber;
        }

        
    }
}
