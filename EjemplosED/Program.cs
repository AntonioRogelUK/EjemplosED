using System;
using System.Reflection.Metadata;

namespace EjemplosED
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine($"El producto con código " +
                //    $"{producto1.Codigo} - {producto1.Descripcion} " +
                //    $"tiene un precio de {producto1.ValorUnitario}");


                ////Declarando un arreglo
                //string[] Arreglo = new string[10];
                //string[] Arreglo = { "Juan", "Miguel", "Oscar" };

                ////Dando valores al arreglo
                //Arreglo[0] = "PrimerDato";
                //Arreglo[1] = "SegundoDato";

                ////Dando valores al arreglo con for
                //for(int i = 0; i < Arreglo.Length; i++) 
                //{
                //    Arreglo[i] = $"Indice{i}";
                //}

                ////Redimensionar un arreglo
                //Array.Resize(ref Arreglo, Arreglo.Length + 3);

                ////Obteniendo valores del arreglo recorriendolo con foreach
                //foreach(string dato in Arreglo) 
                //{
                //    Console.WriteLine(dato);
                //}

                //Console.WriteLine("El arreglo tiene:" + Arreglo.Length.ToString());
                //string MiVariable = string.Format("El arreglo tiene: {0} {1}", Arreglo.Length.ToString() , "Otra variable");
                //Console.WriteLine(MiVariable);
                //Console.WriteLine($"El arreglo tiene: {Arreglo.Length}");


                //int Indice = 2;
                //Console.WriteLine($"El arreglo en el indice '{Indice}' " +
                //    $"tiene el valor de: '{Arreglo[Indice]}'");


                ////Declarando un objeto de una clase Producto
                Producto producto0 = new Producto();
                producto0.Codigo = "001";
                producto0.Descripcion = "Refresco";
                producto0.ValorUnitario = 15.00m;

                ////Otra manera de declarar un objeto de la clase Producto
                //Producto producto1 = new Producto
                //{
                //    Codigo = "001",
                //    Descripcion = "Refresco",
                //    ValorUnitario = 15.00m
                //};

                //Producto producto2 = new Producto
                //{
                //    Codigo = "002",
                //    Descripcion = "Sabritas",
                //    ValorUnitario = 10.00m
                //};


                ////Declarando un arreglo de la clase Producto y asignando valores
                //Producto[] productos = new Producto[2];
                //productos[0] = producto1;
                //productos[1] = producto2;


                ////Otra manera de declarar un arreglo de la clase Producto y asignando valores
                Producto[] productos = 
                {
                    new Producto{Codigo = "001",Descripcion = "Refresco",ValorUnitario = 15.00m},
                    new Producto{Codigo = "002",Descripcion = "Sabritas",ValorUnitario = 10.00m},
                    new Producto{Codigo="003",Descripcion = "Botella de agua", ValorUnitario=12.00m},
                };


                ////Recorriendo el arreglo de productos y modificando un producto en especifico
                foreach(Producto producto in productos) 
                {
                    if (producto.Codigo == "002") 
                    {
                        producto.Descripcion = "Nueva descripcion";
                    }
                }

                //Aqui vamos a hacer un cambio
            }
            catch (Exception ex)
            {
                string errores = ex.Message;
                if (ex.Message.IndexOf("Index was outside the bounds of the array") > -1) 
                {
                    errores = "Error en el indice, es mayor a el tamaño de la matriz";
                }
                Console.WriteLine(errores);
            }
        }
    }
}
