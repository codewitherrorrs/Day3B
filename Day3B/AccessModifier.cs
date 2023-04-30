using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B
{
   public class AccessModifier
    {
        //Public Access Modifier.
        public int num_One = 20;
        public int num_Two = 40;
        //Private Access Modifier.
        private string name = "Sagar Shahu";
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        //Protected
        protected string lastname = "shahu";
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
    }
    //Internal
   internal class Derived : AccessModifier 
    {
      public int marks = 565;
    }


}
