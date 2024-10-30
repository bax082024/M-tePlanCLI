namespace MøtePlanleggerClI;
using System;
using System.Text.Json;
using MøtePlanleggerClI.Models;

class Program
{
  static void Main(string[] args)
  {
    MeetingPlanner planner = new MeetingPlanner();

    Console.WriteLine("Choose an option: ");
    Console.WriteLine("1. Schedule a new meeting");
    Console.WriteLine("2. Display all meetings");
    var choice = Console.ReadLine();
    
    if (choice == "1")
    {
      Console.WriteLine("Enter meeting title: ");
      string? title = Console.ReadLine();

      Console.WriteLine("Enter Meeting date and time (yyyy-MM-dd HH:mm)");
      DateTime time;
      while (!DateTime.TryParse(Console.ReadLine(), out time))
      {
        Console.WriteLine("Invalid format, please try again");
      }
    }
      
      
  }

    
}
