using System;
using System.Collections.Generic;
using System.IO;
using G3_edad.Entidades;

namespace G3_edad.Datos
{
    public static class G3_Archivos
    {
        private static string G3_clientesPath = "G3_clientes.txt";
        private static string G3_productosPath = "G3_productos.txt";
        private static string G3_comprasPath = "G3_compras.txt";

        // Guardar clientes (sobrescribe el archivo)
        public static void G3_GuardarClientes(List<G3_Cliente> G3_clientes)
        {
            using (StreamWriter sw = new StreamWriter(G3_clientesPath, false))
            {
                foreach (var c in G3_clientes)
                {
                    sw.WriteLine($"{c.G3_Id},{c.G3_Nombre},{c.G3_Apellido},{c.G3_DNI},{c.G3_Celular}");
                }
            }
        }

        // Leer todos los clientes (lectura secuencial)
        public static List<G3_Cliente> G3_LeerClientes()
        {
            var lista = new List<G3_Cliente>();
            if (!File.Exists(G3_clientesPath)) return lista;
            using (StreamReader sr = new StreamReader(G3_clientesPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    var datos = linea.Split(',');
                    if (datos.Length >= 5)
                    {
                        lista.Add(new G3_Cliente
                        {
                            G3_Id = int.Parse(datos[0]),
                            G3_Nombre = datos[1],
                            G3_Apellido = datos[2],
                            G3_DNI = datos[3],
                            G3_Celular = datos[4]
                        });
                    }
                }
            }
            return lista;
        }

        // Guardar productos (sobrescribe el archivo)
        public static void G3_GuardarProductos(List<G3_Producto> G3_productos)
        {
            using (StreamWriter sw = new StreamWriter(G3_productosPath, false))
            {
                foreach (var p in G3_productos)
                {
                    sw.WriteLine($"{p.G3_Id},{p.G3_Nombre},{p.G3_Categoria},{p.G3_Precio},{p.G3_Stock}");
                }
            }
        }

        // Leer todos los productos (lectura secuencial)
        public static List<G3_Producto> G3_LeerProductos()
        {
            var lista = new List<G3_Producto>();
            if (!File.Exists(G3_productosPath)) return lista;
            using (StreamReader sr = new StreamReader(G3_productosPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    var datos = linea.Split(',');
                    if (datos.Length >= 5)
                    {
                        lista.Add(new G3_Producto
                        {
                            G3_Id = int.Parse(datos[0]),
                            G3_Nombre = datos[1],
                            G3_Categoria = datos[2],
                            G3_Precio = decimal.Parse(datos[3]),
                            G3_Stock = int.Parse(datos[4])
                        });
                    }
                }
            }
            return lista;
        }

        // Guardar compras (agrega al archivo)
        public static void G3_GuardarCompra(string G3_dni, int G3_productoId, string G3_productoNombre, decimal G3_precio, DateTime G3_fecha)
        {
            using (StreamWriter sw = new StreamWriter(G3_comprasPath, true))
            {
                sw.WriteLine($"{G3_dni},{G3_productoId},{G3_productoNombre},{G3_precio},{G3_fecha:yyyy-MM-dd HH:mm:ss}");
            }
        }

        // Leer todas las compras
        public static List<string[]> G3_LeerCompras()
        {
            var lista = new List<string[]>();
            if (!File.Exists(G3_comprasPath)) return lista;
            using (StreamReader sr = new StreamReader(G3_comprasPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    var datos = linea.Split(',');
                    if (datos.Length >= 5)
                        lista.Add(datos);
                }
            }
            return lista;
        }
    }
}
