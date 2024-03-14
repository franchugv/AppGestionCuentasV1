using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCuentasV1.Principal
{
    public enum MenuPrincipal : byte { Salir, AgregarCuenta, EliminarCuenta, ModificarCuenta, CosularCuenta }

    /// <summary>
    /// Clase que proporciona los métodos de interacción de la Interfaz Principal
    /// </summary>
    public static class UIPrincipal
    {
        public static void MostrarMenu()
        {

        }
        public static MenuPrincipal CaptarOpcion() 
        {
            // TODO: evaluar tipo de la oopción a devolver
            return 0;
        }
    }
}
