using System.Text.Json;
using MøtePlanleggerClI.Models;
public class Meeting
{
  public int Id { get; set;}
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

  /* Json storage
  
  public void LogMeeting()
  {
    string sanitizedTitle = string.Join("_", (Title ?? "Untitled").Split(Path.GetInvalidFileNameChars()));
    string log = JsonSerializer.Serialize(this);
    File.WriteAllText($"Meeting_{sanitizedTitle}_{Time:yyyyMMddHHmm}.json", log);
  }*/
}