using System;

namespace HDT_1___Array_equipos_del_mundial
{
    class Program
    {
        static void Main(string[] args)
        {
            AñadirEquiposYJugadores();
        }

        private static void AñadirEquiposYJugadores()
        {
            bool añadirEquipo = false;
            int cont = 0;

            Console.WriteLine("ingrese la cantidad de equipos a guardar");
            int cantidadE = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de jugadores por equipo a guardar");
            int cantidadJ = int.Parse(Console.ReadLine());
   
            object[,] equiposyJugadores = new object[cantidadE,2];
            

            while (!añadirEquipo) {
                string[] equipode = new string[cantidadJ];
                Console.WriteLine("ingrese nombre del equipo");
                string equipo = Console.ReadLine();

                equiposyJugadores[cont, 0] = equipo;
                

                for (int i = 0; i < equipode.Length;i++ )
                {
                    Console.WriteLine("desea añadir jugador al equipo?");
                    string otrojugador = Console.ReadLine();
                    if (otrojugador == "si")
                    {
                        Console.WriteLine("ingrese nombre:");
                        string jugador = Console.ReadLine();
                        equipode[i] = jugador;
                    }
                    else {
                        equiposyJugadores[cont, 1] = equipode;
                        break;
                    }
                }
                equiposyJugadores[cont, 1] = equipode;
                cont += 1;

                if (cont < equiposyJugadores.GetLength(0))
                {
                    Console.WriteLine("desea añadir otro equipo?");
                    string resp = Console.ReadLine();
                    if (resp == "no") añadirEquipo = true;
                    else { 
                        Console.Clear();
                    }
                }
                else
                {
                    añadirEquipo = true;
                    break;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("////////////EQUIPOS Y JUGADORES////////////");
                foreach (object i in equiposyJugadores)
                {    
                    if(i is Array){
                        Console.WriteLine("+++Listado de jugadores");
                        foreach(string sub in (Array) i){
                            Console.WriteLine("--"+sub);
                        }
                    }else Console.WriteLine("*****************EQUIPO: "+i);
                }
            

        }
    }
}
