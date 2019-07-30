using System;
using System.Collections.Generic;
using System.IO;

namespace libPedidos
{
    public class clsRepositorioArchivoClientes : intRepositorioClientes
    {
        #region Propiedades
        private string rutaArchivos;
        #endregion

        #region Constructor
        public clsRepositorioArchivoClientes(string ruta)
        {
            rutaArchivos = ruta;
        }
        #endregion

        #region Metodos
        public void AgregaCliente(clsClientes cliente)
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

        public void ObtenClientes(List<clsClientes> clientes)
        {
            string nombreArchivo = rutaArchivos + "\\Clientes.txt";
            if (File.Exists(nombreArchivo))
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
                    } while (linea != null) ;
                    txtReader.Close();
                }
            }
        }
        #endregion
    }
}
