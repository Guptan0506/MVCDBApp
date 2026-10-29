
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCDBApp.Models;

[ApiController]
[Route("[controller]")]
public class StudentsController : Controller
{
    private readonly MVCDBAppContext _context;

    public StudentsController(MVCDBAppContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetStudents()
    {
        return Ok(_context.Student.ToList());
    }

}