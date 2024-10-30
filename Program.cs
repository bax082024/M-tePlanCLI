namespace MøtePlanleggerClI;
using System;
using System.Text.Json;
using MøtePlanleggerClI.Models;

class Program
{
  static void Main(string[] args)
  {
    MeetingPlanner planner = new MeetingPlanner();
    
    Console.WriteLine("Enter meeting title");
    string? title = Console.ReadLine();
    title ??= "Untitled";

    DateTime time;
    Console.WriteLine("Enter Meeting date and time (yyyy-MM-dd HH:mm)");
    while (!DateTime.TryParse(Console.ReadLine(), out time))
    {
      Console.WriteLine("Invalid format, try again");
    }
    
    Meeting meeting = new Meeting(title, time);

    int personCount;
    Console.WriteLine("Enter how many people!");
    while (!int.TryParse(Console.ReadLine(), out personCount) || personCount < 1)
    {
      Console.WriteLine("Invalid number! try again.");
    }

    for (int i = 0; i < personCount; i++)
    {
      Console.Write($"Enter Person`s name {i + 1}: ");
      string? personName = Console.ReadLine();
      personName ??= $"Person_{i + 1}";
      meeting.AddPerson(new Person(personName));
    }
    planner.ScheduleMeeting(meeting);
      
      
  }

    
}
