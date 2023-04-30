namespace Day3B
{
    public class Program
    {
        public static void Main(string[] args)
        {
         /*   TypesOfConstructor obj = new TypesOfConstructor();
            TypesOfConstructor obj_One = new TypesOfConstructor("Sagar","RFP",85,"Pass");
            TypesOfConstructor obj_Two = new TypesOfConstructor("Mustang");
            Console.WriteLine($"Brand Name : {obj_Two.brand}");
            //Copy Constructor
            TypesOfConstructor construct = new TypesOfConstructor(obj_Two);
            Console.WriteLine("Copy Constructor : "+construct.brand);
            Console.WriteLine("Default Constructor : "+obj_Two.presentDay);
            obj_One.ConstructorOutput(); 
            Bank obj = new Bank();
            obj.BankAccountDetails();
            obj.AccountBalanceDetails(); */
            AccessModifier obj = new AccessModifier();
            Console.WriteLine($"The sum is : {obj.num_One + obj.num_Two}");
            Console.WriteLine(obj.Name="Krishna");
            Derived derived= new Derived();
            Console.WriteLine(derived.Lastname);
            Console.WriteLine(derived.marks);
            Console.ReadKey();
        }
    }
}