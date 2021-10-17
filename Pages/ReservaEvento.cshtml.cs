using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KimaliVic.Pages
{
    public class ReservaEventoModel : PageModel
    {
        [BindProperty]
        public string NombreSalon { get; set; }
        public string NombreFoto { get; set; }
        public void OnGet(int numhabitacion)
        {
            if(numhabitacion==1)
            {
                NombreSalon = "Salón Guadalupe";
                NombreFoto = "salonguadalupe.jpg";
            }

            if (numhabitacion == 2)
            {
                NombreSalon = "Salón San Marcos";
                NombreFoto = "salonsanmarcos.jpg";
            }

            if (numhabitacion == 3)
            {
                NombreSalon = "Salón Tuncaj";
                NombreFoto = "salonsantuncaj.jpg";
            }
            if (numhabitacion == 4)
            {
                NombreSalon = "Salón Ejecutivo";
                NombreFoto = "salonejecutivo.jpg";
            }
            if (numhabitacion == 5)
            {
                NombreSalon = "Safari kids";
                NombreFoto = "safarikids.jpg";
            }

        }
    }
}
