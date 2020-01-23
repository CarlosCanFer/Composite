using EjemploComposite.Interfaces;
using System;
using System.Collections.Generic;

namespace EjemploComposite
{
    public class UnidadAdministrativa : IComponente
    {
        List<IComponente> _ListaUA;
        string _cid;

        public UnidadAdministrativa(string cid)
        {
            this._cid = cid;
            _ListaUA = new List<IComponente>();
        }       

        public void AgregarComponente(IComponente componente)
        {
            this._ListaUA.Add(componente);
        }

        public decimal ObtenerTotal()
        {
            decimal total =0;

            foreach (IComponente componente in _ListaUA)
            {
                total += componente.ObtenerTotal();
            }
            return total;
        }
    }
}
