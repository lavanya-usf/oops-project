namespace oops_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person student1 = new Person { firstName = "Lavanya", lastName = "Chilakalapudi" };
            Console.WriteLine(student1.firstName + " " + student1.lastName);
            Console.WriteLine(student1.getName());

            Person student2 = new Person { firstName = "Nandu", lastName = "CH" };
            Console.WriteLine(student2.salutation + student2.firstName + " " + student2.lastName);
            Console.WriteLine(student2.salutation + student2.getName());

            // accessing the student class
            Student myStudent = new Student();
            Console.WriteLine(myStudent.studentNumber + " " + myStudent.getName());
            myStudent.setSSN("337y");
            Console.WriteLine(myStudent.getSSN());

            // Graduate stuent class
            GraduateStudent mygrad = new GraduateStudent();
            Console.WriteLine(mygrad.Study());
            Console.WriteLine(mygrad.Rest());
            
        }
    }
}
