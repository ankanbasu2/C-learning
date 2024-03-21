using System;
using System.Collections;
using System.Collections.Generic;

bool flg = true;
string choice, name, accType, accBranch;
double balance, totBalance = 0;
int accNo = 0, savingsAcc = 0, currAcc = 0;

List<string> users = new List<string>();
Dictionary<int, ArrayList> accDetails = new Dictionary<int, ArrayList>();
Console.WriteLine("**********Banking App**********");

while(flg) {
    Console.WriteLine("\n1. Create new acc");
    Console.WriteLine("2. View acc details");
    Console.WriteLine("3. Summary");
    Console.WriteLine("4. Exit");
    
    Console.Write("\nEnter Choice: ");
    choice = Console.ReadLine();
    
    switch(choice) {
        case "1":
            Console.Write("Enter user name: ");
            name = Console.ReadLine();
            Console.Write("Chose acc type(Savings/Current): ");
            accType = Console.ReadLine();
            
            if (accType == "Savings") {
                savingsAcc++;
            } else if (accType == "Current") {
                currAcc++;
            } else {
                Console.WriteLine("Invalid choice.");
                break;
            }
            
            Console.Write("Enter balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
            
            totBalance += balance;
            
            Console.Write("Enter branch location: ");
            accBranch = Console.ReadLine();
            
            accNo++;
            users.Add(name); // index = accNo-1;
            
            ArrayList tmp = new ArrayList();
            tmp.Add(accType);
            tmp.Add(balance);
            tmp.Add(accBranch);
            
            accDetails.Add(accNo, tmp);
            break;
        case "2":
            Console.Write("Enter username: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Matches:\n");
            for (int i=0; i<accNo; i++) {
                if (name == users[i]) {
                    // i+1 is acc number of this user
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Acc Type: {accDetails[i+1][0]}");
                    Console.WriteLine($"Balance: {accDetails[i+1][1]}");
                    Console.WriteLine($"Branch City: {accDetails[i+1][2]}\n");
                }
            }
            break;
        case "3":
            Console.WriteLine("*****Summary*****");
            Console.WriteLine($"Tot acc: {accNo}");
            Console.WriteLine($"Tot Savings acc: {savingsAcc}");
            Console.WriteLine($"Tot Current acc: {currAcc}");
            Console.WriteLine($"Tot Balance: {totBalance}");
            break;
        case "4":
            flg = false;
            break;
        default:
            Console.WriteLine("Invalid Input.\n");
            break;
    }
    
}
