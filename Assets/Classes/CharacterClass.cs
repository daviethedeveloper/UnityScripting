using UnityEngine;
using UnityEngine.Assertions.Must;

namespace Classes
{
    public class CharacterClass
    {
        // set up the properties of our character
        public string name;
        public int exp = 0;
        
        // constructor - special method that fires automatically when creating an instance
        // fires automatically

        public CharacterClass(string name, int exp)
        {
            this.name = name;
            this.exp = exp;
        }

        public CharacterClass()
        {
            this.name = "Not Assigned";
            this.exp = 0;
        }
    }
}
