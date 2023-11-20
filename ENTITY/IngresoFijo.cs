using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    [Serializable]
    public class IngresoFijo : Ingreso
    {
        public DateTime fechaInicio { get; set; }
        public int frecuencia { get; set; }

        public IngresoFijo() { }

        public IngresoFijo(int frecuencia, DateTime fechaInicio, double ingreso, string asunto) : base(ingreso, asunto)
        {
            this.fechaInicio = fechaInicio;
            this.frecuencia = frecuencia;
        }
    }
}
