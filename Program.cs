using Colas.Clases.ColaArreglo;
using Colas.Clases.Pila_Lista;
using System;
using System.Collections;

namespace Colas
{
    class Program
    {

        private static bool valido (String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                //rrecorido caracter por caracter
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }


        private static void capicua()
        {
            bool capicua;
            String numero;
            Queue qt = new Queue();//primero en entrar, primero en salir, COLAS
            Stack pilas = new Stack();//PILAS
            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        qt.Enqueue(c);//aqui estamos encolando el dato en la cola
                        pilas.Push(c);//para apilar datos en la pila e insertamos el dato en la parte superior de la pila
                         
                    }

                    //se retira de la cola y pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)qt.Dequeue();//aqui desencolamos el dato de la cola
                        capicua = d.Equals(pilas.Peek()); //compara la igualdad** Devuelve el objeto en la parte superior de la pila sin eliminarlo
                        pilas.Pop();//elimina y devuelve el objeto en la parte superior de la pila
                        //pop desapilar datos de la pilla 
                    } while (capicua && qt.Count > 0);

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {numero} no es capicua");
                        Console.WriteLine("intente otro");
                    }
                    // vaciar estructuras

                    qt.Clear();
                    pilas.Clear();

                }
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Error en {errores.Message}");
            }
        }
        static void Main(string[] args)
        {
            capicua();

           /* bool capicua;
            string numero;

            PilaLista pila = new PilaLista();
            ColaCircular circula_Cola = new ColaCircular();


            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclea un numero: ");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito
                    for (int i =0; i< numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        circula_Cola.insertar(c);
                        pila.insertar(c);
                    }//end for

                    //se retira de la cola y la pila para comparar
                    do
                    {
                        Char d;
                        d = (Char)circula_Cola.quitar();
                        capicua = d.Equals(pila.quitar());//para la igualdad
                    } while (capicua && !circula_Cola.colaVacia());
                       
                        if (capicua)
                        {
                            Console.WriteLine($"Numero {numero} es capicua");
                        }else
                        {
                            Console.WriteLine($"Numero {numero} no es capicua");
                            Console.WriteLine("Intente otro");
                        }
                    //vaciar estructurar
                    circula_Cola.borrarCola();
                    pila.LimpiarPila();
                }
            }
            catch(Exception errores)
            {
                Console.WriteLine($"Error en{errores.Message} ");
            }*/








            //Queue qt = new Queue();

            //qt.Enqueue("hola");
            //qt.Enqueue("esta");
            //qt.Enqueue("es");
            //qt.Enqueue("una");
            //qt.Enqueue("prueba");

            //Console.WriteLine($"La cola tiene {qt.Count}elementos");

            //Console.WriteLine($"Desenconlando{qt.Dequeue()}");
            //Console.WriteLine($"ahora la cola tiene {qt.Count}elementos");
        }
    }
}
