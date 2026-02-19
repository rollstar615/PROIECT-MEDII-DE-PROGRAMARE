using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Coworking.Data;
using Proiect_Coworking.Models;

namespace Proiect_Coworking.Pages.Locatii
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Coworking.Data.Proiect_CoworkingContext _context;

        public DetailsModel(Proiect_Coworking.Data.Proiect_CoworkingContext context)
        {
            _context = context;
        }

      public Locatie Locatie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Locatie == null)
            {
                return NotFound();
            }

            var locatie = await _context.Locatie.FirstOrDefaultAsync(m => m.LocatieID == id);
            if (locatie == null)
            {
                return NotFound();
            }
            else 
            {
                Locatie = locatie;
            }
            return Page();
        }
    }
}
