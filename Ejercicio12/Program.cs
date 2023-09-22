namespace ejercicio12
{
    public class program
    {
        static void Main(string[] Args)

        //Programe un algoritmo que pida a usuario 2 números por
        //pantalla y que muestre todos los números comprendidos
        //entre ambos números incluyéndolos.
        {
            // declaracion de variables

            int num1, num2, min, max, salida;
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

            salida = min;

            while (salida <= max)
            {
                Console.Write(string.Format("{0} ", salida));
                salida++;
            }

        }
    }
}