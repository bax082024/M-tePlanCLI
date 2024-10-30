public class MeetingPlanner
{
  private List<Meeting> Meetings { get; set; } = new List<Meeting>();

  public void ScheduleMeeting(Meeting meeting)
  {
    Meetings.Add(meeting);
    meeting.LogMeeting();
    Console.WriteLine("Meeting is saved");
  }
}