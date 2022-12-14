using A_Manager.Data;
using A_Manager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace A_Manager.Controllers
{
    public class CarController : Controller
    {
        private readonly DatabaseConnectionClass _context;


        public CarController(DatabaseConnectionClass context)
        {
            _context = context;
        }



        // GET: CarController
        public ActionResult Index()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var cars = _context.Cars;

            return View(cars);
        }

        // GET: CarController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cars == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.Include(s => s.carUsers).FirstOrDefaultAsync(m => m.id == id);




            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            Car car = new Car();

            // default Data for car
            car.status = "Working";
            car.seats_number = 5;


            return View(car);
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {


                _context.Cars.Add(car);

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View();
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            Car? car = new Car();

            car = _context.Cars.Find(id);
            return View(car);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Car car)
        {
            try
            {
                _context.Cars.Update(car);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            Car? car = new Car();

            car = _context.Cars.Find(id);

            return View(car);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Car car)
        {
            try
            {


                _context.Cars.Remove(car);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}