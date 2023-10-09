using Chore_Score.Models;
namespace Chore_Score.Services;

public class ChoresService
{
    private readonly ChoresRepository _repo;
    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    internal List<Chore> GetChores()
    {
        List<Chore> chores = _repo.GetAllChores();
        return chores;
    }

    internal Chore GetChoreById(int choreId)
    {
        Chore chore = _repo.GetChoreById(choreId);
        if (chore == null) throw new Exception($"no chore with id of {choreId}");
        return chore;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }

    internal string DeleteChore(int choreId)
    {
        string message = _repo.DeleteChore(choreId);
        return message;
    }

}