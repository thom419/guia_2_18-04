using System;

namespace guia_2_18_04
{
    internal class Class1
    {
        public void ejecicio8()
        {
            // 8) Recibir números hasta un 0; mostrar cantidad, sumatoria, promedio, max y min.
            int contador = 0;
            double acumulador = 0;
            double numero;
            double max = double.MinValue;
            double min = double.MaxValue;

            do
            {
                Console.Write("Ingrese un número (0 para finalizar): ");
                if (!double.TryParse(Console.ReadLine() ?? "0", out numero))
                {
                    Console.WriteLine("Dato inválido. Ingrese un número válido.");
                    continue;
                }

                if (numero == 0)
                    break;

                contador++;
                acumulador += numero;
                if (numero > max) max = numero;
                if (numero < min) min = numero;

            } while (true);

            if (contador == 0)
            {
                Console.WriteLine("No se ingresaron números distintos de 0.");
            }
            else
            {
                double promedio = acumulador / contador;
                Console.WriteLine($"Cantidad de números ingresados: {contador}");
                Console.WriteLine($"Sumatoria: {acumulador}");
                Console.WriteLine($"Promedio: {promedio}");
                Console.WriteLine($"Valor máximo: {max}");
                Console.WriteLine($"Valor mínimo: {min}");
            }
        }

        public void ejercicio9()
        {
            // Realice un procedimiento que permita el ingreso de un número entero menor a 100 y que indique si es primo.
            int numero_correcto;
            bool valido;

            do
            {
                Console.Write("Ingrese un número entero mayor a 1 y menor a 100: ");
                string entrada = Console.ReadLine() ?? "";
                valido = int.TryParse(entrada, out numero_correcto);

                if (!valido)
                {
                    Console.WriteLine("Debe ingresar un número válido.");
                    continue;
                }

                if (numero_correcto < 1 || numero_correcto >= 100)
                {
                    Console.WriteLine("Debe ingresar un número mayor a 1 y menor a 100.");
                    valido = false;
                }

            } while (!valido);

            int contadorDivisores = 0;
            for (int i = 1; i <= numero_correcto; i++)
            {
                if (numero_correcto % i == 0) contadorDivisores++;
            }

            if (contadorDivisores == 2)
                Console.WriteLine($"{numero_correcto} es primo");
            else
                Console.WriteLine($"{numero_correcto} no es primo");
        }


        public void ejercico10()
        {
            //Se desea contar con un programa que le permita calcular el total de alumnos inscriptos en todos los cursos abiertos.
            //El programa debe permitir el ingreso de la cantidad de alumnos anotados en cada curso que serán numerados automáticamente
            //y en forma consecutiva al correr el proceso, comenzando por el curso 1
            //Como la cantidad de cursos no se encuentra definida,
            //el fin de proceso se producirá al ingresar un 0 en la cantidad de alumnos inscriptos. [ Condición de Salida ]

            int contador_curso = 0;         // Cuenta la cantidad de cursos ingresados (no incluye el 0 de salida)
            int acumulador_alumnos = 0;      // Acumula el total de alumnos sumando cada curso válido
            string cantidad_alumnos;          // Guarda el dato ingresado por el usuario como texto (input crudo)
            int salida_alumnos;  // Guarda el valor convertido a entero para poder validarlo y usarlo
            bool flag = false;  // Indica si el dato ingresado es válido (true = válido, false = repetir ingreso)
            do
            {
                flag = false;
                do
                {
                    Console.WriteLine("Ingrese cantidad de alumnos en curso N°" + (contador_curso+1) +":");
                    cantidad_alumnos = Console.ReadLine();
                    if (!int.TryParse(cantidad_alumnos, out salida_alumnos))
                    {
                        Console.WriteLine("Debe ingresar un numero entero");
                    }
                    else if (salida_alumnos < 0)
                    {
                        Console.WriteLine("Debe ingresar un numero positivo");
                    }
                    else
                    {
                        
                        flag = true;//el dato esta bien
                        
                    }

                } while (!flag);

                if(salida_alumnos!=0)
                {
                    contador_curso++;
                    acumulador_alumnos += salida_alumnos;
                }

            } while (salida_alumnos !=0);

            Console.WriteLine( "total alumnos: " + acumulador_alumnos);
            Console.WriteLine("Cursos ingresados: " + contador_curso);



        }
        public void ejercicio10b()
        {
            //Construya un programa con la misma función que el anterior,
            //pero en el que para finalizar el proceso se deba ingresar un número mayor a 99,
            //y los cursos se numeren comenzando por el curso 10.
            //Nota: los cursos nunca tienen más de 99 alumnos.

            int contador_curso = 0;         // Cuenta la cantidad de cursos ingresados (no incluye el 0 de salida)
            int acumulador_alumnos = 0;      // Acumula el total de alumnos sumando cada curso válido
            string cantidad_alumnos;          // Guarda el dato ingresado por el usuario como texto (input crudo)
            int salida_alumnos;  // Guarda el valor convertido a entero para poder validarlo y usarlo
            bool flag = false;  // Indica si el dato ingresado es válido (true = válido, false = repetir ingreso)
            do
            {
                flag = false;
                do
                {
                    Console.WriteLine("Ingrese cantidad de alumnos en curso N°" + (contador_curso + 10) + ":");
                    cantidad_alumnos = Console.ReadLine();
                    if (!int.TryParse(cantidad_alumnos, out salida_alumnos))
                    {
                        Console.WriteLine("Debe ingresar un numero entero");
                    }
                    else if (salida_alumnos < 0)
                    {
                        Console.WriteLine("Debe ingresar un numero positivo");
                    }
                    else
                    {

                        flag = true;//el dato esta bien

                    }

                } while (!flag);

                if (salida_alumnos != 0)
                {
                    contador_curso++;
                    acumulador_alumnos += salida_alumnos;
                }

            } while (salida_alumnos != 0);

            Console.WriteLine("total alumnos: " + acumulador_alumnos);
            Console.WriteLine("Cursos ingresados: " + contador_curso);



        }






    }//
}//
