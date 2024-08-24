// Global variables declaration here  ... 
bool isAsking = false;
List<string> toDoDocuments = new List<string>();


do
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    Console.WriteLine(" ");
    var userInput = Console.ReadLine();
  

  switch (userInput)
  {

    case "S":
    case "s":
        // code goes here
        SeeAppApplicationTodos();
        break;
    case "A":
    case "a":
        //code goes here
        AddApplicationTodos();
        break;
    case "R":
    case "r":
        //code goes here
        RemoveToDoByIndex();
        break;

    case "E":
    case "e":
    case "":
        isAsking = true;
        break;

    
    default:
    Console.WriteLine("Invalid Input Please Select One ..");
    break;
  }

}while(isAsking == false);




// main application flow here

/* See all todo's documents in our application */
void SeeAppApplicationTodos()
{
    Console.WriteLine("==== LIST OF ALL TODOS ====");
   
    if(toDoDocuments.Count > 0)
    {
        
        for(int i = 0; i < toDoDocuments.Count ; i++)
        {
            

            Console.WriteLine(" ");

            Console.WriteLine($"[{i + 1}] - {toDoDocuments[i]}");
        

        }
            Console.WriteLine($"TOTAL :- {toDoDocuments.Count}");

    }else{

        Console.WriteLine("\t");
        Console.WriteLine(" (EMPTY) No TODOs have been added yet (EMPTY)");
        Console.WriteLine("\t");

    }


}

/* Add new books in our todo's application */
void AddApplicationTodos()
{
    bool continueAsking = false;
    do
    {
        // ask user to input a todo here
        Console.WriteLine("Enter the TODO description");
        
    string? toDoInputFromUser = Console.ReadLine();
    //
    if(toDoInputFromUser!.Length > 0)
    {
        if(toDoDocuments.Contains(toDoInputFromUser))
        {
            Console.WriteLine(" \t");
            Console.WriteLine("The description must be unique.");
            Console.WriteLine("Already Exist");
            Console.WriteLine(" \t");
            break; 
        }
            continueAsking = true;
            toDoDocuments.Add(toDoInputFromUser!);
            Console.WriteLine("TODOs Added Successfully Well Done");
    }
    else
    {
        Console.WriteLine("Sorry but Field cannot be empty");
    }

    }while(continueAsking == false);




}



/* Remove a new toDo */
void RemoveToDoByIndex()
{
   
    SeeAppApplicationTodos();

    bool userChoice;
    do
    {

    // REMOVING THE SELECTED TODOs
    Console.WriteLine("Select the index of the TODO you want to remove:");
    var input = Console.ReadLine();
    userChoice = int.TryParse(input, out int value);
    if(userChoice)
    {
        if(value <= toDoDocuments.Count)
        {
            int indexOf = value - 1;
              toDoDocuments.RemoveAt(indexOf);
              Console.WriteLine($"Value removed successfully!");
        }else
        {
            Console.WriteLine("Sorry but selected index it out of range to be process..");
        }
      
    }else
    {
        Console.WriteLine("Selected choice is wrong");
    }

    }while(!userChoice);
}





/* ==== small notics ==== */

/*
Hello!
What do you want to do?
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit

*/