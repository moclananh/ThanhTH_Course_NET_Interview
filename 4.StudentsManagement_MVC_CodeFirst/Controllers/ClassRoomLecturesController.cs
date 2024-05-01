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
    public class ClassRoomLecturesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassRoomLecturesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClassRoomLectures
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ClassRoomLectures.Include(c => c.ClassRoom).Include(c => c.Lecture);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ClassRoomLectures/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRoomLectures = await _context.ClassRoomLectures
                .Include(c => c.ClassRoom)
                .Include(c => c.Lecture)
                .FirstOrDefaultAsync(m => m.ClassId == id);
            if (classRoomLectures == null)
            {
                return NotFound();
            }

            return View(classRoomLectures);
        }

        // GET: ClassRoomLectures/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.ClassRooms, "ClassId", "ClassId");
            ViewData["LectureId"] = new SelectList(_context.Lectures, "Id", "Id");
            return View();
        }

        // POST: ClassRoomLectures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassId,LectureId")] ClassRoomLectures classRoomLectures)
        {
            if (ModelState.IsValid)
            {
                string classId = HttpContext.Session.GetString("ClassId");
                classRoomLectures.ClassId = classId;
                _context.Add(classRoomLectures);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "ClassRoomStudents");
            }
            ViewData["ClassId"] = new SelectList(_context.ClassRooms, "ClassId", "ClassId", classRoomLectures.ClassId);
            ViewData["LectureId"] = new SelectList(_context.Lectures, "Id", "Id", classRoomLectures.LectureId);
            return View(classRoomLectures);
        }
        // GET: ClassRoomLectures/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRoomLectures = await _context.ClassRoomLectures.FindAsync(id);
            if (classRoomLectures == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.ClassRooms, "ClassId", "ClassId", classRoomLectures.ClassId);
            ViewData["LectureId"] = new SelectList(_context.Lectures, "Id", "Id", classRoomLectures.LectureId);
            return View(classRoomLectures);
        }

        // POST: ClassRoomLectures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ClassId,LectureId")] ClassRoomLectures classRoomLectures)
        {
            if (id != classRoomLectures.ClassId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classRoomLectures);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassRoomLecturesExists(classRoomLectures.ClassId))
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
            ViewData["ClassId"] = new SelectList(_context.ClassRooms, "ClassId", "ClassId", classRoomLectures.ClassId);
            ViewData["LectureId"] = new SelectList(_context.Lectures, "Id", "Id", classRoomLectures.LectureId);
            return View(classRoomLectures);
        }

        // GET: ClassRoomLectures/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var classRoomLectures = await _context.ClassRoomLectures
                .Include(c => c.ClassRoom)
                .Include(c => c.Lecture)
                .FirstOrDefaultAsync(m => m.ClassId == id);
            if (classRoomLectures == null)
            {
                return NotFound();
            }

            return View(classRoomLectures);
        }

        // POST: ClassRoomLectures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var classRoomLectures = await _context.ClassRoomLectures.FindAsync(id);
            _context.ClassRoomLectures.Remove(classRoomLectures);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassRoomLecturesExists(string id)
        {
            return _context.ClassRoomLectures.Any(e => e.ClassId == id);
        }
    }
}
