using System;
using System.Collections.Generic;

namespace EjemploComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UA");
            UnidadAdministrativa objunidadAdministrativa = new UnidadAdministrativa("1");
            CP objcp1 = new CP("1", 34, 43);
            CP objcp2 = new CP("1.1", 234, 342);
            CP objcp3 = new CP("1.2", 67, 575);           
            ClavePresupuestal clavePresupuestal = new ClavePresupuestal();
            clavePresupuestal.RecuperarCuentasPres(objcp1);
            ClavePresupuestal clavePresupuestal2 = new ClavePresupuestal();
            clavePresupuestal2.RecuperarCuentasPres(objcp2);
            ClavePresupuestal clavePresupuestal3 = new ClavePresupuestal();
            clavePresupuestal3.RecuperarCuentasPres(objcp3);
            objunidadAdministrativa.AgregarComponente(clavePresupuestal);
            objunidadAdministrativa.AgregarComponente(clavePresupuestal2);
            objunidadAdministrativa.AgregarComponente(clavePresupuestal3);
            var resultado = objunidadAdministrativa.ObtenerTotal();
            Console.WriteLine("Total: " + resultado+"\n");

            UnidadAdministrativa objunidadAdministrativa2 = new UnidadAdministrativa("2");
            CP objcp4 = new CP("2", 23, 12);
            CP objcp5 = new CP("2.1", 90, 221);
            CP objcp6 = new CP("2.2", 56, 48);
            ClavePresupuestal clavePresupuesta4 = new ClavePresupuestal();
            clavePresupuesta4.RecuperarCuentasPres(objcp4);
            ClavePresupuestal clavePresupuestal5 = new ClavePresupuestal();
            clavePresupuestal5.RecuperarCuentasPres(objcp5);
            ClavePresupuestal clavePresupuestal6 = new ClavePresupuestal();
            clavePresupuestal6.RecuperarCuentasPres(objcp6);

            objunidadAdministrativa2.AgregarComponente(clavePresupuesta4);
            objunidadAdministrativa2.AgregarComponente(clavePresupuestal5);
            objunidadAdministrativa2.AgregarComponente(clavePresupuestal6);           
           
            var resultado2 = objunidadAdministrativa2.ObtenerTotal();                      
            Console.WriteLine("Total: " + resultado2);
            Console.ReadLine();

        }
    }
}
