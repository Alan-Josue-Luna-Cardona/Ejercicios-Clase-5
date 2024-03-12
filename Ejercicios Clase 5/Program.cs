static int analizis(int x, int max, int min)
{
    do
    {
        Console.WriteLine("Ingrese un número: ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x > max)
            max = x;
        if (x < min && x > 0)
            min = x;
    } while (x != 0);
    Console.WriteLine("El número mayor fue " + max);
    Console.WriteLine("El número minimo fue " + min);
    Console.WriteLine("----------------------------------------");
    return x;
}
static int adivinar(int k)
{
    Console.WriteLine("Piense en un número cualquiera.");
    Console.WriteLine("Ahora multipliquelo por 2.");
    Console.WriteLine("Ahora sumele 8.");
    Console.WriteLine("Ahora multipliquelo por 5.");
    Console.WriteLine("Digame el resultado: ");
    string z = Console.ReadLine();
    int cont = z.Length;
    if (cont > 2)
    {
        string h = z.Remove(2);
        k = Convert.ToInt32(h);
        k = k - 4;
    }
    if (cont <= 2)
    {
        string h = z.Remove(1);
        k = Convert.ToInt32(h);
        k = k - 4;
    }
    return k;
}
static string contador(string frase)
{
    frase.ToLower();

    int contvo = 0, contlet = 0, contcons;
    foreach (char caracter in frase)
    {
        if ("aeiouAEIOU".Contains(caracter))
        {
            contvo++;
        }
    }
    foreach (char caracter in frase)
    {
        if (char.IsLetter(caracter))
        {
            contlet++;
        }
    }
    contcons = contlet - contvo;
    Console.WriteLine("El número de letras en la cadena texto es de: " + contlet);
    Console.WriteLine("El número de vocales en la cadena texto es de: " + contvo);
    Console.WriteLine("El número de consonantes en la cadena texto es de: " + contcons);
    Console.WriteLine("----------------------------------------");
    return frase;
}
static bool palindromo(bool igual)
{
    Console.Write("Ingresa una palabra: ");
    string pal = Console.ReadLine();

    char[] ca = pal.ToCharArray();
    Array.Reverse(ca);
    string rev = new string(ca);

    igual = pal.Equals(rev);
    Console.WriteLine(igual);

    if (igual == true)
        Console.WriteLine("La palabra " + pal + " SI es un palindromo.");
    Console.WriteLine("----------------------------------------");
    if (igual == false)
        Console.WriteLine("La palabra " + pal + " NO es un palindromo.");
    Console.WriteLine("----------------------------------------");
    return igual;
}


int opp;
do { 
    Console.WriteLine("Seleccione una opción: \n1.Valores Positivos. \n2.Adivinador de números. \n3.Contador de palabras. \n4.Palíndromo \n0.Salir  ");
    opp = Convert.ToInt32(Console.ReadLine());

    switch (opp)
    {
        case 1:
            int vp = analizis(1, 1, 100000);
            break;
        case 2:
            int adiv = adivinar(0);
            Console.WriteLine("Su número es: " + adiv);
            Console.WriteLine("Si ese no era su número. Entonces usted no sabe matematicas");
            Console.WriteLine("----------------------------------------");
            break;
        case 3:
            Console.WriteLine("Ingrese una cadena de texto: ");
            string FI = Console.ReadLine();
            string CF = contador(FI);
            break;
        case 4:
            bool dromo = palindromo(false);
            break;
        default:
            Console.WriteLine("Opcion Invalida.");
            Console.WriteLine("----------------------------------------");
            break;
    }
}while(opp != 0);   