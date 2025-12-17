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

/* var names = new string[] { "Scott", "Anna", "Felipe" };

// names.Add("Damian");  // List <t>

names = [..names,"Damian"];

foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}  */

/* var numbers = new List<int> { 35,36,17,16,15 };
Console.WriteLine($"I found 99 at Index {numbers.IndexOf(99)}");

numbers.Sort();
Console.WriteLine($"I found 99 at Index {numbers.IndexOf(99)}"); */

// foreach (var number in numbers)
// {
//     Console.WriteLine($"Hello {number}!");
// }

// Specify the data source

/*List<int> scores = [97, 92, 81, 60];

for (int i = 0; i < scores.Count; i++)
{
    if (scores[i] > 80)
    {
        Console.WriteLine($"Found a score over 80 {scores[i]}");
    }
}

return; */

// Specify the data source

/* List<int> scores = [97, 92, 81, 60];



IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.

foreach (int i in scoreQuery)
{
   
    Console.Write(i + " ");
    
} */

// Specify the data source

/*List<int> scores = [3, 25, 82, 97, 92, 100, 81, 60];

//Define the query expresion

IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is {score}";

// Execute the query.    
foreach (string s in scoreQuery)
{
    Console.WriteLine(s);
} */

/*
List<int> scores = [3, 25, 82, 97, 92, 100, 81, 60];

IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

var scoreQuery2 = scores.Where(s => s > 80).
             OrderByDescending(s => s);
 */

 Console.WriteLine("Hi OOP!");    

// instances of Person
var p1 = new Person("Amadeus", "Mozart", new DateOnly(1980, 5, 15));
var p2 = new Person("Frederic", "Chopin", new DateOnly(1980, 5, 15));
var p3 = new Person("Johann", "Bach", new DateOnly(1980, 5, 15));

List<Person> people = [p1, p2, p3];

Console.WriteLine(people.Count);

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string first { get; } = firstname;
    public string last { get; } = lastname;        

    public DateOnly birthday { get; } = birthday;
}