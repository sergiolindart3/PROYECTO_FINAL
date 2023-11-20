using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    [Serializable]
    public class Ingreso
    {
        public double ingreso { get; set; }
        public string asunto { get; set; }
        public int frecuencia { get; set; }
        public DateTime fechaInicio { get; set; }

        public Ingreso() { }

        public Ingreso(double ingreso, string asunto, int frecuencia, DateTime fechaInicio)
        {
            this.ingreso = ingreso;
            this.asunto = asunto;
            this.frecuencia = frecuencia;
            this.fechaInicio = fechaInicio;
        }

        public Ingreso(double ingreso, string asunto, DateTime fechaInicio)
        {
            this.ingreso = ingreso;
            this.asunto = asunto;
            this.frecuencia = 0;
            this.fechaInicio = fechaInicio;
        }
    }
}
