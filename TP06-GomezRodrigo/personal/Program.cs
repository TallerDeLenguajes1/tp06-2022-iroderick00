namespace personal
{
    internal class Program
    {
        static void cargar (Empleado empleado)
        {
            string nombre, apellido, fechaNacimiento;
            char estadoCivil, genero;

            Console.WriteLine("Nombre: ");
            empleado.nombre= Console.ReadLine();
            Console.WriteLine("Apellido: ");
            empleado.apellido = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento dd/mm/aaaa: ");
            empleado.fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Estado civil [c]:casado [s]:soltero [v]:viudo: ");
            empleado.estadoCivil = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Genero [m]:masculino [f]:femenino: ");
            empleado.genero = Convert.ToChar(Console.ReadLine());
        }
        static void mostrar (Empleado empleado)
        {
            int antiguedad = 0, edad = 0, jubilacion = 0;
            antiguedad = empleado.Antiguedad(empleado.fechaIngreso);
            edad = empleado.Edad(DateTime.Now);
            jubilacion = empleado.jubilacion(antiguedad, edad);
            Console.WriteLine($"Nombre: {empleado.nombre}");
            Console.WriteLine($"Apellido: {empleado.apellido}");
            Console.WriteLine($"Fecha de nacimiento: {empleado.fechaNacimiento}");
            Console.WriteLine($"Fecha de ingreso: {empleado.fechaIngreso}");
            Console.WriteLine($"Estado Civil: {empleado.estadoCivil}");
            Console.WriteLine($"Genero: {empleado.genero}");
            Console.WriteLine($"Sueldo total: {empleado.Salario(antiguedad)}");
            if (jubilacion == 0)
            {
                Console.WriteLine("El empleado ya puede jubilarse.");
            }
            else
            {
                Console.WriteLine($"A este empleado le faltan {jubilacion} años para jubilarse.");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a cargar 3 empleados.");
            Console.WriteLine("Ingrese los datos del primer empleado: ");
            var empleado1 = new Empleado();
            cargar(empleado1);
            //Console.WriteLine("Ingrese los datos del segundo empleado: ");
            //var empleado2 = new Empleado();
            //cargar (empleado2);j
            //Console.WriteLine("Ingrese los datos del tercer empleado: ");
            //var empleado3 = new Empleado();
            //cargar(empleado3);
            Console.WriteLine("Ahora vamos a mostrar los datos cargados de los 3 empleados");
            Console.WriteLine("Empleado 1: ");
            mostrar(empleado1);
            //Console.WriteLine("Empleado 2: ");
            //mostrar (empleado2);
            //Console.WriteLine("Empleado 3: ");
            //mostrar(empleado3);
        }
    }
}