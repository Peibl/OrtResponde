
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrtResponde.Data;
using OrtResponde.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OrtResponde.Controllers
{
    public class LikesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LikesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Likes
        public async Task<IActionResult> Index(String id)
        {
            if (id == null)
            {
                return View(await _context.Like.Include(a => a.Question).ToListAsync());

            }
            return View(await _context.Like.Where(q => q.UserId == id).ToListAsync());

        }
        // GET: Likes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var like = await _context.Like
                .FirstOrDefaultAsync(m => m.Id == id);
            if (like == null)
            {
                return NotFound();
            }

            return View(like);
        }

        public async Task<IActionResult> Create(Like like, String url)

        {
            if (like.UserId == null) {
                ModelState.AddModelError("not_login", "Debes estar logueado para poder dar Like");
            }

           if (ModelState.IsValid)
            {
                like.LikeType = !like.LikeType;
                _context.Add(like);
                await _context.SaveChangesAsync();
                return Redirect(url);
            }
            return Redirect(url);
        }

        // GET: Likes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var like = await _context.Like.FindAsync(id);
            if (like == null)
            {
                return NotFound();
            }
            return View(like);
        }

        // POST: Likes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,LikeType,LikedDate")] Like like)
        {
            if (id != like.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(like);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LikeExists(like.Id))
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
            return View(like);
        }

        // GET: Likes/Delete/5
        public async Task<IActionResult> Delete(int? id, String url)
        {
            if (id == null)
            {
                return NotFound();
            }

            var like = await _context.Like
                .FirstOrDefaultAsync(m => m.Id == id);
            if (like == null)
            {
                return NotFound();
            }
            like.LikeType = false;
            _context.Like.Add(like);
            await _context.SaveChangesAsync();
            return Redirect(url);
        }

        // POST: Likes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, String url)
        {
            var like = await _context.Like.FindAsync(id);
            _context.Like.Remove(like);
            await _context.SaveChangesAsync();
             return Redirect(url);
        }

        private bool LikeExists(int id)
        {
            return _context.Like.Any(e => e.Id == id);
        }
    }
}
