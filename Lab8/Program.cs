using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab8
{
    class Program                          // Erik Engvall NET 22.
    {
        static void Main(string[] args)
        {          
            // Part I - Stack

            Employee E1 = new Employee() { Id = 110, Name = "Maverick", Gender = "Male", Salary = 32400 };    // Object 1.
            Employee E2 = new Employee() { Id = 111, Name = "Goose", Gender = "Male", Salary = 25500 };       // Object 2.
            Employee E3 = new Employee() { Id = 112, Name = "Elisabeth", Gender = "Female", Salary = 18700 }; // Object 3.
            Employee E4 = new Employee() { Id = 113, Name = "Elsa", Gender = "Female", Salary = 22000 };      // Object 4.
            Employee E5 = new Employee() { Id = 114, Name = "Charlie", Gender = "Male", Salary = 20000 };     // Object 5.

            Stack<Employee> EmploStack = new Stack<Employee>();     // Creating a stack and adding the objects with Push.
            EmploStack.Push(E1);
            EmploStack.Push(E2);
            EmploStack.Push(E3);
            EmploStack.Push(E4);
            EmploStack.Push(E5);

            foreach (var item in EmploStack)   // Foreach loop that prints out all elements in the stack.
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Gender + " " + item.Salary);
                Console.WriteLine("Items kvar i stacken: " + EmploStack.Count);  // Prints out how many items thats still in the stack.
            }
            Console.WriteLine("----------------------------------------------------------");  // Creating "gap" between the lines.
            Console.WriteLine("Retrieve Using Pop Method");
            for (int i = 5; i > 0; i--)  // For loop that prints out elements in the stack disappear one by one.
            {
                Employee empop = EmploStack.Pop();  // Creating a Pop Method.
                Console.WriteLine(empop.Id + " " + empop.Name + " " + empop.Gender + " " + empop.Salary);
                Console.WriteLine("Items kvar i stacken: " + EmploStack.Count);  // Prints out the items in stack.
            }
            Console.WriteLine("----------------------------------------------------------"); // Creating "gap" between the lines.
            Console.WriteLine("Retrieve Using Peek Method");

            EmploStack.Push(E1);        // Push 
            EmploStack.Push(E2);        // Push 
            EmploStack.Push(E3);        // Push 
            EmploStack.Push(E4);        // Push 
            EmploStack.Push(E5);        // Push 

            for (int i = 0; i < 2; i++)  // For loop
            {
                Employee empeek = EmploStack.Peek();
                Console.WriteLine(empeek.Id + " " + empeek.Name + " " + empeek.Gender + " " + empeek.Salary);
                Console.WriteLine("Items kvar i stacken: " + EmploStack.Count);  // Prints out the items in stack.
            }
            Console.WriteLine("----------------------------------------------------------"); // Creating "gap" between the lines.

            if (EmploStack.Contains(E3))  // If statement.
            {
                Console.WriteLine("E3 is in the stack.");
            }
            else    // Else statement.
            {
                Console.WriteLine("E3 is not in the stack.");  
            }

            //    Part II - List

            Console.WriteLine("---------------------------------------------------------------"); ; // Creating "gap" between the lines.
            List<Employee> ListEmplo = new List<Employee>();  // Creating a list with 5 objects.
            ListEmplo.Add(E1);
            ListEmplo.Add(E2);
            ListEmplo.Add(E3);
            ListEmplo.Add(E4);
            ListEmplo.Add(E5);
            if (ListEmplo.Contains(E3))  // If statement.
            {
                Console.WriteLine("Employee " + E3.Name + " with id " + E3.Id + " is in the list.");
            }
            else   // Else statement.
            {
                Console.WriteLine("Employee " + E3.Name + " with id " + E3.Id + "is not the list.");
            }
            Console.WriteLine("---------------------------------------------------------------------------"); // Creating "gap" between the lines.

            Employee findMale = ListEmplo.Find(fm => fm.Gender == "Male");  // Find Method that prints out the first male in the list.
            Console.WriteLine("First male in the list.");  // Prints out "First male in the list".
            Console.WriteLine($"ID = {findMale.Id}, Name = {findMale.Name}, Gender = {findMale.Gender}, Salary = {findMale.Salary}");
            Console.WriteLine("------------------------------------------------------"); // Creating "gap" between the lines.

            Employee findFemale = ListEmplo.Find(fm => fm.Gender == "Female");  // Find Method that prints out the first female in the list.
            Console.WriteLine("First female in the list.");  // Prints out "First female in the list".
            Console.WriteLine($"ID = {findFemale.Id}, Name = {findFemale.Name}, Gender = {findFemale.Gender}, Salary = {findFemale.Salary}");
            Console.WriteLine("------------------------------------------------------"); // Creating "gap" between the lines.

            Console.WriteLine("All males in the list.");  //// Prints out "All males in the list".
            List<Employee> findallMale = ListEmplo.FindAll(fam => fam.Gender == "Male");  // FindAll Method aiming for all "Males".
            foreach (Employee fam in findallMale)  // Foreach loop to find and print out all "Males".
            {
                Console.WriteLine($"ID = {fam.Id}, Name = {fam.Name}, Gender = {fam.Gender}, Salary = {fam.Salary}");
            }
            Console.WriteLine("------------------------------------------------------"); // Creating "gap" between the lines.
            Console.WriteLine("All females in the list.");  //// Prints out "All females in the list".
            List<Employee> findallFemale = ListEmplo.FindAll(fam => fam.Gender == "Female");  // FindAll Method aiming for all "Females".
            foreach (Employee fam in findallFemale)  // Foreach loop to find and print out all "Females".
            {
                Console.WriteLine($"ID = {fam.Id}, Name = {fam.Name}, Gender = {fam.Gender}, Salary = {fam.Salary}");
            }
            Console.WriteLine("------------------------------------------------------"); // Creating "gap" between the lines.

            Console.WriteLine("Finding all employees with the salary above the chosen salary, in this case, 21000");
            List<Employee> findSalary = ListEmplo.FindAll(findSalary => findSalary.Salary >= 21000);  // FindAll Method to find  employees with salary above --->
                                                                                                      // the chosen salary (21000) in this case.
            foreach (Employee findsalary in findSalary)   // Foreach loop to print out all employees with the salary above 21000   
            {
                Console.WriteLine($"ID = {findsalary.Id}, Name = {findsalary.Name}, Gender = {findsalary.Gender}, Salary = {findsalary.Salary}");
            }
        }
    }
}
