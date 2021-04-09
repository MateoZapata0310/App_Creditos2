using System;
using Datos;
namespace Negocio
{
    public class Cls_Cliente_Negocio
    {
        public String[] aux = new string[9];
        public String msn;

        public void Fnt_AgregarCliente(
           String id,
           String nombre,
           String contacto,
           String correo,
           String edad,
           String ingresos,
           String empresa,
           String contactoE,
           String sexo,
           String estadoCivil)
        {

            if ((((((((id == "") || (nombre == "") || (contacto == "") || (correo == "") || (edad == "") || (ingresos == "") ||
                (empresa == "") || (contactoE == ""))))))))
            {
                msn = "Debe diligenciar toda la información solicitada";
            }
            else
            {
                Cls_Clientes_Datos ObjClientes = new Cls_Clientes_Datos();
                ObjClientes.Fnt_AgregarCliente(id, nombre, contacto, correo, edad, ingresos, empresa, contactoE, sexo, estadoCivil);
                if (ObjClientes.sw == 0)
                {
                    msn = "El Cliente " + nombre + " ha sido registrado con éxito.";
                }
                else
                {
                    msn = "La identificación: " + id + " ya se encuentra registrada";
                }
            }


        }

        public void Fnt_ConsultarCliente(String id)
        {
            if (id != "")
            {
                Cls_Clientes_Datos ObjConsultar = new Cls_Clientes_Datos();
                ObjConsultar.Fnt_ConsultarDatos(id);

                if (ObjConsultar.sw == 1)
                {
                    for (int i = 0; i <= 8; i++)
                    {
                        aux[i] = Convert.ToString(ObjConsultar.Lectura[i]);
                    }
                    ObjConsultar.objconect_select.connection.Close();
                    msn = "";
                }
                else
                {
                    msn = "No se encontraron registros para la identificación: " + id;
                }
            }

        }

        public void Fnt_Actualizar(
           String id,
           String contacto,
           String correo,
           String edad,
           String ingresos,
           String empresa,
           String contactoE,
           String estadoCivil)
        {
            if (((((((id == "") || (contacto == "") || (correo == "") || (edad == "") || (ingresos == "") ||
               (empresa == "") || (contactoE == "")))))))
            {
                msn = "Debe diligenciar toda la información solicitada";
            }
            else
            {
                Cls_Clientes_Datos ObjClientes = new Cls_Clientes_Datos();
                ObjClientes.Fnt_ActualizarCliente(id,
                    contacto,
                    correo,
                    edad,
                    ingresos,
                    empresa,
                    contactoE,
                    estadoCivil);
                msn = "Datos Actualizados Con Exito";

            }
        }
    }
}
