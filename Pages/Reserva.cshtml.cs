using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KimaliVic.Pages
{
    public class ReservaModel : PageModel
    {
        [BindProperty]
        public int NumHabitacion { get; set; }
        public string NombreFoto { get; set; }
        public void OnGet(int numhabitacion)
        {
            NumHabitacion = numhabitacion;
            NombreFoto = numhabitacion.ToString() + ".jpg";

            if (numhabitacion == 1)
            {               
                NombreFoto = "4.jpg";
            }

            if (numhabitacion == 3)
            {                
                NombreFoto = "fotos de 2.jpg";
            }

            if (numhabitacion == 5)
            {             
                NombreFoto = "6.jpg";
            }
        }     
    }
}
