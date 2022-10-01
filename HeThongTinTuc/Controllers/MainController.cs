using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HeThongTinTuc.Data;
using HeThongTinTuc.Models;

namespace HeThongTinTuc.Controllers
{
    public class MainController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MainController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Main
        public async Task<IActionResult> Index()
        {
            var dschyenmuc = await _context.chuyenmuc.ToListAsync();
            ViewBag.chuyenmuc = dschyenmuc;

            var dsbantin = await _context.bantin.ToListAsync();
            ViewBag.bantin = dsbantin;

            var applicationDbContext = _context.bantin.Include(b => b.chuyenmuc);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> NewsIndex()
        {
            var dschyenmuc = await _context.chuyenmuc.ToListAsync();
            ViewBag.chuyenmuc = dschyenmuc;

            var dsbantin = await _context.bantin.ToListAsync();
            ViewBag.bantin = dsbantin;

            var applicationDbContext = _context.bantin.Include(b => b.chuyenmuc);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Main/Details/5
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

       
    }
}
