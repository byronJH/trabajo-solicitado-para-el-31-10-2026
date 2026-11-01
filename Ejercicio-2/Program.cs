namespace proyecto_gamma_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre: ");
                 string Nombre = Console.ReadLine();

            Console.Write("ingrese el apellido: ");
                  string Apellido = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
                  string Clave = Console.ReadLine();

        
            string Usuario = GenerarUsuario(Nombre, Apellido);

            bool Validacion = ClaveValida(Clave, Usuario);

            MostrarCuenta(Usuario, Validacion);

        }

        static string GenerarUsuario(string Nombre, string Apellido)
        {
            string usuario = Nombre.Substring(0, 1).ToLower() + Apellido.ToLower();
        
            return usuario;
        }


        static bool ClaveValida(string Clave, string Usuario)
        {
            return Clave.Length >= 8 && !Clave.ToLower().Contains(Usuario.ToLower());
        }

        static void MostrarCuenta(string Usuario, bool Validacion)
        {
            Console.WriteLine($"Nombre de usuario: {Usuario}");

            if (Validacion)
            {
                Console.WriteLine("La contraseña es valida");
            }
            else
            {
                Console.WriteLine("La contraseña no es valida");
            }


        }

    }
}
