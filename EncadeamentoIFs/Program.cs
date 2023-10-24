Console.Write("Escreva sua nota: ");

int nota = Convert.ToInt32(Console.ReadLine());
String m;
if(nota >= 9) {
    m = "MB";
} else if (nota >= 7) {
    m = "B";
} else if (nota >= 5) {
    m = "R";
} else {
    m = "I";
}

Console.Write("Sua menção é: " + m);

