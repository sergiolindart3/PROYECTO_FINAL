using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Presentacion
{
    internal class PpalConsola
    {
        static UsuarioBLL usuarioBLL = new UsuarioBLL();
        static List<Usuario> usuarios = new List<Usuario>();
        static BinaryFormatter binaryFormatter = new BinaryFormatter();
        static int pos;
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("********** MENU PRINCIPAL **********");
                Console.WriteLine("1. INICIAR SESION");
                Console.WriteLine("2. REGISTRAR");
                Console.WriteLine("3. SALIR");
                Console.Write("Selecciona una opción: ");

                string opcionMP = Console.ReadLine();

                switch (opcionMP)
                {
                    case "1":
                        usuarios = usuarioBLL.ConsultarUsers();
                        Console.WriteLine("********** INICIAR SESION **********");
                        Console.Write("CORREO: ");
                        string correoI = Console.ReadLine();
                        Console.Write("CLAVE: ");
                        string claveI = Console.ReadLine();
                        pos = usuarioBLL.ValidarAcceso(correoI, claveI);

                        if (pos == -1)
                        {
                            Console.WriteLine("CORREO O CLAVE INCORRECTA");
                        }
                        else
                        {
                            bool IS = true;
                            while (IS)
                            {
                                Console.WriteLine($"SALDO: {usuarios[pos].saldo}");
                                Console.WriteLine("1. AGREGAR INGRESO");
                                Console.WriteLine("2. AGREGAR EGRESO");
                                Console.WriteLine("3. MODIFICAR CUENTA");
                                Console.WriteLine("4. CONSULTAR INGRESOS");
                                Console.WriteLine("5. CONSULTAR EGRESOS");
                                Console.WriteLine("6. CERRAR SESION");
                                Console.Write("Selecciona una opción: ");

                                string opcion = Console.ReadLine();

                                switch (opcion)
                                {
                                    case "1":
                                        AggIngreso(pos);
                                        break;
                                    case "2":
                                        AggEgreso(pos);
                                        break;
                                    case "3":
                                        //ModificarCuenta();
                                        break;
                                    case "4":
                                        string fileIngreso = $"{usuarios[pos].correo}Ingresos.obj";
                                        if (!File.Exists(fileIngreso))
                                        {
                                            Console.WriteLine("ERROR... NO HAY INGRESOS REGISTRADOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine("INGRESOS REGISTRADOS:");
                                            List<Ingreso> listIngresos = new List<Ingreso>();
                                            using (FileStream fileStream = new FileStream(fileIngreso, FileMode.Open))
                                            {
                                                while (fileStream.Position < fileStream.Length)
                                                {
                                                    Ingreso ingreso = (Ingreso)binaryFormatter.Deserialize(fileStream);
                                                    listIngresos.Add(ingreso);
                                                }
                                            }
                                            foreach (Ingreso ingreso in listIngresos)
                                            {
                                                Console.Write($"Monto: {ingreso.ingreso}, Asunto: {ingreso.asunto}, ");
                                                if (ingreso is IngresoFijo ingresoFijo)
                                                {
                                                    Console.Write($"Frecuencia: {ingresoFijo.frecuencia} días, ");
                                                    Console.WriteLine($"Fecha de inicio: {ingresoFijo.fechaInicio.Date:dd/MM/yyyy}");
                                                }
                                                if (ingreso is IngresoEventual ingresoEventual)
                                                {
                                                    Console.WriteLine($"Fecha de inicio: {ingresoEventual.fechaInicio.Date:dd/MM/yyyy}");
                                                }
                                            }
                                        }
                                        break;
                                    case "5":
                                        string fileEgreso = $"{usuarios[pos].correo}Egresos.obj";
                                        if (!File.Exists(fileEgreso))
                                        {
                                            Console.WriteLine("ERROR... NO HAY EGRESOS REGISTRADOS");
                                        }
                                        else
                                        {
                                            Console.WriteLine("EGRESOS REGISTRADOS:");
                                            List<Egreso> listEgresos = new List<Egreso>();
                                            using (FileStream fileStream = new FileStream(fileEgreso, FileMode.Open))
                                            {
                                                while (fileStream.Position < fileStream.Length)
                                                {
                                                    Egreso egreso = (Egreso)binaryFormatter.Deserialize(fileStream);
                                                    listEgresos.Add(egreso);
                                                }
                                            }
                                            foreach (Egreso egreso in listEgresos)
                                            {
                                                Console.Write($"Monto: {egreso.egreso}, Asunto: {egreso.asunto}, ");
                                                if (egreso is EgresoFijo egresoFijo)
                                                {
                                                    Console.Write($"Frecuencia: {egresoFijo.frecuencia} días, ");
                                                    Console.WriteLine($"Fecha de inicio: {egresoFijo.fechaInicio.Date:dd/MM/yyyy}");
                                                }
                                                if (egreso is EgresoEventual egresoEventual)
                                                {
                                                    Console.WriteLine($"Fecha de inicio: {egresoEventual.fechaInicio.Date:dd/MM/yyyy}");
                                                }
                                            }
                                        }
                                        break;
                                    case "6":
                                        IS = false; // Salir del programa
                                        break;
                                    default:
                                        Console.WriteLine("--> ERROR... Digite una Opcion Valida <--");
                                        break;
                                }
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("********** REGISTRAR USUARIO **********");
                        Console.Write("NOMBRE: ");
                        string name = Console.ReadLine();
                        Console.Write("CORREO: ");
                        string correoR = Console.ReadLine();
                        Console.Write("CLAVE: ");
                        string claveR = Console.ReadLine();
                        double saldo = 0;
                        if (usuarioBLL.ValidarRegistroUser(correoR))
                        {
                            Console.WriteLine("YA EXISTE UN CORREO ASI");
                        }
                        else
                        {
                            Usuario nuevoUsuario = new Usuario
                            {
                                name = name,
                                correo = correoR,
                                clave = claveR,
                                saldo = saldo
                            };

                            string resultadoGuardar = usuarioBLL.GuardarUser(nuevoUsuario);
                            Console.WriteLine(resultadoGuardar);
                        }
                        break;
                    case "3":
                        Environment.Exit(0); // Salir del programa
                        break;
                    case "4":
                        //CONSULTA DE USUARIOS: esto es solo para probar que si registra
                        List<Usuario> listUsers = usuarioBLL.ConsultarUsers();
                        if (listUsers == null)
                        {
                            Console.WriteLine("NO HAY USUARIOS");
                        }
                        else
                        {
                            foreach (Usuario usuario in listUsers)
                            {
                                Console.WriteLine($"Nombre de Usuario: {usuario.name}");
                                Console.WriteLine($"correo: {usuario.correo}");
                                Console.WriteLine($"contraseña: {usuario.clave}");
                                Console.WriteLine($"SALDO: {usuario.saldo}");
                                Console.WriteLine("*************************************************");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("--> ERROR... Digite una Opcion Valida <--");
                        break;
                }
            }
        }
        static void AggIngreso(int pos)
        {
            bool IF = true;
            while (IF)
            {
                Console.WriteLine("********** INGRESOS **********");
                Console.WriteLine("1. INGRESO FIJO");
                Console.WriteLine("2. INGRESO EVENTUAL");
                Console.WriteLine("3. CANCELAR");
                Console.Write("Selecciona una Opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("********** INGRESO FIJO **********");
                        Console.WriteLine("CANTIDAD: ");
                        double nuevoIF = double.Parse(Console.ReadLine());
                        Console.WriteLine("ASUNTO: ");
                        string asuntoIF = Console.ReadLine();
                        Console.WriteLine("FRECUENCIA (DIAS): ");
                        int frecuenciaIF = int.Parse(Console.ReadLine());
                        Console.WriteLine("FECHA: ");
                        DateTime fechaIF = DateTime.Now;
                        if (usuarios[pos] != null)
                        {
                            usuarios[pos].RegistrarIF(nuevoIF, asuntoIF, frecuenciaIF, fechaIF);
                            usuarioBLL.ActualizarSaldo(usuarios[pos].correo, usuarios[pos].saldo);
                            using (FileStream fileStream = new FileStream($"{usuarios[pos].correo}Ingresos.obj", FileMode.Append))
                            {
                                binaryFormatter.Serialize(fileStream, usuarios[pos].ingresos.Last());
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("********** INGRESO EVENTUAL **********");
                        Console.WriteLine("CANTIDAD: ");
                        double nuevoIE = double.Parse(Console.ReadLine());
                        Console.WriteLine("ASUNTO: ");
                        string asuntoIE = Console.ReadLine();
                        Console.WriteLine("FECHA: ");
                        DateTime fechaIE = DateTime.Now;
                        if (usuarios[pos] != null)
                        {
                            usuarios[pos].RegistrarIE(nuevoIE, asuntoIE, fechaIE);
                            usuarioBLL.ActualizarSaldo(usuarios[pos].correo, usuarios[pos].saldo);
                            using (FileStream fileStream = new FileStream($"{usuarios[pos].correo}Ingresos.obj", FileMode.Append))
                            {
                                binaryFormatter.Serialize(fileStream, usuarios[pos].ingresos.Last());
                            }
                        }
                        break;
                    case "3":
                        IF = false;
                        break;
                    default:
                        Console.WriteLine("--> ERROR... Digite una Opcion Valida <--");
                        break;
                }
            }
        }

        static void AggEgreso(int pos)
        {
            bool IF = true;
            while (IF)
            {
                Console.WriteLine("********** EGRESOS **********");
                Console.WriteLine("1. EGRESO FIJO");
                Console.WriteLine("2. EGRESO EVENTUAL");
                Console.WriteLine("3. CANCELAR");
                Console.Write("Selecciona una Opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("********** EGRESO FIJO **********");
                        Console.WriteLine("CANTIDAD: ");
                        double nuevoEF = double.Parse(Console.ReadLine());
                        Console.WriteLine("ASUNTO: ");
                        string asuntoEF = Console.ReadLine();
                        Console.WriteLine("FRECUENCIA (DIAS): ");
                        int frecuenciaEF = int.Parse(Console.ReadLine());
                        Console.WriteLine("FECHA: ");
                        DateTime fechaEF = DateTime.Now;
                        if (usuarios[pos] != null)
                        {
                            usuarios[pos].RegistrarEF(nuevoEF, asuntoEF, frecuenciaEF, fechaEF);
                            usuarioBLL.ActualizarSaldo(usuarios[pos].correo, usuarios[pos].saldo);
                            using (FileStream fileStream = new FileStream($"{usuarios[pos].correo}Egresos.obj", FileMode.Append))
                            {
                                binaryFormatter.Serialize(fileStream, usuarios[pos].egresos.Last());
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("********** EGRESO EVENTUAL **********");
                        Console.WriteLine("CANTIDAD: ");
                        double nuevoEE = double.Parse(Console.ReadLine());
                        Console.WriteLine("ASUNTO: ");
                        string asuntoEE = Console.ReadLine();
                        Console.WriteLine("FECHA: ");
                        DateTime fechaEE = DateTime.Now;
                        if (usuarios[pos] != null)
                        {
                            usuarios[pos].RegistrarEE(nuevoEE, asuntoEE, fechaEE);
                            usuarioBLL.ActualizarSaldo(usuarios[pos].correo, usuarios[pos].saldo);
                            using (FileStream fileStream = new FileStream($"{usuarios[pos].correo}Egresos.obj", FileMode.Append))
                            {
                                binaryFormatter.Serialize(fileStream, usuarios[pos].egresos.Last());
                            }
                        }
                        break;
                    case "3":
                        IF = false;
                        break;
                    default:
                        Console.WriteLine("--> ERROR... Digite una Opcion Valida <--");
                        break;
                }
            }
        }
    }
}