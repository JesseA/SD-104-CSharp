using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Question1.Data;
using Final_Question1.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Final_Question1.Controllers
{
    public class PassengersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PassengersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Passengers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Passengers.ToListAsync());
        }
        public async Task<IActionResult> PassengerList(string searchTerm)
        {
            var passengers = from m in _context.Passengers select m;
            if(!String.IsNullOrEmpty(searchTerm))
            {
                passengers = passengers.Where(s => ((s.FirstName+" "+s.LastName+" "+s.SeatPreference+" "+s.RewardNumber).Contains(searchTerm)));
            }
            ViewBag.searchTerm = searchTerm;
            return View(await passengers.ToListAsync());
        }

        // GET: Passengers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passengers = await _context.Passengers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passengers == null)
            {
                return NotFound();
            }

            return View(passengers);
        }

        // GET: Passengers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Passengers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,SeatPreference,RewardNumber,DiscountPercentage")] Passengers passengers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(passengers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(passengers);
        }

        // GET: Passengers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passengers = await _context.Passengers.FindAsync(id);
            if (passengers == null)
            {
                return NotFound();
            }
            return View(passengers);
        }

        // POST: Passengers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,SeatPreference,RewardNumber,DiscountPercentage")] Passengers passengers)
        {
            if (id != passengers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(passengers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PassengersExists(passengers.Id))
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
            return View(passengers);
        }

        // GET: Passengers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var passengers = await _context.Passengers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (passengers == null)
            {
                return NotFound();
            }

            return View(passengers);
        }

        // POST: Passengers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var passengers = await _context.Passengers.FindAsync(id);
            _context.Passengers.Remove(passengers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PassengersExists(int id)
        {
            return _context.Passengers.Any(e => e.Id == id);
        }
    }
}
