using System;

/* lambda function = function written in 1 line using lambda keyword
 *                   accepts any number of argument, but only has one expression
 *                   (think of it as a shortcut)
 *                   (useful if needed for a short period of time, throw-away)
 *                   (input-parameters) => expression
 */

// list to store numbers 
List<int> numbers = new List<int>() { 1, 3, 5, 7, 9, 11, 13 };

// foreach loop to display the list 
Console.Write("The list : ");
foreach (var value in numbers)
{
    Console.Write("{0} ", value);
}
Console.WriteLine();

/* using lambda expression
 * to calculate the square 
 * of each value in the list
 */
var square = numbers.Select(x => x * x);

// foreach loop to display squares
Console.Write("Squares : ");
foreach (var value in square)
{
    Console.Write("{0} ", value);
}
Console.WriteLine();

/* use lambda expression to 
 * find all numbers in the list 
 * divisible by 3
 */
List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

// foreach loop to display divBy3
Console.Write("Numbers Divisible by 3 : ");
foreach (var value in numbers)
{
    Console.Write("{0} ", value);
}
Console.WriteLine();
