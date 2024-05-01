using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _4.StudentsManagement_MVC_CodeFirst.DataAccess;
using _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities;
using Microsoft.AspNetCore.Http;

namespace _4.StudentsManagement_MVC_CodeFirst.Controllers
{
    public class ClassRoomStudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassRoomStudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClassRoomStudents
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ClassRoomStudents.Include(c => c.ClassRoom).Include(c => c.Student);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ClassRoomStudents/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRoomStudents = await _context.ClassRoomStudents
                .Include(c => c.ClassRoom)
                .Include(c => c.Student)
                .FirstOrDefaultAsync(m => m.ClassId == id);
            if (classRoomStudents == null)
            {
                return NotFound();
            }

            return View(classRoomStudents);
        }

        // GET: ClassRoomStudents/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.ClassRooms, "ClassId", "ClassId");
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id");
            return View();
        }

        // POST: ClassRoomStudents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassId,StudentId")] ClassRoomStudents classRoomStudents)
        {
            if (ModelState.IsValid)
            {
                string classId = HttpContext.Session.GetString("ClassId");
                classRoomStudents.ClassId = classId;
                _context.Add(classRoomStudents);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "ClassRooms");
            }
            ViewData["ClassId"] = new SelectList(_context.ClassRooms, "ClassId", "ClassId", classRoomStudents.ClassId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", classRoomStudents.StudentId);
            return View(classRoomStudents);
        }

        // GET: ClassRoomStudents/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRoomStudents = await _context.ClassRoomStudents.FindAsync(id);
            if (classRoomStudents == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.ClassRooms, "ClassId", "ClassId", classRoomStudents.ClassId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", classRoomStudents.StudentId);
            return View(classRoomStudents);
        }

        // POST: ClassRoomStudents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ClassId,StudentId")] ClassRoomStudents classRoomStudents)
        {
            if (id != classRoomStudents.ClassId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classRoomStudents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassRoomStudentsExists(classRoomStudents.ClassId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.ClassRooms, "ClassId", "ClassId", classRoomStudents.ClassId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", classRoomStudents.StudentId);
            return View(classRoomStudents);
        }

        // GET: ClassRoomStudents/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRoomStudents = await _context.ClassRoomStudents
                .Include(c => c.ClassRoom)
                .Include(c => c.Student)
                .FirstOrDefaultAsync(m => m.ClassId == id);
            if (classRoomStudents == null)
            {
                return NotFound();
            }

            return View(classRoomStudents);
        }

        // POST: ClassRoomStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var classRoomStudents = await _context.ClassRoomStudents.FindAsync(id);
            _context.ClassRoomStudents.Remove(classRoomStudents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassRoomStudentsExists(string id)
        {
            return _context.ClassRoomStudents.Any(e => e.ClassId == id);
        }
    }
}
