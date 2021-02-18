using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystemData.Interface;
using EscuelaSystemModules;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystemWeb.Pages
{
    public class MateriasModel : PageModel
    {
        private readonly IProductoRepository _materiaRepository;

        public MateriasModel(IProductoRepository materiaRepository)
        {
            _materiaRepository = materiaRepository;
        }

        [BindProperty]
        public IEnumerable<Producto> Materias { get; set; }

        public IActionResult OnGet()
        {
            Materias = _materiaRepository.List();
            return Page();
        }
    }
}
