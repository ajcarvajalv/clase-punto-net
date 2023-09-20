using ProyectoMaquina.Control;
using ProyectoMaquina.Model;
using System;
using System.Xml.Linq;

namespace ProyectoMaquina.View
{
    internal class View
    {
        static void Main(string[] args)
        {
            // AQUÍ EMPIEZA NUESTRO PROGRAMA

            Controller controller = Controller.GetInstance();

            string texto_bienvenida = "Bienvenido a la máquina expendedora";

            Console.WriteLine(texto_bienvenida);
            string input_cliente = "";

            while (true)
            {
                do
                {
                    Console.WriteLine("Escoja tipo de cliente [C] o [P]:");
                    input_cliente = Console.ReadLine();

                } while (input_cliente != "C" && input_cliente != "P");

                Console.WriteLine("La lista de productos es: "); // TO-DO: Lista de productos

                // FOR PARA IMPRIMIR PRODUCTOS CON CONTROLLER

                Console.WriteLine(controller.DisplayProductList());

                if (input_cliente == "C")
                {
                    Console.WriteLine("Escoja un producto de la lista...");
                    bool valid_product = false;

                    do
                    {
                        string input_producto = Console.ReadLine();

                        valid_product = controller.ProductExists(input_producto) && controller.ProductHasInventory(input_producto);
                        if (valid_product == false)
                        {
                            Console.WriteLine("Escoja un producto válido");
                        }
                    
                    } while (!valid_product);

                    Console.WriteLine("Ingrese los billetes para el pago del producto: ");
                    int suma_billetes = 0;
                    int billete_ingresado = 0;
                    int[] billetes_aceptados = { 1000, 2000, 5000, 10000, 20000, 50000, 100000 };
                    string input_cash = "";

                        do
                        {
                            Console.WriteLine("Por favor, ingrese su billete: ");

                            billete_ingresado = Convert.ToInt32(Console.ReadLine());

                            int es_valido = Array.IndexOf(billetes_aceptados, billete_ingresado);

                            if (es_valido == -1)
                            {
                                Console.WriteLine("Valor no válido. Esta máquina solo recibe billetes con valor numérico de los billetes existentes");
                            } else
                            {
                                suma_billetes += billete_ingresado;
                                Console.WriteLine($"Billete ingresado con éxito. Su saldo es $ {suma_billetes}");
                            }

                            Console.WriteLine("Si desea ingresar otro billete, presione [ENTER]. De lo contrario, escriba [STOP]");

                           input_cash = Console.ReadLine();

                        } while (input_cash != "STOP");


                    if ()


                    //Comparar precio_producto vs. suma_billetes. Hacer cálculo.

                }
                else if (input_cliente == "P")
                {

                }

            }

        }
    }
}