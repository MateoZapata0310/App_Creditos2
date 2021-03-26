using System;
using Datos;
namespace Negocio
{
    public class Cls_Cliente_Negocio
    {
        public String [] AUX = new string [9];
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
                msn = "El Cliente " + nombre + " ha sido registrado con éxito.";
            }


        }

        public void Fnt_ConsultarCliente(String id)
        {
            if(id != "")
            {
                Cls_Clientes_Datos ObjConsultar = new Cls_Clientes_Datos();
                ObjConsultar.Fnt_ConsultarDatos(id);


                //nombre_ = Convert.ToString(ObjConsultar.Lectura[0]);
                //contacto_ = Convert.ToString(ObjConsultar.Lectura[1]);
                //correo_ = Convert.ToString(ObjConsultar.Lectura[2]);
                //edad_ = Convert.ToString(ObjConsultar.Lectura[3]);
                //ingresos_ = Convert.ToString(ObjConsultar.Lectura[4]);
                //empresa_ = Convert.ToString(ObjConsultar.Lectura[5]);
                //contactoE_ = Convert.ToString(ObjConsultar.Lectura[6]);
                //sexo_ = Convert.ToString(ObjConsultar.Lectura[7]);
                //estadoCivil_ = Convert.ToString(ObjConsultar.Lectura[8]);

            }

        }
    }
}
