using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    [Serializable]
    public class EgresoEventual : Egreso
    {
        public DateTime fechaInicio { get; set; }

        public EgresoEventual() { }

        public EgresoEventual(DateTime fechaInicio, double egreso, string asunto) : base(egreso, asunto)
        {
            this.fechaInicio = fechaInicio;
        }
    }
}
