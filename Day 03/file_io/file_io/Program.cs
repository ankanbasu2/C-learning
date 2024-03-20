using System.IO;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//FileStream myFile = new FileStream("info.txt", FileMode.CreateNew, FileAccess.Write);
//StreamWriter myPen = new StreamWriter(myFile);

//myPen.WriteLine("Hello and welcome to my intro.");
//myPen.WriteLine("My name is Naruto.");
//myPen.WriteLine("I live in Konoha Village.");
//myPen.WriteLine("I am Hokage.");
//myPen.WriteLine("Thank You.");

//myPen.Close();
//myFile.Close();

#region file_write2
//string name, city, movie, food, sports;

//Console.Write("Enter you name: ");
//name = Console.ReadLine();

//Console.WriteLine("Welcome, " + name + "\nPls enter the following details.");

//FileStream myFile = new FileStream(name+"_info.txt", FileMode.Create, FileAccess.Write);
//StreamWriter myWriter = new StreamWriter(myFile);

//myWriter.WriteLine("Name: " + name);

//Console.WriteLine("Pls enter your city: ");
//city = Console.ReadLine();
//myWriter.WriteLine("City: " + city);

//Console.WriteLine("Pls enter your favourite movie: ");
//movie = Console.ReadLine();
//myWriter.WriteLine("Movie: " + movie);

//Console.WriteLine("Pls enter your favourite food: ");
//food = Console.ReadLine();
//myWriter.WriteLine("Food: " + food);


//Console.WriteLine("Pls enter your favourite sports: ");
//sports = Console.ReadLine();
//myWriter.WriteLine("Sports: " + sports);

//myWriter.Close();
//myFile.Close();

//Console.WriteLine("Thank you, " + name + ", for the details.");
#endregion

#region file_read
//Console.Write("Welcome to EMS.\nPress ENTER to Login:");

//Console.Write("Enter uname: ");
//unameEntered = Console.ReadLine();

//Console.Write("Enter password: ");
//passwdEntered = Console.ReadLine();

//if (unameEntered == null || passwdEntered == null)
//{

//}
#endregion

#region file_read_write
string fileName = "autonumber.txt";
int val;

if (File.Exists(fileName))
{
    // read no. increment. write back.
    FileStream myFile = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
    
    StreamReader reader = new StreamReader(myFile);
    val = Convert.ToInt32(reader.ReadLine());
    reader.Close();
    Console.WriteLine($"Value read: {val}");
   
    val++;

    StreamWriter writer = new StreamWriter(fileName);
    writer.WriteLine(val);
    writer.Close();
    Console.WriteLine($"Value written: {val}");

    myFile.Close();
} else
{
    // create file. write default val 1
    FileStream myFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);

    StreamWriter writer = new StreamWriter(fileName);
    writer.WriteLine("1");
    writer.Close();

    myFile.Close();

    Console.WriteLine($"File \'{fileName}\' created with default value \'1\'");
}
#endregion