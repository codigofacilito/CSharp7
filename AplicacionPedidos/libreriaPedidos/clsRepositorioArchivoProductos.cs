using System;
using System.Collections.Generic;
using System.IO;

namespace libreriaPedidos
{
    public class clsRepositorioArchivoProductos : IRepositorioProductos
    {
        #region Propiedades
        #endregion

        #region Constructor
        #endregion

        #region Metodos
        public void Elimina(int id)
        {
            //throw new NotImplementedException();
        }

        public void Guarda(clsProductosCatalogo producto)
        {
            //throw new NotImplementedException();
        }

        public void Modifica(clsProductosCatalogo producto)
        {
            //throw new NotImplementedException();
        }

        public void ObtenTodos(Dictionary<string, clsProductosCatalogo> productos)
        {
            string nombreArchivo = ControlPedidos.rutaArchivo + "\\Productos.txt";
            if(File.Exists(nombreArchivo))
            {
                TextReader txtReader;
                string linea;
                clsProductosCatalogo producto = new clsProductosCatalogo();
                productos.Clear();
                using (txtReader = new StreamReader(nombreArchivo))
                {
                    do
                    {
                        linea = txtReader.ReadLine();
                        if (linea != null)
                        {
                            string[] campos = linea.Split(',');
                            producto = new clsProductosCatalogo();
                            producto.idProducto = Convert.ToInt32(campos[0]);
                            producto.Clave = campos[1];
                            producto.CodigoBarras = campos[2];
                            producto.Descripcion = campos[3];
                            producto.EsMontoIeps = Convert.ToBoolean(campos[4]);
                            producto.Ieps = Convert.ToDecimal(campos[5]);
                            producto.PorcentajeIva = Convert.ToDecimal(campos[6]);
                            producto.Precio = Convert.ToDecimal(campos[7]);
                            producto.Precio2 = Convert.ToDecimal(campos[8]);
                            producto.Precio3 = Convert.ToDecimal(campos[9]);
                            productos.Add(producto.Clave, producto);
                        }
                    } while (linea != null);
                    txtReader.Close();
                }
            }
        }
        #endregion
    }
}
