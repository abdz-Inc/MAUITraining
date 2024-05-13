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
                
                if (name == string.Empty){
                    throw new ArgumentException("Name cannot be Empty");
                }
                name = value;
            } }
        public string Phonenumber
        {
            get => phonenumber; 
            set
            {
                
                if (phonenumber == string.Empty)
                {
                    throw new ArgumentException("Phonenumber cannot be Empty");
                }
                phonenumber = value;
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
