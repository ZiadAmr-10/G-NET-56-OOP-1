namespace Assignment01OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            //Class is a Reference type stores in stack(address)+Heap(object),Struct is a value type store in Stack
            //Class Support inheritance,Struct not support inheritence
            //Struct Copies the data 
            // Struct copies the data:
            //    struct Point
            //{
            //    public string Name;
            //    public int Age;
            //    public Point(string name, int age)
            //    {
            //        Name = name;
            //        Age = age;
            //    }
            //}
            //Point P01 = new Point ("Ali",10 );
            //Point P02 = P01;     // Copies the data
            //P02.Name = "Ahmed";
            // P01.Name = "Ali"
            // P02.Name = "Ahmed"
            //Class Copies the reference 
            //    class Person
            //{
            //    public string Name;
            //    public int Age;
            //}
            //Person P01 = new Person ("Ali",10);
            //Person P02 = P01;    // Copies the reference (address) not data 
            //P02.Name = "Ahmed";
            // P01.Name = "Ahmed"
            // P02.Name = "Ahmed"
            #endregion
            #region Question02
            //Public  ->The member or type is accessible from anywhere, both within the same assembly and from other assemblies
            //public class Student
            //Example:{
            //public void Print()
            //        {
            //           Console.WriteLine("Hello");
            //        }
            //    }
            //Student s = new Student();
            //s.Print(); -> Accessible
            //Private ->The member is accessible only within the class or struct in which it is defined. It cannot be accessed from outside the class
            //Example : class Student
            //    {
            //private int age;
            // }
            //Student s = new Student();
            // s.Age; ->Not Accessible
            #endregion
            #region Question03
            //1.Create a new Class Library project in Visual Studio.
            //2.Write the reusable classes inside the Class Library.
            //3.Build the project.
            //4.In the main project, add a Project Reference to the Class Library from Dependencies.
            //5.Import the namespace using the using keyword.
            //6.Create objects and use the classes from the Class Library.
            #endregion
            #endregion
        }
    }
}
