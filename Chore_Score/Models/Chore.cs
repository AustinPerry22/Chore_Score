namespace Chore_Score.Models;

public class Chore
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }

    public Chore(int id, string title, string description, bool completed)
    {
        Id = id;
        Title = title;
        Description = description;
        Completed = completed;
    }
}