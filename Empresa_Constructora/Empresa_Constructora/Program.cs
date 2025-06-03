using System;
using System.Collections;

namespace Empresa_Constructora
{
    class Program
    {
        static Empresa miEmpresa = new Empresa("San Isidro");

        static void Main(string[] args)
        {
            // Crear 8 grupos (Grupo A a H)
            for (int i = 1; i <= 8; i++)
            {
                miEmpresa.TodosLosGrupos.Add(new GrupoObreros(i, "Grupo " + (char)('A' + i - 1)));
            }

            Console.WriteLine("Bienvenido a la empresa constructora: " + miEmpresa.Nombre);
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1 - Contratar obrero");
                Console.WriteLine("2 - Asignar obrero a grupo");
                Console.WriteLine("3 - Eliminar obrero o jefe por legajo");
                Console.WriteLine("4 - Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        DatosObreroContratado();
                        break;
                    case "2":
                        AsignarObreroAGrupo();
                        break;
                    case "3":
                        EliminarObreroJefe();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey(true);
        }

        static void DatosObreroContratado()
        {
            try
            {
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();

                Console.Write("DNI: ");
                string dni = Console.ReadLine();

                Console.Write("Legajo: ");
                int legajo = int.Parse(Console.ReadLine());

                Console.Write("Sueldo: ");
                double sueldo = double.Parse(Console.ReadLine());

                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();

                Obrero nuevoObrero = new Obrero(nombre, apellido, dni, legajo, sueldo, cargo);
                miEmpresa.ContratarObrero(nuevoObrero);
            }
            catch (LegajoDuplicadoException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Formato incorrecto.");
            }
        }

        static void AsignarObreroAGrupo()
        {
            try
            {
                Console.Write("Legajo del obrero: ");
                int legajo = int.Parse(Console.ReadLine());

                Console.Write("ID del grupo: ");
                int grupoId = int.Parse(Console.ReadLine());

                miEmpresa.AsignarObreroAGrupo(legajo, grupoId);
            }
            catch (ObreroNoEncontradoException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (GrupoObrerosNoEncontradoException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Ingrese valores numéricos válidos.");
            }
        }

        static void EliminarObreroJefe()
        {
            try
            {
                Console.Write("Ingrese el legajo del obrero o jefe a eliminar: ");
                int legajo = int.Parse(Console.ReadLine());
                miEmpresa.EliminarObreroPorLegajo(legajo);
            }
            catch (ObreroNoEncontradoException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Ingrese un número válido.");
            }
        }
    }
}
