using EjemploComposite.Interfaces;
using System;

namespace EjemploComposite
{
    public class ClavePresupuestal : IComponente
    {
        private CP  DatosCuentaPresupuestal;
        public void RecuperarCuentasPres(CP _cP)
        {
            this.DatosCuentaPresupuestal = _cP;
        }

        public decimal ObtenerTotal()
        {
            Console.WriteLine(DatosCuentaPresupuestal._cid);
          return DatosCuentaPresupuestal._dEnero + DatosCuentaPresupuestal._dFebrero;
        }
    }
}
