using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador_Club.Entidades
{
    public class E_Cuota
    {
        public int NSocio
        {
            get; set;
        }
        public int Monto
        {
            get; set;
        }
        
        public DateOnly FechaPago
        {
            get; set;
        }
        public int MetodoPago
        {
            get; set;
        } 
        public DateOnly FechaInicio
        {
            get; set;
        }
        public DateOnly Vencimiento
        {
            get; set;
        }
    }    
}
