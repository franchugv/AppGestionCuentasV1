using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum MenuAddCuentas : byte { Salir, CuentaJoven, CuentaOro, CuentaPlatino }


namespace AppGestionCuentasV1.AgregarCuentas
{
    public static class UIAddCuentas
    {

        public static void MostrarMenuAddCuentas()
        {
            Console.WriteLine("\t\t MENÚ - Agregar Cuentas Bancarias");

            Console.WriteLine("\t\t 0 - Salír");
            Console.WriteLine("\t\t 1 - Cuenta Joven");
            Console.WriteLine("\t\t 2 - Cuenta Oro");
            Console.WriteLine("\t\t 3 - Cuenta Platino");
            Console.WriteLine("\n\t\t Seleccione Tipo de Cuenta: ");
        }

    public static MenuAddCuentas CaptarOpcion()
    {

          int size = Enum.GetNames<MenuAddCuentas>().Length;

        return MenuAddCuentas.Salir;
    }

    }
}
