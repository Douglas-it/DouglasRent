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
    }
}