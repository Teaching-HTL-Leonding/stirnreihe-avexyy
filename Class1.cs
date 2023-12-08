namespace Stirnreihe.Data;

// person with FirstName, LastName, and Height properties
public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Height { get; set; }

    // overrides the ToString() method
    public override string ToString()
    {
        return $"{FirstName}, {LastName} ({Height}cm)";
    }
}

// node that contains a Person object and a reference to the next Node
public class Node
{
    public Person? Person { get; set; }
    public Node? Next { get; set; }
}

public class LineOfPeople
{
    public Node? First { get; set; } = null;

    // adds a person to the front of the line
    public void AddToFront(Person person)
    {
        var temp = First;  // stores the reference to the current first node
        First = new Node();  // creates a new node for the new person
        First.Person = person;  // sets the Person property of the new node
        First.Next = temp;  // sets the next node to the previous first node
    }

    // clears the entire line of people
    public void Clear()
    {
        while (First != null)
        {
            var temp = First;  // stores the reference to the current first node
            First = First.Next;  // moves the first reference to the next node
            temp.Next = null;  // unlinks the current node from the rest of the list
        }
    }
}