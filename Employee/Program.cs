using System;

namespace Employee
{
    class Employee
    {
        String Department;
        String FirstName;
    String LastName;

        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            for (int i = 0; i < 20; i++)
            {

                checkDept(myEmployee);
                checkFirstName(myEmployee);
                checkLastName(myEmployee);
                if (i < 9) { Console.WriteLine("Employee:  #" + (i + 1) + "   Name: " + myEmployee.FirstName + " " + myEmployee.LastName + "   Department: " + myEmployee.Department); }
                else { Console.WriteLine("Employee: #" + (i + 1) + "   Name: " + myEmployee.FirstName + " " + myEmployee.LastName + StringSpace(myEmployee.LastName)+ "   Department: " + myEmployee.Department); }
                
                myEmployee.Department = null;
                myEmployee.FirstName = null;
                myEmployee.LastName = null;
            }
            Console.ReadLine();
        }

        static void checkFirstName(Employee emp)
        {
            if (string.IsNullOrEmpty(emp.FirstName))
            {
                Random rand = new Random();
                int FirstNameID = rand.Next(4);
                switch (FirstNameID)
                {
                    case 0:
                        emp.FirstName = "Jesse";
                        break;
                    case 1:
                        emp.FirstName = "Lupe";
                        break;
                    case 2:
                        emp.FirstName = "Devon";
                        break;
                    default:
                        emp.FirstName = "Halley";
                        break;
                }

            }
        }


        static String StringSpace2(String str)
        {
            String SpaceString = "";
            for (int i = 0; i < (6 - str.Length); i++)
            {
                SpaceString += " ";
            }
            return SpaceString;
        }

        static String StringSpace(String str)
        {
            String SpaceString = "";
            for (int i = 0; i <(9- str.Length); i++)
            {
                SpaceString += " ";
            }
            return SpaceString;
        }

    static void checkLastName(Employee emp)
    {
        if (string.IsNullOrEmpty(emp.LastName))
        {
            Random rand = new Random();
            int LastNameID = rand.Next(4);
            switch (LastNameID)
            {
                case 0:
                    emp.LastName = "Foy";
                    break;
                case 1:
                    emp.LastName = "Hurtado";
                    break;
                case 2:
                    emp.LastName = "Kinzie";
                    break;
                default:
                    emp.LastName = "Davenport";
                    break;
            }

        }
    }
    static void checkDept(Employee emp)
        {
            if(string.IsNullOrEmpty(emp.Department))
            {
                Random rand = new Random();
                int depID = rand.Next(3);
                switch (depID)
                {
                    case 0:
                        emp.Department = "HR";
                        break;
                    case 1:
                        emp.Department = "Sales";
                        break;
                    default:
                        emp.Department = "I.T.";
                        break;
                }
                    
            }
        }
    }
}
