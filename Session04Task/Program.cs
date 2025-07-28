using Session04Task.Abstraction;

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
        }
    }
}
