using System;
using Datos;

namespace Negocio
{
    public class Cls_Credito_Negocio
    {
        public String msn = "";
        public void Fnt_GuardarCredito(
            String id,
            String dia_pago,
            String valor_prestamo,
            int plazo,
            String cuota,
            int interes,
            String valor_total,
            String user)
        {
            if (id == "" || valor_prestamo == "" || dia_pago == "")
            {
                msn = "Debe diligenciar toda la información solicitada"; 
            }
            else
            {
                Cls_Credito_Datos ObjGuardar = new Cls_Credito_Datos();
                ObjGuardar.Fnt_Guardar(id, dia_pago, valor_prestamo, plazo, cuota, interes, valor_total, user);
                msn = "Credito creado con éxito";

            }
        }
    }
}
