﻿void Main()
{
    string userInput;
    do
    {
        Console.WriteLine("QuikTrip Management Systems");
        Console.WriteLine();
        Console.WriteLine(@"
    1. Enter District Sales
    2. Generate District Report
    3. Add New Employee
    4. Add a Store/District
    5. Exit");

        userInput = Console.ReadLine();
    } while (userInput != "5");
};
Main();
