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
    }
  }
}