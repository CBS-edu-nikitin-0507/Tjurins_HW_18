using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct struct1 = new MyStruct();
            MyClass class1 = new MyClass();

            struct1.change = "CBA struct";
            class1.change = "CBA class";

            Console.WriteLine($"1 - Struct: {struct1.change}");
            Console.WriteLine($"1 - Class: {class1.change}");

            StruktTaker(struct1);
            ClassTaker(class1);

            Console.WriteLine($"2 - Struct: {struct1.change}");
            Console.WriteLine($"2 - Class: {class1.change}");
        }
        static void ClassTaker(MyClass myClass)
        {

            myClass.change = "ABC struct";
        }
        static void StruktTaker(MyStruct myStruct)
        {

            myStruct.change = "ABC class";
        }
    }
}
