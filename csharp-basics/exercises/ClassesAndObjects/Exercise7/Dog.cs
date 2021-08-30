using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Dog
    {
        string _name;
        string _sex;
        string _father;
        string _mother;
        
        public Dog(string name, string sex, string mother, string father)
        {
            this._name = name;
            this._sex = sex;
            this._father = father;
            this._mother = mother;
        }
        public Dog(string name, string sex) 
        {
            this._name = name;
            this._sex = sex; 
        }
        public string fathersName() 
        {
            if (_father == null) return "Unknown";
            else return _father;
        }
        public bool HasSameMotherAs(Dog dogName)
        {
            if (this._mother == ((Dog)dogName)._mother) 
            { return true; }
            else 
            {
                return false;
            }
        }
    }
    
}
