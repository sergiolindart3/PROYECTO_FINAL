using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    [Serializable]
    public class IngresoEventual : Ingreso
    {
        public DateTime fechaInicio { get; set; }

        public IngresoEventual() { }

        public IngresoEventual(DateTime fechaInicio, double ingreso, string asunto) : base(ingreso, asunto)
        {
            this.fechaInicio = fechaInicio;
        }
    }
}
