[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{

    private readonly ChoresService _choresService;
    public ChoresController(ChoresService cs)
    {
        _choresService = cs;
    }

    [HttpGet("test")]
    public string GetTest()
    {
        return "working";
    }

    [HttpGet]
    public ActionResult<List<Chore>> GetChores()
    {
        try
        {
            List<Chore> chores = _choresService.GetChores();
            return Ok(chores);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{choreId}")]
    public ActionResult<Chore> GetChoreById(int choreId)
    {
        try
        {
            Chore chore = _choresService.GetChoreById(choreId);
            return Ok(chore);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _choresService.CreateChore(choreData);
            return Ok(chore);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpDelete("{choreId}")]
    public ActionResult<string> DeleteChore(int choreId)
    {
        try
        {
            string message = _choresService.DeleteChore(choreId);
            return Ok(message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}