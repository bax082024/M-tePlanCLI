using Microsoft.EntityFrameworkCore;
using MøtePlanleggerClI.Models;

public class MeetingPlanner
{
  private List<Meeting> Meetings { get; set; } = new List<Meeting>();

  public void ScheduleMeeting(Meeting meeting)
  {
    Meetings.Add(meeting);
    meeting.LogMeeting();
    Console.WriteLine("Meeting is saved");
  }

  public void DisplayMeetings()
  {
    using (var context = new MeetingContext())
    {
      var meetings = context.Meetings
        .Include(m => m.Persons)
        .ToList();

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