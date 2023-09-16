namespace ejercicio12
{
    public class program
    {
        static void Main(string[] Args)
        {
            // declaracion de variables

            int num1, num2, min, max;
            const string mensaje = "Por favor ingresar un numero entero valido";
            bool retorno = false;

            // pedir datos

            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine(mensaje);
                    retorno = true;
                }
            }
            while (retorno);

            do
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine(mensaje);
                    retorno = true;
                }
            }
            while (retorno);

            //calculos

            min = Math.Min(num1, num2);
            max = Math.Max(num1, num2);



        }
    }
}