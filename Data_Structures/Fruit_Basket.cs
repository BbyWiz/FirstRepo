/*
using System.Text;
using System.Linq;
/*
There is a grocery store located in your residential complex. 
You are required to develop a program to simulate a grocery store checkout system. 
The program allows the cashier to scan items, calculate the total price, and print out a receipt for the customer. 
Your task is to write a C# program that uses StringBuilder and code to concatenate multiple strings. 
The below prices can be used for reference:
Apple - $1.99, Banana - $2.49, Orange - $0.99, Peach - $1.29, Watermelon - $3.99
/*
/*
Define Item Prices  - Declare variables to store the prices of each item. 
Assign the respective prices to each item according to the provided reference. 
/*
Dictionary<string,decimal> fruits = new Dictionary<string, decimal>();
/*
Initialize Total Price - Declare a variable to store the total price of the items. Initialize it to 0. 
/*
decimal totalPrice = 0M;
/*
Create a Loop for Scanning Items - Create a loop that allows the cashier to scan multiple items. 
Prompt the cashier to enter the name of the scanned item. 
/*
bool limit = true;

while(limit)
{
    Console.WriteLine("Please enter the name of the scanned item");
    string chosenItem = Console.ReadLine().ToLower();
/*
Use a switch statement to match the scanned item and add its price to the total price variable. 
Repeat the loop until the cashier indicates that all items have been scanned
/*
    switch(chosenItem)
    {
        case"apple":
        Console.WriteLine($"Added {chosenItem}");
        fruits.Add("apple" , 1.99M);
        totalPrice += 1.99M;
        break;

        case"banana":
        fruits.Add("banana" , 2.49M);
        Console.WriteLine($"Added {chosenItem}");
        totalPrice += 2.49M;
        break;

        case"orange":
        fruits.Add("orange" , 0.99M);
        Console.WriteLine($"Added {chosenItem}");
        totalPrice += 0.99M;
        break;

        case"peach":
        fruits.Add("peach" , 1.29M);
        Console.WriteLine($"Added {chosenItem}");
        totalPrice += 1.29M;
        break;

        case"watermelon":
        fruits.Add("watermelon" , 3.99M);
        Console.WriteLine($"Added {chosenItem}");
        totalPrice += 3.99M;
        continue;

        default:
        Console.WriteLine("Rescan");
        break;

    }    
    
/* Calculate the Total Price - After scanning all the items, 
calculate the total price by adding up the prices of the scanned items.
/*
/* Print the Receipt - Use a StringBuilder object to create the receipt string. 
Append the scanned items and their prices to the StringBuilder object. 
Concatenate the total price to the receipt string. Print the receipt using the Console.WriteLine method.
/*
DateTime today = DateTime.Now;
StringBuilder stringBuilding = new StringBuilder();
//fruits is Dict
stringBuilding.AppendLine($"*******************************************************************************");
stringBuilding.AppendLine($"*       THANKS FOR SHOPPING AT BBYWIZ MART   {today}                          *");
foreach(var fruit in fruits.Keys)
{
stringBuilding.AppendLine($"*                {fruit}                                                    *");    
}
stringBuilding.AppendLine($"*     \tTotal:    ${totalPrice:0.00}                                          *");
stringBuilding.AppendLine($"*******************************************************************************");

Console.WriteLine(stringBuilding);
Console.ReadLine();

/*Run the Program - Put all the code together in the Main method. 
Run the program and simulate the grocery store checkout by scanning various items. 
Verify that the program correctly calculates the total price and prints the receipt.
/*   
}
*/