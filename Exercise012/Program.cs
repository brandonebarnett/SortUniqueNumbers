/* Write a program to ask the user to enter 5 numbers.
 * If a number has been previously entered, display an error message that asks the user to try again.
   Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/

List<int> numbers = new List<int>();

while (numbers.Count < 5)
{
    Console.WriteLine("Please enter a unique number.");
    int userInput = Convert.ToInt32(Console.ReadLine());

    if (numbers.Contains(userInput))
    {
        Console.WriteLine("You have already entered that value.  Please try again.");
        continue;
    }
    numbers.Add(userInput);
}
numbers.Sort();


Console.WriteLine(@"You successfully entered 5 unique values: {0}.", string.Join(", ", numbers));