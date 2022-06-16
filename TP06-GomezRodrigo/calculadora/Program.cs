namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int operacion, end = 1;

            Console.WriteLine("Ingrese un valor para inicializar la calculadora: ");
            valor=Convert.ToDouble(Console.ReadLine());
            var nuevaCalculadora = new Calculadora(valor);

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la operación que desea realizar [0]:SUMA - [1]:RESTA - [2]:MULTIPLICACIÓN - [3]:DIVISIÓN");
                Console.WriteLine($"El valor actual guardado es: {nuevaCalculadora.resultado}");
                operacion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero a operar: ");
                valor = Convert.ToDouble(Console.ReadLine());

                switch (operacion)
                {
                    case 0:
                        nuevaCalculadora.Sumar(valor);
                        break;

                    case 1:
                        nuevaCalculadora.Restar(valor);
                        break;

                    case 2:
                        nuevaCalculadora.Multiplicar(valor);
                        break;

                    case 3:
                        nuevaCalculadora.Dividir(valor);
                        break;
                }
                if (!(operacion == 3 && valor == 0))
                {
                    Console.WriteLine($"El valor guardado en la calculadora es: {nuevaCalculadora.resultado}");
                }
                Console.WriteLine("Desea continuar usando la calculadora? [0]:NO - [1]:SI");
                end = Convert.ToInt32(Console.ReadLine());
            } while (end == 1);
        }
    }
}
