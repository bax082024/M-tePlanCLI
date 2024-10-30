using System.Text.Json;

public class Meeting
{
  public string? Title { get; set; }
  public DateTime Time { get; set; }
  public List<Person> Persons { get; private set;}

  public Meeting(string title, DateTime time)
  {
    Title = title; 
    Time = time;
    Persons = new List<Person>();
  }

  public void AddPerson(Person person)
  {
    Persons.Add(person);
  }

  public void LogMeeting()
  {
    string log = JsonSerializer.Serialize(this);
    File.WriteAllText($"Meeting_{Title}_{Time.ToString("yyyyMMddHHmm")}.json", log);
  }
}