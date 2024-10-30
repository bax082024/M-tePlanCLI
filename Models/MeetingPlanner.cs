using Azure.Core.Pipeline;
using Microsoft.EntityFrameworkCore;
using MøtePlanleggerClI.Models;

public class MeetingPlanner
{
  private List<Meeting> Meetings { get; set; } = new List<Meeting>();

  public void ScheduleMeeting(Meeting meeting)
{
  using (var context = new MeetingContext())
  {
    context.Meetings.Add(meeting);
    context.SaveChanges();
  }

  Console.WriteLine("Meeting is saved to SQL database.");
}
  

  public void DisplayMeetings()
  {
    using (var context = new MeetingContext())
    {
      var meetings = context.Meetings
        .Include(m => m.Persons)
        .ToList();

      if (meetings.Count == 0)
      {
        Console.WriteLine("No meetings found.");
        return;
      }

      foreach (var meeting in meetings)
      {
        Console.WriteLine($"Meeting: {meeting.Title} at {meeting.Time}");
        Console.WriteLine("Participants: ");
        foreach (var person in meeting.Persons)
        {
          Console.WriteLine($"- {person.Name}");
        }
        Console.WriteLine();
      }

    } 

  }
}