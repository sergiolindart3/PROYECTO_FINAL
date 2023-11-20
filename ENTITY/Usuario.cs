using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    [Serializable]
    public class Usuario
    {
        public string name { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public double saldo { get; set; }
        public List<Ingreso> ingresos { get; set; }
        public List<Egreso> egresos { get; set; }

        public Usuario() { }

        public Usuario(string name, string correo, string clave, double saldo)
        {
            this.name = name;
            this.correo = correo;
            this.clave = clave;
            this.saldo = saldo;
            this.ingresos = new List<Ingreso>();
            this.egresos = new List<Egreso>();
        }

        public void RegistrarIF(double ingreso, String asunto, int frecuencia, DateTime fechaInicio)
        {
            this.ingresos = new List<Ingreso>();
            Ingreso nuevoIngreso = new Ingreso(ingreso, asunto, frecuencia, fechaInicio);
            this.ingresos.Add(nuevoIngreso);
            DateTime fechaActual = DateTime.Now;
            if (fechaInicio <= fechaActual)
            {
                saldo += ingreso;
            }
            Console.WriteLine("LISTO... Registro Exitoso");
        }

        public void RegistrarIE(double ingreso, String asunto, DateTime fechaInicio)
        {
            this.ingresos = new List<Ingreso>();
            Ingreso nuevoIngreso = new Ingreso(ingreso, asunto, fechaInicio);
            this.ingresos.Add(nuevoIngreso);
            DateTime fechaActual = DateTime.Now;
            if (fechaInicio <= fechaActual)
            {
                saldo += ingreso;
            }
            Console.WriteLine("LISTO... Registro Exitoso");
        }

        public void RegistrarEF(double egreso, String asunto, int frecuencia, DateTime fechaInicio)
        {
            this.egresos = new List<Egreso>();
            Egreso nuevoEgreso = new Egreso(egreso, asunto, frecuencia, fechaInicio);
            this.egresos.Add(nuevoEgreso);
            DateTime fechaActual = DateTime.Now;
            if (fechaInicio <= fechaActual)
            {
                saldo -= egreso;
            }
            Console.WriteLine("LISTO... Registro Exitoso");
        }

        public void RegistrarEE(double egreso, String asunto, DateTime fechaInicio)
        {
            this.egresos = new List<Egreso>();
            Egreso nuevoEgreso = new Egreso(egreso, asunto, fechaInicio);
            this.egresos.Add(nuevoEgreso);
            DateTime fechaActual = DateTime.Now;
            if (fechaInicio <= fechaActual)
            {
                saldo -= egreso;
            }
            Console.WriteLine("LISTO... Registro Exitoso");
        }
    }
}