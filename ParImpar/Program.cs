Console.WriteLine("Digite um numero e verifique se ele é impar ou par!");
Console.WriteLine("___________________________________________________\n");
Console.Write("Seu numero: ");

int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 1) {
    Console.WriteLine("O numero " + number + " é impar");
} else {
    Console.WriteLine("O numero " + number + " é par");
}