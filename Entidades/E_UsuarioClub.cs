using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Club.Entidades
{
    public class E_UsuarioClub
    {
        public int NSocio
        {
            get; set;
        }
        public string? Nombre
        {
            get; set;
        }
        public int DNI
        {
            get; set;
        }
        public string? Correo
        {
            get; set;
        }
  
        public DateOnly FechaInscripcion
        {
        get; set; }

        public bool AptoFisico
        {
            get; set;
        }

    }
}
