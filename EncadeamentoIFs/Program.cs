Console.Write("Escreva sua nota: ");

double nota = Convert.ToDouble(Console.ReadLine());
String m = "N/A";

if(nota >= 9.0) {
    if(nota > 10) {
        Console.WriteLine("Numero inválido");
    } else {
        m = "MB";
    }
} else if (nota >= 7.0) {
    m = "B";
} else if (nota >= 5.0) {
    m = "R";
} else {
    if(nota < 0) {
        Console.WriteLine("Numero inválido");
    } else {
        m = "I";
    }
}

Console.Write("Sua menção é: " + m);