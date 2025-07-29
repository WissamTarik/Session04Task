using Session04Task.Abstraction;
using Session04Task.Mapping;
using Session04Task.Operator_Overloading;
using Session04Task.Static;
//using System.Numerics;

namespace Session04Task
{

    #region Video01 Revision
        /*What can be written inside namespace? 
         * 1.struct
         * 2.enum
         * class
         * inteface
         
         */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video01 Revision
            //Interface:Is a code contract between developer who write it and
            //developer who will implement it
            //Interface is a reference type
            /*What can be written inside interface?
              1.Signature of property
              2.Signature of method
              3.Default fully implemented method
             
             */
            //Shallow copy :Copy the identity(Address)
            //Deep copy:Copy the object state(data) and generate new identity by clone method
            #endregion

            #region Video02 Abstraction
            //4.Abstract
            //abstract:C# keyword[class-method-property]
            //abstract class:Partial class [not fully implemented class]
            //abstract method:metgod has no body
            //abstract property

            //Shape shape = new Shape();
            //NOTE:U can't create instance(object) of abstracy class 
            //shape.getArea();
            //Rectangle rectangle = new Rectangle() { Dim01=12,Dim02=3};
            //Console.WriteLine(rectangle.Perimeter);
            //Console.WriteLine(rectangle.getArea());
            //rectangle.Print();

            //Square square= new Square() { Dim01=10,Dim02=10};



            #endregion

            #region Video03 Interface vs Abstract class

            /*Interface
             * -Is a code contract between the developer who write it and developer who 
             *   will implement it
             * -we can write in it Signature of property,Signature of method and fully
             *     implemented method
             * -Default access modifer inside it is public
             * -can't inherit fully implemented method
             * -Can implement more than one interface
             * 
             
             */

            /*Abstract class
             * -Is a class
             * -We can write in it methods,attributes, event,property,abstract methods
             *  and abstract property
             *  -Default access modifer inside it is private 
             *  -Any fully implemented method,and property can inherit and override it
             *  -Can't inherit more than one abstract class
             
             */
            #endregion

            #region Video04 Operator overloading 
            //+ - * / > < >= <= == != && || ! | & ^
            //Operator overloading :Adding a new behavior to the operator
            //Complex  Number :Real + Imagine

            //Complex C01= new Complex() { Real=3,Imag=4};
            //Complex C02= new Complex() { Real=4,Imag=2};
            //Complex C03 = C01 + C02;
            //Complex C03 = C01 - null;
            //Console.WriteLine(C03);
            #endregion


            #region Video05 Operator overloading (Unary Operator)
            //++ --
            //Complex C01=new Complex() { Real=3, Imag=4};
            //Console.WriteLine(C01);
            //C01++;
            //Console.WriteLine(C01);
            //C01--;
            //Console.WriteLine(C01);
            #endregion


            #region Video06 Operator overloading comparison operator
            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2};
            //if (C01 >= C02)
            //{
            //    Console.WriteLine("C01 is greater than C02");
            //}
            //else
            //{
            //    Console.WriteLine("C01 is not greater than C02");
            //}

            #endregion


            #region Video07 User-defined casting operator
            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //string S = (string)C01;
            //Console.WriteLine(S);
            //int X =(int) C01;
            //Console.WriteLine(X);
            //Operator overloading
            //User-defined casting operator

            //Mapping :Convert from datatype to another datatype

            //Code first ✔
            //DB first
            //User user = new User();

            ////Manual mapping
            //Userdto userdto = new Userdto() { Email = user.Email, Name = user.Name, PhoneNumber = user.PhoneNumber };

            //Automapper:Mapping automatic
            #endregion

            #region Video08 static
            //Static:C# keyword [attributes -methods - property- class -constructor]
            //static attribute
            //static method
            //static property
            //static class
            //static constructor

            //Utilities U01=new Utilities();
            //Utilities U02=new Utilities();
            //Utilities U03=new Utilities();
            //Console.WriteLine(U01.CmToInch(254));
            //Console.WriteLine(U02.CmToInch(254));
            //Console.WriteLine(U03.CmToInch(254));

            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(U01.PI);
            //Console.WriteLine(U02.PI);
            //Console.WriteLine(U03.PI);

            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);

            #endregion

            #region Video09 Sealed
            //Sealed :Is a C# keyword [class - method-property]
            //It prevent class to inherit from it
            //Prevent to override on method or property
            #endregion

            #region Video10 Partial
            Employee employee = new Employee();
            employee.Name = "Ahmed";
            employee.Id = 10;
            #endregion
        }
    }
}
