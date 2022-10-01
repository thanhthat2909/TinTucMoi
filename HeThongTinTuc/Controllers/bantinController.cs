using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HeThongTinTuc.Data;
using HeThongTinTuc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace HeThongTinTuc.Controllers
{
    [Authorize]
    public class bantinController : Controller
    {
        private readonly ApplicationDbContext _context;

        public bantinController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: bantin
        public async Task<IActionResult> Index(string Searching = "")
        {
            if (Searching == null)
            {
                return View(await _context.bantin.ToListAsync());
            }
            return View(await _context.bantin.Where(n => (n.tieude.Contains(Searching))).ToListAsync());
        }

        // GET: bantin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bantin = await _context.bantin
                .FirstOrDefaultAsync(m => m.bantinid == id);
            if (bantin == null)
            {
                return NotFound();
            }

            return View(bantin);
        }

        // GET: bantin/Create
        public IActionResult Create()
        {
            ViewData["chuyenmucid"] = new SelectList(_context.chuyenmuc, "chuyenmucid", "tenchuyenmuc");
            return View();
        }

        // POST: bantin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile file ,[Bind("bantinid,chuyenmucid,tieude,tomtat,noidung,ngaydang,nguoidang,hinhanh,tieudehinh,luotxem,noibat,kichhoat")] bantin bantin)
        {
            if (ModelState.IsValid)
            {
                bantin.hinhanh = Upload(file);
                _context.Add(bantin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bantin);
        }

        // GET: bantin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bantin = await _context.bantin.FindAsync(id);
            if (bantin == null)
            {
                return NotFound();
            }
            ViewData["chuyenmucid"] = new SelectList(_context.chuyenmuc, "chuyenmucid", "tenchuyenmuc", bantin.chuyenmucid);
            return View(bantin);
        }

        // POST: bantin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IFormFile file, int id, [Bind("bantinid,chuyenmucid,tieude,tomtat,noidung,ngaydang,nguoidang,hinhanh,tieudehinh,luotxem,noibat,kichhoat")] bantin bantin)
        {

            if (id != bantin.bantinid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (file != null)
                    {
                        bantin.hinhanh = Upload(file);
                    }
                    _context.Update(bantin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!bantinExists(bantin.bantinid))
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
            return View(bantin);
        }

        // GET: bantin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bantin = await _context.bantin
                .Include(b => b.chuyenmuc)
                .FirstOrDefaultAsync(m => m.bantinid == id);
            if (bantin == null)
            {
                return NotFound();
            }

            return View(bantin);
        }

        // POST: bantin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bantin = await _context.bantin.FindAsync(id);
            _context.bantin.Remove(bantin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool bantinExists(int id)
        {
            return _context.bantin.Any(e => e.bantinid == id);
        }

        public string Upload(IFormFile file)
        {
            string uploadFileName = null;
            if (file != null)
            {
                //Phát sinh tên
                uploadFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var path = $"wwwroot\\images\\{uploadFileName}";
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            return uploadFileName;
        }
    }
}
