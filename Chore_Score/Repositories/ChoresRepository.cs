namespace Chore_Score.Repositories;

public class ChoresRepository
{
    private List<Chore> _FakeDb;

    public ChoresRepository()
    {
        _FakeDb = new List<Chore>();
        _FakeDb.Add(new Chore(1, "chore1", "just do it", false));
        _FakeDb.Add(new Chore(2, "chore2", "just do i", true));
        _FakeDb.Add(new Chore(3, "chore3", "just do", false));
        _FakeDb.Add(new Chore(4, "chore4", "just", true));

    }

    internal List<Chore> GetAllChores()
    {
        return _FakeDb;
    }

    internal Chore GetChoreById(int choreId)
    {
        Chore foundChore = _FakeDb.Find(c => c.Id == choreId);
        return foundChore;
    }

    internal Chore CreateChore(Chore choreData)
    {
        int choreId = _FakeDb[_FakeDb.Count - 1].Id;
        choreData.Id = choreId + 1;
        _FakeDb.Add(choreData);
        return choreData;
    }

    internal string DeleteChore(int choreId)
    {
        Chore chore = _FakeDb.Find(c => c.Id == choreId);
        _FakeDb.Remove(chore);
        return "chore deleted";
    }
}