using AppGestionCuentasV1.AgregarCuentas;
using AppGestionCuentasV1.Principal;
using R24_JesusCG_V1;

namespace AppGestionCuentasV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RECURSOS APLICACIÓN

            List<Cuenta> listaCuentas = new List<Cuenta>();
            MenuPrincipal opcion = MenuPrincipal.Salir;

            // MENÚ principal


            do
            {

                UIPrincipal.MostrarMenu();

                opcion = UIPrincipal.CaptarOpcion();

                switch (opcion)
                {
                    case MenuPrincipal.Salir: 
                        // TODO: Salir
                        break;
                    case MenuPrincipal.AgregarCuenta:
                        // TODO: Añadir Cuentas
                        ControlAddCuentas.ControladorAddCuentas(listaCuentas);
                        break;
                    case MenuPrincipal.ModificarCuenta: 
                        // TODO:  Modificar Cuentas
                        break;
                    case MenuPrincipal.EliminarCuenta: 
                        // TODO:  Eliminar Cuentas
                        break;
                    case MenuPrincipal.CosularCuenta: 
                        // TODO: Consultar Cuentas
                        break;
                }

            } while (opcion != MenuPrincipal.Salir);


        }
    }
}
