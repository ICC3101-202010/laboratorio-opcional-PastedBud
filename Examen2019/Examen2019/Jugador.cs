using System;
namespace Examen2019
{
    public class Jugador
    {
        
        public Jugador()
        {
        }

        public void Atacar()
        {

        }

        public void MoverBarco(Embarcacion embarcacion)
        {
            if (embarcacion.Nombre == "Portaaviones")
            {
                string opcion = "a";

                if (embarcacion.portaaviones.Manera == "Horizontal")
                {
                    while (opcion == "a")
                    {
                        Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                        Console.WriteLine("1 --> Arriba");
                        Console.WriteLine("2 --> Abajo");
                        opcion = Console.ReadLine();

                        
                        if (opcion == "1")
                        {

                            if (embarcacion.portaaviones.Posicion[0] < 10)
                            {
                                embarcacion.portaaviones.Posicion[0] += 1;
                                opcion = "1";
                            }
                            else
                            {
                                Console.WriteLine("No Puedes mover el Barco mas Arriba");
                            }
                        }
                        else if (opcion == "2")
                        {

                            if (embarcacion.portaaviones.Posicion[0] > 1)
                            {
                                embarcacion.portaaviones.Posicion[0] -= 1;
                                opcion = "1";
                            }
                            else
                            {
                                Console.WriteLine("No Puedes mover el Barco mas Abajo");
                            }
                        }
                        else
                        {
                            opcion = "a";
                            Console.WriteLine("Opcion Invalida");
                        }
                    }
                }
                else if (embarcacion.portaaviones.Manera == "Vertical")
                {
                    while (opcion == "a")
                    {
                        Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                        Console.WriteLine("1 --> Derecha");
                        Console.WriteLine("2 --> Izquierda");
                        opcion = Console.ReadLine();

                        if (opcion == "1")
                        {
                            if (embarcacion.portaaviones.Posicion[1] < 10)
                            {
                                embarcacion.portaaviones.Posicion[1] += 1;
                                opcion = "1";
                            }
                            else
                            {
                                Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                            }

                        }
                        else if (opcion == "2")
                        {

                            if (embarcacion.portaaviones.Posicion[1] > 1)
                            {
                                embarcacion.portaaviones.Posicion[1] -= 1;
                                opcion = "1";
                            }
                            else
                            {
                                Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                            }
                        }
                        else
                        {
                            opcion = "a";
                            Console.WriteLine("Opcion Invalida");
                        }
                    }
                }


            }
            else if (embarcacion.Nombre == "Fragata")
            {
                string opcion = "a";
                Console.WriteLine("Cuantas Posiciones te Quieres Mover?");
                Console.WriteLine("1 --> 1");
                Console.WriteLine("2 --> 2");
                string opcion2 = Console.ReadLine();
                if (opcion2 == "1")
                {
                    if (embarcacion.fragata.Manera == "Horizontal")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Arriba");
                            Console.WriteLine("2 --> Abajo");
                            opcion = Console.ReadLine();


                            if (opcion == "1")
                            {

                                if (embarcacion.fragata.Posicion[0] < 10)
                                {
                                    embarcacion.fragata.Posicion[0] += 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Arriba");
                                }
                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.fragata.Posicion[0] > 1)
                                {
                                    embarcacion.fragata.Posicion[0] -= 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Abajo");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                    else if (embarcacion.fragata.Manera == "Vertical")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Derecha");
                            Console.WriteLine("2 --> Izquierda");
                            opcion = Console.ReadLine();

                            if (opcion == "1")
                            {
                                if (embarcacion.fragata.Posicion[1] < 10)
                                {
                                    embarcacion.fragata.Posicion[1] += 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                                }

                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.fragata.Posicion[1] > 1)
                                {
                                    embarcacion.fragata.Posicion[1] -= 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                }

                else if (opcion2 == "2")
                {
                    if (embarcacion.fragata.Manera == "Horizontal")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 2 espacios?");
                            Console.WriteLine("1 --> Arriba");
                            Console.WriteLine("2 --> Abajo");
                            opcion = Console.ReadLine();


                            if (opcion == "1")
                            {

                                if (embarcacion.fragata.Posicion[0] < 9)
                                {
                                    embarcacion.fragata.Posicion[0] += 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Arriba");
                                }
                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.fragata.Posicion[0] > 2)
                                {
                                    embarcacion.fragata.Posicion[0] -= 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Abajo");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                    else if (embarcacion.fragata.Manera == "Vertical")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Derecha");
                            Console.WriteLine("2 --> Izquierda");
                            opcion = Console.ReadLine();

                            if (opcion == "1")
                            {
                                if (embarcacion.fragata.Posicion[1] < 9)
                                {
                                    embarcacion.fragata.Posicion[1] += 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                                }

                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.fragata.Posicion[1] > 2)
                                {
                                    embarcacion.fragata.Posicion[1] -= 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                }
                
            }
            else if (embarcacion.Nombre == "Submarino")
            {
                string opcion = "a";
                Console.WriteLine("Cuantas Posiciones te Quieres Mover?");
                Console.WriteLine("1 --> 1");
                Console.WriteLine("2 --> 2");
                Console.WriteLine("3 --> 3");
                string opcion2 = Console.ReadLine();
                if (opcion2 == "1")
                {
                    if (embarcacion.submarino.Manera == "Horizontal")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Arriba");
                            Console.WriteLine("2 --> Abajo");
                            opcion = Console.ReadLine();


                            if (opcion == "1")
                            {

                                if (embarcacion.submarino.Posicion[0] < 10)
                                {
                                    embarcacion.submarino.Posicion[0] += 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Arriba");
                                }
                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.submarino.Posicion[0] > 1)
                                {
                                    embarcacion.submarino.Posicion[0] -= 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Abajo");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                    else if (embarcacion.submarino.Manera == "Vertical")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Derecha");
                            Console.WriteLine("2 --> Izquierda");
                            opcion = Console.ReadLine();

                            if (opcion == "1")
                            {
                                if (embarcacion.submarino.Posicion[1] < 10)
                                {
                                    embarcacion.submarino.Posicion[1] += 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                                }

                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.submarino.Posicion[1] > 1)
                                {
                                    embarcacion.submarino.Posicion[1] -= 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                }

                else if (opcion2 == "2")
                {
                    if (embarcacion.submarino.Manera == "Horizontal")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 2 espacios?");
                            Console.WriteLine("1 --> Arriba");
                            Console.WriteLine("2 --> Abajo");
                            opcion = Console.ReadLine();


                            if (opcion == "1")
                            {

                                if (embarcacion.submarino.Posicion[0] < 9)
                                {
                                    embarcacion.submarino.Posicion[0] += 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Arriba");
                                }
                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.submarino.Posicion[0] > 2)
                                {
                                    embarcacion.submarino.Posicion[0] -= 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Abajo");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                    else if (embarcacion.submarino.Manera == "Vertical")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Derecha");
                            Console.WriteLine("2 --> Izquierda");
                            opcion = Console.ReadLine();

                            if (opcion == "1")
                            {
                                if (embarcacion.submarino.Posicion[1] < 9)
                                {
                                    embarcacion.submarino.Posicion[1] += 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                                }

                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.submarino.Posicion[1] > 2)
                                {
                                    embarcacion.submarino.Posicion[1] -= 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                }
                else if (opcion2 == "3")
                {
                    if (embarcacion.submarino.Manera == "Horizontal")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 3 espacios?");
                            Console.WriteLine("1 --> Arriba");
                            Console.WriteLine("2 --> Abajo");
                            opcion = Console.ReadLine();


                            if (opcion == "1")
                            {

                                if (embarcacion.submarino.Posicion[0] < 8)
                                {
                                    embarcacion.submarino.Posicion[0] += 3;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Arriba");
                                }
                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.submarino.Posicion[0] > 3)
                                {
                                    embarcacion.submarino.Posicion[0] -= 3;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Abajo");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                    else if (embarcacion.submarino.Manera == "Vertical")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Derecha");
                            Console.WriteLine("2 --> Izquierda");
                            opcion = Console.ReadLine();

                            if (opcion == "1")
                            {
                                if (embarcacion.submarino.Posicion[1] < 8)
                                {
                                    embarcacion.submarino.Posicion[1] += 3;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                                }

                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.submarino.Posicion[1] > 3)
                                {
                                    embarcacion.submarino.Posicion[1] -= 3;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                }
            }
            else if (embarcacion.Nombre == "Reparador")
            {
                string opcion = "a";
                Console.WriteLine("Cuantas Posiciones te Quieres Mover?");
                Console.WriteLine("1 --> 1");
                Console.WriteLine("2 --> 2");
                Console.WriteLine("3 --> 3");
                string opcion2 = Console.ReadLine();
                if (opcion2 == "1")
                {
                    if (embarcacion.reparador.Manera == "Horizontal")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Arriba");
                            Console.WriteLine("2 --> Abajo");
                            opcion = Console.ReadLine();


                            if (opcion == "1")
                            {

                                if (embarcacion.reparador.Posicion[0] < 10)
                                {
                                    embarcacion.reparador.Posicion[0] += 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Arriba");
                                }
                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.reparador.Posicion[0] > 1)
                                {
                                    embarcacion.reparador.Posicion[0] -= 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Abajo");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                    else if (embarcacion.reparador.Manera == "Vertical")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Derecha");
                            Console.WriteLine("2 --> Izquierda");
                            opcion = Console.ReadLine();

                            if (opcion == "1")
                            {
                                if (embarcacion.reparador.Posicion[1] < 10)
                                {
                                    embarcacion.reparador.Posicion[1] += 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                                }

                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.reparador.Posicion[1] > 1)
                                {
                                    embarcacion.reparador.Posicion[1] -= 1;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                }

                else if (opcion2 == "2")
                {
                    if (embarcacion.reparador.Manera == "Horizontal")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 2 espacios?");
                            Console.WriteLine("1 --> Arriba");
                            Console.WriteLine("2 --> Abajo");
                            opcion = Console.ReadLine();


                            if (opcion == "1")
                            {

                                if (embarcacion.reparador.Posicion[0] < 9)
                                {
                                    embarcacion.reparador.Posicion[0] += 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Arriba");
                                }
                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.reparador.Posicion[0] > 2)
                                {
                                    embarcacion.reparador.Posicion[0] -= 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Abajo");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                    else if (embarcacion.reparador.Manera == "Vertical")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Derecha");
                            Console.WriteLine("2 --> Izquierda");
                            opcion = Console.ReadLine();

                            if (opcion == "1")
                            {
                                if (embarcacion.reparador.Posicion[1] < 9)
                                {
                                    embarcacion.reparador.Posicion[1] += 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                                }

                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.reparador.Posicion[1] > 2)
                                {
                                    embarcacion.reparador.Posicion[1] -= 2;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                }
                else if (opcion2 == "3")
                {
                    if (embarcacion.reparador.Manera == "Horizontal")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 3 espacios?");
                            Console.WriteLine("1 --> Arriba");
                            Console.WriteLine("2 --> Abajo");
                            opcion = Console.ReadLine();


                            if (opcion == "1")
                            {

                                if (embarcacion.reparador.Posicion[0] < 8)
                                {
                                    embarcacion.reparador.Posicion[0] += 3;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Arriba");
                                }
                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.reparador.Posicion[0] > 3)
                                {
                                    embarcacion.reparador.Posicion[0] -= 3;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas Abajo");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                    else if (embarcacion.reparador.Manera == "Vertical")
                    {
                        while (opcion == "a")
                        {
                            Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                            Console.WriteLine("1 --> Derecha");
                            Console.WriteLine("2 --> Izquierda");
                            opcion = Console.ReadLine();

                            if (opcion == "1")
                            {
                                if (embarcacion.reparador.Posicion[1] < 8)
                                {
                                    embarcacion.reparador.Posicion[1] += 3;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                                }

                            }
                            else if (opcion == "2")
                            {

                                if (embarcacion.reparador.Posicion[1] > 3)
                                {
                                    embarcacion.reparador.Posicion[1] -= 3;
                                    opcion = "1";
                                }
                                else
                                {
                                    Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                                }
                            }
                            else
                            {
                                opcion = "a";
                                Console.WriteLine("Opcion Invalida");
                            }
                        }
                    }
                }
            }
            else if (embarcacion.Nombre == "Radar")
            {
                string opcion = "a";

                
                while (opcion == "a")
                {
                    Console.WriteLine("En que sentido quieres moverte 1 espacio?");
                    Console.WriteLine("1 --> Arriba");
                    Console.WriteLine("2 --> Abajo");
                    Console.WriteLine("3 --> Derecha");
                    Console.WriteLine("4 --> Izquierda");
                    opcion = Console.ReadLine();


                    if (opcion == "1")
                    {

                        if (embarcacion.radar.Posicion[0] < 10)
                        {
                            embarcacion.radar.Posicion[0] += 1;
                            opcion = "1";
                        }
                        else
                        {
                            Console.WriteLine("No Puedes mover el Barco mas Arriba");
                        }
                    }
                    else if (opcion == "2")
                    {

                        if (embarcacion.radar.Posicion[0] > 1)
                        {
                            embarcacion.radar.Posicion[0] -= 1;
                            opcion = "1";
                        }
                        else
                        {
                            Console.WriteLine("No Puedes mover el Barco mas Abajo");
                        }
                    }
                    else if (opcion == "3")
                    {
                        if (embarcacion.radar.Posicion[1] < 10)
                        {
                            embarcacion.radar.Posicion[1] += 1;
                            opcion = "1";
                        }
                        else
                        {
                            Console.WriteLine("No Puedes mover el Barco mas a la Derecha");
                        }

                    }
                    else if (opcion == "4")
                    {

                        if (embarcacion.radar.Posicion[1] > 1)
                        {
                            embarcacion.radar.Posicion[1] -= 1;
                            opcion = "1";
                        }
                        else
                        {
                            Console.WriteLine("No Puedes mover el Barco mas a la Izquierda");
                        }
                    }
                    else
                    {
                        opcion = "a";
                        Console.WriteLine("Opcion Invalida");
                    }
                }
                
                
                    
                
            }
            else
            {
                Console.WriteLine("No se Encontró el tipo de Barco");
            }
        }

        public void EjecutarEspecial()
        {

        }
    }
}
