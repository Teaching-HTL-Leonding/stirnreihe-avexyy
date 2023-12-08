using Stirnreihe.Data;
System.Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?");
System.Console.WriteLine("1) Add a person to the line");
System.Console.WriteLine("2) Print the line");
System.Console.WriteLine("3) Clear the line");
System.Console.WriteLine("4) Exit");
System.Console.Write("Your choice: ");
var input = Console.ReadLine()!;

LineOfPeople lineOfPeople = new LineOfPeople(); // creating an instance of the LineOfPeople class to manage people in a line

while (input != "4")
{
    switch (input)
    {
        case "1":
            var p = new Person(); // creating a new Person object

            Console.Write($"First Name: ");
            string firstName = Console.ReadLine()!;

            Console.Write($"Last Name: "); 
            string lastName = Console.ReadLine()!;

            Console.Write($"Height in cm: ");
            int height = int.Parse(Console.ReadLine()!);
            
            p.FirstName = firstName; // setting the properties of the Person object
            p.LastName = lastName;
            p.Height = height;

            lineOfPeople.AddToFront(p); // adding the created person to the front of the line
            break;

        case "2": // if user chooses option 2 - print the line
            var current = lineOfPeople.First; // getting the reference to the first node in the line

            while (current != null)
            {
                Console.WriteLine(current.Person);
                current = current.Next; // moving to the next node in the line
            }
            break;

        case "3": // if user chooses option 3 - clear the line
            lineOfPeople.Clear(); // clears all people from the line
            break;
    }

    Console.Write($"Your Choice: ");
    input = Console.ReadLine();
}