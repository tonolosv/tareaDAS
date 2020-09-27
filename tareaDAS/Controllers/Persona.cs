using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tareaDAS.Models;

namespace tareaDAS.Controllers
{
    public class Persona : Controller
    {
        List<PersonaModels> personas = new List<PersonaModels>();
        
        public Persona()
        {
            //List<PersonaModels> personas = new List<PersonaModels>();
            personas.Add(new PersonaModels
            {
                Id = 01,
                nombre = "Natanael",
                apellido = "Hernandez",
                direccion = "San Salvador",
                area = "Logistica",
                salario = 2000,
                cargo = "Jefe"
            });
            personas.Add(new PersonaModels
            {
                Id = 02,
                nombre = "Silvia",
                apellido = "Gonzales",
                direccion = "Ilopango",
                area ="Administracion",
                salario = 1000,
                cargo = "Admin"
            });
        }


        // GET: Persona  ... detalle de todas las personas
        public ActionResult Index()
        {

            //var persona = new List<PersonaModels>();
            //persona.Add(new PersonaModels
            //{
            //    nombre = "Pepe",
            //    direccion = "Algo",
            //    salario = 2000,
            //    cargo = "Jefe"
            //});
            //persona.Add(new PersonaModels
            //{
            //    nombre = "Simon",
            //    direccion = "Algo por alli",
            //    salario = 1000,
            //    cargo = "Admin"
            //});
            return View(personas);
        }

        // GET: Persona/Details/5 .... detalle un solo elemento
        public ActionResult Details(int id)
        {
            var persona = personas.Find(p => p.Id == id);
            return View(persona);
        }

        // GET: Persona/Create ...crear un elemento
        public ActionResult Create()
        {
           // var persona = personas.Find(p => p.Id == Id);
            return View();
        }

        // POST: Persona/Create .... crear el elemento y enviarlo a mostrar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            var persona = personas.Find(p => p.Id == id);
            return View(persona);
        }

        // POST: Persona/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonaModels datosUpate)
        {
            try
            {
                var persona = personas.Find(p => p.Id == id);
                if (persona != null)
                {
                    persona.nombre = datosUpate.nombre;
                    persona.direccion = datosUpate.direccion;
                    persona.salario = datosUpate.salario;
                    persona.cargo = datosUpate.cargo;
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            var persona = personas.Find(p => p.Id == id);
            return View(persona);
        }

        // POST: Persona/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var persona = personas.Find(p => p.Id == id);
                if (persona != null)
                {
                    personas.Remove(persona);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
