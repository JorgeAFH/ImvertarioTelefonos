using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Telefonos 
{
    class Program 
    {
        public static void Main (string[] args) 
        {     
            
            Console.WriteLine("**********BIENVENIDOS A SISTEMA DE FACTURIZACIÓN **********" + "\n ********** VENTAS TELEFONICAS ********** ");

            byte elegir;
            Console.WriteLine("(1) Nueva Factura");
            Console.WriteLine("(2) Ver Inventario");
            elegir = byte.Parse(Console.ReadLine());
            Console.Clear();
            Factura factura = new Factura();

            /*Inventario celular1 = new Inventario(100009,"Samsung Galaxy S10      ", 5);
            Inventario celular2 = new Inventario(100016, "Samsung Galaxy A72      ", 9);
            Inventario celular3 = new Inventario(100025, "Samsung Galaxy S20 FE   ", 3);
            Inventario celular4 = new Inventario(100027, "Samsung Galaxy S21      ", 4);
            Inventario celular5 = new Inventario(200005, "Iphone 8 Plus 256 GB   ", 10);
            Inventario celular6 = new Inventario(200011, "Iphone XS 128 GB        ", 3);
            Inventario celular7 = new Inventario(200016, "Iphone 12 Pro Max 128 GB", 4);
            Inventario celular8 = new Inventario(200017, "Iphone 12 Pro Max 256 GB", 5);
            Inventario celular9 = new Inventario(300001, "Huawei Mate 40 Pro      ", 6);
            Inventario celular10 = new Inventario(300009, "Huawei P30 Lite         ", 7);
            Inventario celular11 = new Inventario(300015, "Huawei Y9 2019          ", 2);
            Inventario celular12 = new Inventario(300018, "Xiaomi Mate 20          ", 1);
            Inventario celular13 = new Inventario(400013, "Xiaomi Redmi Note 8     ", 9);
            Inventario celular14 = new Inventario(400026, "Xiaomi MI 11T           ", 0);
            Inventario celular15 = new Inventario(400029, "Xiaomi Redmi 9C         ", 5);
            Inventario celular16 = new Inventario(400035, "Xiaomi MI 10            ", 5);
            
            List<Inventario> listacelulares = new List<Inventario>();
            listacelulares.Add(celular1);
            listacelulares.Add(celular2);
            listacelulares.Add(celular3);
            listacelulares.Add(celular4);
            listacelulares.Add(celular5);
            listacelulares.Add(celular6);
            listacelulares.Add(celular7);
            listacelulares.Add(celular8);
            listacelulares.Add(celular9);
            listacelulares.Add(celular10);
            listacelulares.Add(celular11);
            listacelulares.Add(celular12);
            listacelulares.Add(celular13);
            listacelulares.Add(celular14);
            listacelulares.Add(celular15);
            listacelulares.Add(celular16);*/
            
            switch (elegir)
            {
                case 1:
                    factura.Ingresar();            
                    factura.Imprimir();
                    break;
                case 2:
                   
                    var dispositivos = new Dispositivos();
                    var dispositivo1 = new Dispositivo1(dispositivos);
                    Console.WriteLine($"{dispositivo1.MostrarInve()}");
                    Inventario Dispositivo1 = new Inventario(100009, "     Samsung Galaxy S10         ", 5);
                    Dispositivo1.MostrarInve();
                    var dispositivo2 = new Dispositivo2(dispositivos);                   
                    Inventario Dispositivo2 = new Inventario(100016, "     Samsung Galaxy A72         ",    9);
                    Dispositivo2.MostrarInve();
                    var dispositivo3 = new Dispositivo3(dispositivos);                   
                    Inventario Dispositivo3 = new Inventario(100025, "     Samsung Galaxy S20 FE      ",    3);
                    Dispositivo3.MostrarInve();
                    var dispositivo4 = new Dispositivo4(dispositivos);                   
                    Inventario Dispositivo4 = new Inventario(100027, "     Samsung Galaxy S21         ",    4);
                    Dispositivo4.MostrarInve();
                    var dispositivo5 = new Dispositivo5(dispositivos);                    
                    Inventario Dispositivo5 = new Inventario(200005, "     Iphone 8 Plus 256 GB       ",     10);
                    Dispositivo5.MostrarInve();
                    var dispositivo6 = new Dispositivo6(dispositivos);                   
                    Inventario Dispositivo6 = new Inventario(200011, "     Iphone XS 128 GB           ",    3);
                    Dispositivo6.MostrarInve();
                    var dispositivo7 = new Dispositivo7(dispositivos);                   
                    Inventario Dispositivo7 = new Inventario(200016, "     Iphone 12 Pro Max 128 GB   ",    4);
                    Dispositivo7.MostrarInve();
                    var dispositivo8 = new Dispositivo8(dispositivos);                  
                    Inventario Dispositivo8 = new Inventario(200017, "     Iphone 12 Pro Max 256 GB   ",    5);
                    Dispositivo8.MostrarInve();
                    var dispositivo9 = new Dispositivo9(dispositivos);                   
                    Inventario Dispositivo9 = new Inventario(300009, "     Huawei P30 Lite            ",    7);
                    Dispositivo9.MostrarInve();
                    //Console.WriteLine($"100009   Samsung Galaxy S10  5 { dispositivos.MostrarInve()}");


                    /*foreach (Inventario item in listacelulares)
                    {
                        
                        item.Imprimir();
                    }*/
                    break;
            }
        }
    }
}
