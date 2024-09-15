using DataTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataTask.Controllers
{
    // Bu Route ile StudentController'ın rotalarını yapılandırıyoruz
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Index action'ı öğrencileri sınıf bilgisiyle birlikte çekiyor
        [HttpGet]
        public IActionResult Index()
        {
            var students = _context.Students.Include(s => s.Class).ToList();
            return View(students);
        }


        // Yeni öğrenci ekleme sayfası
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Yeni öğrenci ekleme işlemi POST metodu ile yapılacak
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}
