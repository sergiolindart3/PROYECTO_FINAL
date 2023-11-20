using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    [Serializable]
    public class EgresoFijo : Egreso
    {
        public DateTime fechaInicio { get; set; }
        public int frecuencia { get; set; }

        public EgresoFijo() { }

        public EgresoFijo(int frecuencia, DateTime fechaInicio, double egreso, string asunto) : base(egreso, asunto)
        {
            this.fechaInicio = fechaInicio;
            this.frecuencia = frecuencia;
        }
    }
}
