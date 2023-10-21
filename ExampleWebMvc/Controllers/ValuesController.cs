using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebMvc.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{
    static List<string> todos = new() { "Taner", "Saydam", "Deneme" };
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(todos);
    }

    [HttpGet("{work}")]
    public IActionResult Create(string work)
    {
        todos.Add(work);
        return NoContent();
    }

    [HttpGet("{index}/{work}")]
    public IActionResult Update(int index, string work)
    {
        todos.Remove(todos[index]);
        todos.Add(work);
        return NoContent();
    }

    [HttpGet("{index}")]
    public IActionResult RemoveByIndex(int index)
    {
        todos.Remove(todos[index]);
        return NoContent();
    }
    
}
