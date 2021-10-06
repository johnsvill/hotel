using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KimaliVic.Pages
{
    public class EventoModel : PageModel
    {
        [BindProperty]
        public int NumEvento { get; set; }
        public void OnGet(int numevento)
        {
            NumEvento = numevento;
        }
    }
}
