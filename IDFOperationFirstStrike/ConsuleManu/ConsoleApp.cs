using System;
using System.Collections.Generic;
using IDFOperationFirstStrike.AMAN;
using IDFOperationFirstStrike.HAMAS;
using IDFOperationFirstStrike.IDF;

public class CommanderConsole
{
    private AMAN aman;
    private List<Strike> strikeUnits;
    private string officerName;

    public CommanderConsole(AMAN aman, List<Strike> strikeUnits, string officerName)
    {
        this.aman = aman;
        this.strikeUnits = strikeUnits;
        this.officerName = officerName;
    }

    public void Run()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Commander Console ---");
            Console.WriteLine("1. Intel Analysis");
            Console.WriteLine("2. Strike Availability");
            Console.WriteLine("3. Target Prioritization");
            Console.WriteLine("4. Execute Strike");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    aman.PrintMostReportedTerrorist();
                    break;

                case "2":
                    ShowStrikeAvailability();
                    break;

                case "3":
                    ShowTargetDetails();
                    break;

                case "4":
                    ExecuteStrike();
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    // הפונקציות ShowStrikeAvailability, ShowTargetDetails, ExecuteStrike יתווספו בהמשך
}