// See https://aka.ms/new-console-template for more information
string choice, choice2, uname, passwd;
bool flg1, flg2;

Console.WriteLine("**********Welcome to Employee Management System**********");
Console.Write("Press ENTER to login: ");
Console.ReadLine();
flg1 = true;

while(flg1)
{
Console.WriteLine("1. Employee");
Console.WriteLine("2. Admin");
Console.WriteLine("3. Exit");

Console.Write("Enter choice: ");
choice = Console.ReadLine();

switch(choice)
{
    case "1":
        #region emp_case
        Console.WriteLine("Welcome Employee.\n");

        Console.Write("Enter Username: ");
        uname = Console.ReadLine();
        if (uname == "ANKAN")
        {
            Console.Write("Enter password: ");
            passwd = Console.ReadLine();

            if (passwd == "ankan@123")
            {
                Console.WriteLine("Login Successful, Welcome " + uname);
                flg2 = true;

                #region emp_submenu
                while (flg2)
                { 
                    Console.WriteLine("\n1. Check Employee Details.");
                    Console.WriteLine("2. Apply Leave");
                    Console.WriteLine("3. Raise a request to manager");
                    Console.WriteLine("4. Submit a Bill");
                    Console.WriteLine("5. Fill Daily Worksheet");
                    Console.WriteLine("6. Exit\n");

                    Console.Write("Enter choice: ");
                    choice2 = Console.ReadLine();

                    switch(choice2)
                    {
                        case "1":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break; 
                        case "2":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine(); 
                            break; 
                        case "3":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break; 
                        case "4":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break;
                        case "6":
                            flg2 = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                #endregion
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        } else
        {
            Console.WriteLine("Invalid Username.");
        }
        #endregion
        break;
    case "2":
        #region admin_case
        Console.WriteLine("Welcome Admin.");
        Console.Write("Enter Username: ");
        uname = Console.ReadLine();
        if (uname == "Admin")
        {
            Console.Write("Enter password: ");
            passwd = Console.ReadLine();

            if (passwd == "E&Y@987654321")
            {
                Console.WriteLine("Login Successful, Welcome " + uname);
                flg2 = true;

                #region admin_submenu
                while (flg2)
                {
                    Console.WriteLine("\n1. Add new Employee");
                    Console.WriteLine("2. View Employee Details");
                    Console.WriteLine("3. Delete Employee");
                    Console.WriteLine("4. Approve Leaves");
                    Console.WriteLine("5. Approve voucher");
                    Console.WriteLine("6. Announcement");
                    Console.WriteLine("7. Exit\n");

                    Console.Write("Enter choice: ");
                    choice2 = Console.ReadLine();

                    switch (choice2)
                    {
                        case "1":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break;
                        case "6":
                            Console.WriteLine("Option " + choice2 + " selected");
                            Console.Write("Press Enter to return.");
                            Console.ReadLine();
                            break;
                        case "7":
                            flg2 = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                #endregion
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
        else
        {
            Console.WriteLine("Invalid Username.");
        }
#endregion
        break;
    case "3":
        flg1 = false;
        break;
    default: 
        Console.WriteLine("Invalid Input");
        break;
}
}