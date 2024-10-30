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
      string? title = Console.ReadLine() ?? "Untitled";

      Console.WriteLine("Enter Meeting date and time (yyyy-MM-dd HH:mm)");
      DateTime time;
      while (!DateTime.TryParse(Console.ReadLine(), out time))
      {
        Console.WriteLine("Invalid format, please try again");
      }

      Meeting meeting = new Meeting(title, time);

      Console.WriteLine("Enter how many people?: ");
      int personCount;
      while (!int.TryParse(Console.ReadLine(), out personCount) || personCount < 1)
      {
        Console.WriteLine("Invalid Number. Please try again");
      }

      for (int i = 0; i < personCount; i++)
      {
        Console.Write($"Enter Person`s name {i + 1}: ");
        string? personName = Console.ReadLine() ?? $"Person_{i + 1}";
        meeting.AddPerson(new Person(personName));
      }

      planner.ScheduleMeeting(meeting);
    }
    else if (choice == "2")
    {
      planner.DisplayMeetings();
    }
    else
    {
      Console.WriteLine("Invalid choice");
    }
      
      
  }

    
}
