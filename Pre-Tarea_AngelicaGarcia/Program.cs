using System;
using System.Linq;
using System.ComponentModel;
using System.Security.Cryptography;


namespace Pre_Tarea_AngelicaGarcia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos de Presentacion
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Angelica Yessenia Garcia Osorio");
            Console.WriteLine("Pre-Tarea - Calculo de Salario - UNAD");
            Console.WriteLine("Curso Estructura Datos");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");

            //Contraseña de acceso por defecto
            string passwordDefault = "123";

            //Solicitar Contraseña al usuario
            Console.Write("Escriba la contraseña: ");
            string passwordUser = Console.ReadLine();

            //Comparar contraseñas para conceder  o negar acceso
            bool accessWD = String.Equals(passwordUser, passwordDefault);

            //Solicitar hasta que sea correcta
            while (accessWD != true)
            {
                Console.WriteLine("La constaseña no es correcta");
                Console.WriteLine("");
                Console.Write("Digitele nuevamente: ");
                passwordUser = Console.ReadLine();
                accessWD = String.Equals(passwordUser, passwordDefault);
            }

            //Acceso concedido
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Bienvenid@");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");

            //Solicitar Datos del trabajador
            Console.Write("Ingrese nombre del Trabajador: ");
            string nameEmployee = Console.ReadLine();//nombre
            Console.WriteLine("");

            //Solicitar Dias laborados
            Console.Write("Ingrese dias laborados: ");
            string workingDays = Console.ReadLine();

            //Solicitar hasta que dias laborados sea numero valido
            bool isNumber = workingDays.All(char.IsNumber);
            while (isNumber != true)
             {
                 Console.WriteLine("La cifra para dias es incorrecta ");
                 Console.WriteLine("");
                 Console.Write("Ingrese dias laborados: ");
                 workingDays = Console.ReadLine();
                 isNumber = workingDays.All(char.IsNumber);
                 Console.WriteLine("");
             }
            
            //Convertir dias laborados validados en entero
            int workingDaysValidate = int.Parse(workingDays);
            Console.WriteLine("-----------------------------------------------------");

            //Calcular salario
            Console.Clear();

            //menos 10 dias -- Salario sin bonificacion
            if (workingDaysValidate <= 10) 
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine($"Nombre del trabajador: {nameEmployee}");
                Console.WriteLine($"Dias laborados       : {workingDays} dias");
                Console.WriteLine($"Salario              : $ {35000 * workingDaysValidate}");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------");
            }
            else //mas de 10 dias -- Salario con bonificacion 50000
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine($"Nombre del trabajador: {nameEmployee}");
                Console.WriteLine($"Dias laborados       : {workingDays} dias");
                Console.WriteLine($"Salario              : $ {(35000 * workingDaysValidate)+50000}");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
