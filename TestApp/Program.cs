// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, Ricardo!");

string firstFriend = "Maria";

firstFriend = firstFriend.Trim();

string secondFriend = "Sage";

string friends = $"My friends are {firstFriend} and {secondFriend}";

Console.WriteLine(friends.Contains("Sage")); */

/*int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c); */

/*int a = 210000000;
int b = 210000000;
long c = checked(a + b);
Console.WriteLine(c); */

/*decimal a = 42.1M; // explicit type
decimal b = 38.2M;
decimal c = a + b;
Console.WriteLine($"The answer is {c}"); */



        /*if ((a + b) > 10)
        {
            Console.WriteLine("The answer is greater than 10.");
        }
        else //otherwise
        {
            Console.WriteLine("The answer is less than 10.");
        } */

        /*if ((a + b +c > 10) && (a == b))
        {
            Console.WriteLine("The answer is greater than 10.");
            Console.WriteLine("And the first number is equal to the second.");
        }
        else //otherwise
        {
            Console.WriteLine("The answer is less than 10.");
            Console.WriteLine("or the first number is not equal to the second.");
        } */

        /*int counter = 10;
        do

        {
            Console.WriteLine(counter);
            counter++;
        }
        while (counter < 5); */
    
       /* for (
             int i = 0;  //initialize (start)
             i < 5;   //conditional
             i++)  //iteration (increment)
        {
            //DO A THING
            Console.WriteLine(i);
        } */

        /*for (
             int i = 0;  //initialize (start)
             i < 5;   //conditional
             i++)  //iteration (increment)
        {
            if (i == 3)
            {
            //DO A THING
            Console.WriteLine(i);
            }
        } */

/*var names = new List<string> {"Ricardo", "Ana", "Felipe"};

names.Add("Maria");
names.Add("Sage");

// foreach (var name in names)
// {
// Console.WriteLine($"Hello {name.ToUpper()}!");
// }
Console.WriteLine(names[0]);
Conso le.WriteLine(names[2]);
Console.WriteLine(names[names.Count-1]);
*/

var names = new string[] { "Scott", "Anna", "Felipe" };

// names.Add("Damian");  // List <t>

names = [..names,"Damian"];

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

    