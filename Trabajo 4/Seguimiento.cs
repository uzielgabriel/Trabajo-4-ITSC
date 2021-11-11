using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_4
{
    class Seguimiento
    {
        public System.Data.DataTable Datable { get; set; } = new System.Data.DataTable();
        Usuario uss { get; set; } = new Usuario();
        public int UltimoId { get; set; } = 0;

        public Seguimiento()
        {
            Datable.TableName = "ListaPersonas";
            Datable.Columns.Add("Orden");
            Datable.Columns.Add("Semana");
            Datable.Columns.Add("Ejercicio");
            Datable.Columns.Add("Peso");

            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Lista.xml"))
            {
                //Datable.Clear();
                Datable.ReadXml("Lista.xml");
                UltimoId = 0;
                for (int i = 0; i < Datable.Rows.Count; i++)
                {
                    if (Convert.ToInt32(Datable.Rows[i]["Orden"]) > UltimoId)
                    {
                        UltimoId = Convert.ToInt32(Datable.Rows[i]["Orden"]);
                    }
                }
            }
        }
        public bool UpdatePersona(Usuario usuario)
        {
            bool resp = usuario.Validar();

            if (resp)
            {
                if (usuario.IdOrden == 0)
                {
                    UltimoId = UltimoId + 1;
                    usuario.IdOrden = UltimoId;

                    Datable.Rows.Add();
                    int NumeroRegistroNuevo = Datable.Rows.Count - 1;

                    Datable.Rows[NumeroRegistroNuevo]["Orden"] = usuario.IdOrden.ToString();
                    Datable.Rows[NumeroRegistroNuevo]["Semana"] = usuario.Semana.ToString();
                    Datable.Rows[NumeroRegistroNuevo]["Ejercicio"] = usuario.Ejercicio;
                    Datable.Rows[NumeroRegistroNuevo]["Peso"] = usuario.Peso.ToString();

                    Datable.WriteXml("Lista.xml");
                }
                else
                {
                    for (int fila = 0; fila < Datable.Rows.Count; fila++)
                    {
                        if (Convert.ToInt32(Datable.Rows[fila]["Orden"]) == usuario.IdOrden)
                        {
                            Datable.Rows[fila]["Semana"] = usuario.Semana.ToString();
                            Datable.Rows[fila]["Ejercicio"] = usuario.Ejercicio;
                            Datable.Rows[fila]["Peso"] = usuario.Peso.ToString();
                            Datable.WriteXml("Lista.xml");
                            break;
                        }
                    }
                }
            }
            return resp;
        }

        public bool BorrarLinea(Usuario usuario)
        {
            bool resp = false;
            for (int fila = 0; fila < Datable.Rows.Count; fila++)
            {
                if (Convert.ToInt32(Datable.Rows[fila]["Orden"]) == usuario.IdOrden)
                {
                    Datable.Rows[fila].Delete();
                    Datable.WriteXml("Lista.xml");
                    resp = true;
                    break;
                }
            }

            return resp;
        }

        public bool Borrar(Usuario usuario)
        {
            bool resp = false;

            Datable.Rows.Clear();
            Datable.WriteXml("Lista.xml");
            resp = true;
            return resp;
        }
    }



}

