using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using A_Manager.Data;
using A_Manager.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A_Manager.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseConnectionClass _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public UserController(DatabaseConnectionClass context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
              return _context.Users != null ? 
                          View(await _context.Users.ToListAsync()) :
                          Problem("Entity set 'DatabaseConnectionClass.Users'  is null.");
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,email,password,full_name,local_full_name,gender,mobile,telphone,badge_number,job_title,join_date,nationality,gov_id,brith_date,profile_photo,profile_photo_url,is_active,is_employee,is_superuser")] User user)
        {
            if (ModelState.IsValid)
            {
                if(user.profile_photo!=null)
                {
                    //Save image to wwwroot/upload/<user email>/image.jpg

                    

                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(user.profile_photo.FileName);
                    string extension = Path.GetExtension(user.profile_photo.FileName);

                    user.profile_photo_url = fileName+DateTime.Now.ToString("yymmssfff") + extension;

                    string path = Path.Combine(wwwRootPath + "/upload/"+user.email+"/", user.profile_photo_url);

                    bool exists = System.IO.Directory.Exists(wwwRootPath + "/upload/" + user.email + "/");
                    if (!exists)
                    {
                        System.IO.Directory.CreateDirectory(wwwRootPath + "/upload/" + user.email + "/");
                    }

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await user.profile_photo.CopyToAsync(fileStream);
                    }
                }
               


                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,email,password,full_name,local_full_name,gender,mobile,telphone,badge_number,job_title,join_date,nationality,gov_id,brith_date,profile_photo,profile_photo_url,is_active,is_employee,is_superuser")] User user)
        {
            if (id != user.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (user.profile_photo != null)
                    {
                        //Save image to wwwroot/upload/<user_id>/image.jpg
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(user.profile_photo.FileName);
                        string extension = Path.GetExtension(user.profile_photo.FileName);

                        user.profile_photo_url = fileName + DateTime.Now.ToString("yymmssfff") + extension;

                        string path = Path.Combine(wwwRootPath + "/upload/" + user.email + "/", user.profile_photo_url);

                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await user.profile_photo.CopyToAsync(fileStream);
                        }
                    }




                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.id))
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
            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'DatabaseConnectionClass.Users'  is null.");
            }
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
          return (_context.Users?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
