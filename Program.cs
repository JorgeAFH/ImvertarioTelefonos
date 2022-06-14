using System;
namespace InvertarioTelefonos
{
    class Program
    {
        static void Main(string[] args)
        {
            string elegir="0";
            
            Imprecion llamadaImprecion = new Imprecion();

            //***instancia de PRODUCTOS con sus variables****
            inverntario P1 = new inverntario("SAMSUNG GALAXY S10+", "10001", 5);
            inverntario P2 = new inverntario("SAMSUNG GALAXY S10+", "10002", 8);
            inverntario P3 = new inverntario("SAMSUNG GALAXY S10+", "10003", 5);
            inverntario P4 = new inverntario("IPHONE 8 PLUS 256GB", "20001", 10);
            inverntario P5 = new inverntario("IPHONE XS 128GB    ", "20002", 11);
            inverntario P6 = new inverntario("HUAWEI MATE 40 PRO ", "30001", 4);
            inverntario P7 = new inverntario("HUAWEI P30 LITE    ", "30002", 8);
            inverntario P8 = new inverntario("XIAOMI REDMI NOTE 8", "40001", 5);
            //************************************************

            //*************creacion de la lista***************
            List<inverntario> listaInventario = new List<inverntario>();
            listaInventario.Add(P1);
            listaInventario.Add(P2);
            listaInventario.Add(P3);
            listaInventario.Add(P4);
            listaInventario.Add(P5);
            listaInventario.Add(P6);
            listaInventario.Add(P7);
            listaInventario.Add(P8);
            //************************************************

            //********************bucle***********************
                while(elegir!="3")
                {
            //******************mensaje de menu****************        
                Console.Clear();
                Console.WriteLine("*                  BIENVENIDOS A                    *");
                Console.WriteLine("*   SISTEMAS DE FACTURACION - VENTAS TELEFONICAS    *");
                Console.WriteLine("                                                     ");
                Console.WriteLine("(1)  Nueva factura");
                Console.WriteLine("(2)  ver inverntario");
                Console.WriteLine("(3)  salir del programa");
            //**************************************************
                elegir = Console.ReadLine();
            //**********Botones Menu***************************
                switch (elegir)
                    { 
                        case "1":
                        {
                            llamadaImprecion.CrearFactura();
                            Console.WriteLine("¿Desea imprimir la factura?");
                            Console.WriteLine("(5)  si");
                            Console.WriteLine("(4)  no");
                            elegir=Console.ReadLine();
                            if(elegir=="5")
                            {
                                llamadaImprecion.Imprimir();
                            }
                        }
                        break;

                        case "2":
                        foreach(inverntario item in listaInventario)
                        {
                            item.MostrarInventario();
                        }
                        break;
                    }
                }
                Console.WriteLine("**Su programa se a cerrado exitosamente**");
            //***************************************************
        }
    }
}