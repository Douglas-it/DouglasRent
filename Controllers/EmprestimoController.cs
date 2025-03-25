using DouglasRent.Data;
using Microsoft.AspNetCore.Mvc; 
using DouglasRent.Models;
using System.Collections.Generic;

namespace DouglasRent.Controllers
{
    public class EmprestimoController : Controller // Controller is a class that contains methods that handle HTTP requests.
    { 
       readonly private ApplicationDbContext _db; //readonly is a property that can only be assigned once, i.e. it is read-only.

        public  EmprestimoController(ApplicationDbContext db)   // Constructor that receives an instance of the ApplicationDbContext class.
            {
                _db = db;   // Assign the instance of the ApplicationDbContext class to the _db property.
            }
    
        public IActionResult Index() // Index method that returns a view.
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos; // rreceives all loans    
            return View(emprestimos);
        }


        [HttpGet]
        public IActionResult Editar(int? id) // Edit method that receives an id as a parameter.
        {
            if (id == null || id == 0 ) // If the id is 0.
            {
                return NotFound(); // Redirect to the Index method.
            }

            EmprestimosModel emprestimos = _db.Emprestimos.FirstOrDefault(x => x.id == id); // Find the loan by id.

            if (emprestimos == null) // If the loan is null.
            {
                return NotFound(); // Redirect to the Index method.
            }

            return View(emprestimos);// Find the loan by id.
            
        }

        [HttpPost]
        public IActionResult Editar(EmprestimosModel emprestimo) // Edit method that receives a loan as a parameter.
        {
            if (ModelState.IsValid) // If the model is valid.
            {
                _db.Emprestimos.Update(emprestimo); // Update the loan.
                _db.SaveChanges(); // Save changes to the database.

                TempData["MessageSucesso"] = "Emprestimo atualizado com sucesso!"; // Message that will be displayed on the screen.
                return RedirectToAction("Index"); // Redirect to the Index method.
            }

            TempData["MessageError"] = "Algum erro ocorreu na edição!";
            return View(emprestimo); // Return the loan.
        }


        [HttpGet]
        public IActionResult Excluir(int? id) // Delete method that receives an id as a parameter.
        {
            if (id == null || id == 0) // If the id is 0.
            {
                return NotFound(); // Redirect to the Index method.
            }

            EmprestimosModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.id == id); // Find the loan by id.

            if (emprestimo == null) // If the loan is null.
            {
                return NotFound(); // Redirect to the Index method.
            }

            return View(emprestimo); // Return the loan.
        }

        [HttpPost]
        public IActionResult Excluir(EmprestimosModel emprestimo)
        {
            if (emprestimo == null)
            {
                return NotFound();
            }

            _db.Emprestimos.Remove(emprestimo);
            _db.SaveChanges();

            TempData["MessageSucesso"] = "Emprestimo excluido com sucesso!";
            return RedirectToAction("Index");
        }


        [HttpPost] // Attribute that indicates that the method will respond to POST requests. 
            public IActionResult Cadastrar(EmprestimosModel emprestimo) // Create method that receives a loan as a parameter.
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimos.Add(emprestimo); // Add the loan to the database.
                _db.SaveChanges(); // Save changes to the database.

                TempData["MessageSucesso"] = "Emprestimo cadastrado com sucesso!"; // Message that will be displayed on the screen.

                return RedirectToAction("Index"); // Redirect to the Index method.
            }
            return View(emprestimo); // Return the loan.    
        }
    }
}