using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using CPC_Modelo;

namespace CPC_Controlador
{

    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public OdbcDataReader llenarcbxIdC()
        {
            return sn.llenarcbxIdCliente();
        }

        public OdbcDataReader llenartxtCli(string id_cliente)
        {
            return sn.llenartxtNCliente(id_cliente);
        }
    }
}
