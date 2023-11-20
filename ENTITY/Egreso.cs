using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    [Serializable]
    public class Egreso
    {
        public double egreso { get; set; }
        public string asunto { get; set; }
        public int frecuencia { get; set; }
        public DateTime fechaInicio { get; set; }

        public Egreso() { }

        public Egreso(double egreso, string asunto, int frecuencia, DateTime fechaInicio)
        {
            this.egreso = egreso;
            this.asunto = asunto;
            this.frecuencia = frecuencia;
            this.fechaInicio = fechaInicio;
        }

        public Egreso(double egreso, string asunto, DateTime fechaInicio)
        {
            this.egreso = egreso;
            this.asunto = asunto;
            this.frecuencia = 0;
            this.fechaInicio = fechaInicio;
        }
    }
}
