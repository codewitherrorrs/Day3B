using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B
{
    public class TypesOfConstructor
    {
       public string name,batch,result,brand;
        int marks;
        public int presentDay = 50; 
        //Normal Constructor
        public TypesOfConstructor() 
        {
            Console.WriteLine($"This is Normal Constructor.....");
        }
        //Parameterized Constructor
        public TypesOfConstructor(string name,string batch,int marks, string result)
        {
            this.name = name;
            this.batch = batch;
            this.marks = marks;
            this.result = result;
        }
        //To get the Output of the Parameterized Constructor.
        public void ConstructorOutput()
        {
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Batch : "+batch);
            Console.WriteLine("Marks : "+marks);
            Console.WriteLine("Result : "+result);
        }
        public TypesOfConstructor(string thebrand)
        {
            brand = thebrand;        
        }
        //Copy Constructor
        public TypesOfConstructor(TypesOfConstructor construct)
        {
                brand = construct.brand;
        }
    }
}
