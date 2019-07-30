using System;
using System.Collections.Generic;
using System.IO;

namespace libreriaPedidos
{
    public class clsRepositorioArchivoClientes : IRepositorioClientes
    {
        #region Propiedades
        private string rutaArchivo;
        #endregion

        #region Constructor
        public clsRepositorioArchivoClientes()
        {

        }

        public clsRepositorioArchivoClientes(string ruta)
        {
            rutaArchivo = ruta;
        }
        #endregion

        #region Metodos
        public void CreaCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void EliminaCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ModificaCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ObtenCliente(clsClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ObtenClientes(ref List<clsClientes> clientes)
        {
            string nombreArchivo = rutaArchivo + "\\Clientes.txt";
            if(File.Exists(nombreArchivo))
            {
                TextReader txtReader;
                string linea;
                clsClientes cliente = new clsClientes();
                clientes.Clear();
                using (txtReader = new StreamReader(nombreArchivo))
                {
                    do
                    {
                        linea = txtReader.ReadLine();
                        if (linea != null)
                        {
                            string[] campos = linea.Split(',');
                            cliente = new clsClientes();
                            cliente.idCliente = Convert.ToInt32(campos[0]);
                            cliente.Clave = campos[1];
                            cliente.NombreCompleto = campos[2];
                            cliente.Rfc = campos[3];
                            cliente.Tipo = (TipoCliente)Convert.ToInt32(campos[4]);
                            clientes.Add(cliente);
                        }
                    } while (linea != null);
                    txtReader.Close();
                }
            }
        }
        #endregion
    }
}
