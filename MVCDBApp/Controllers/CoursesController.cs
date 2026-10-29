
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcDBApp.Models;


[ApiController]
[Route("[controller]")]
public class CoursesController : Controller
{
    private readonly MVCDBAppContext _context;

    public CoursesController(MVCDBAppContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetStudents()
    {
        return Ok(_context.Student.ToList());
    }
}
