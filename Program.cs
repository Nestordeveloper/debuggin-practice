// Challenge 1
bool amProgrammer = true;
// 1) Eliminar las comillas dobles ya que estaba implicitamente siendo usado como string
double Age = 27.9;
// 2) Cambiar el tipo de valor utilizado de Int a Double
List<string> Names = new List<string>();
Names.Add("Monica");
// Reemplazar la forma en la que se añade un valor dentro de una lista, ya que se 
// estaba asignando un string a la variable Names en lugar de añadir.
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "1");
// Se reemplaza el valor int que había en el valor del diccionario por un string.
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "Nestor"; // Reemplazar la comilla simple con dobles para usar string
char MyNameC = 'N';// O Puede reemplazarse por un caracter y usar char
// Challenge 2
List<int> Numbers = new List<int>() { 2, 3, 6, 7, 1, 5 };
for (int i = Numbers.Count - 1; i >= 0; i--) // El indice debe comenzar desde el count - 1 para que acceda al último valor de la lista
{
    Console.WriteLine(Numbers[i]);
}
// Challenge 3
List<int> MoreNumbers = new List<int>() { 12, 7, 10, -3, 9 };
foreach (int num in MoreNumbers) // Reemplazamos int i por int num para representar cada elemento de la lista
{
    Console.WriteLine(num);// Reemplazamos el MoreNumbers[i] por num en su lugar para usar y acceder a los elementos de la lista
}
// Challenge 4
List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
for (int idx = 0; idx < EvenMoreNumbers.Count; idx++)
{
    if (EvenMoreNumbers[idx] % 3 == 0) // Accedemos a la lista y la modificamos utilizando el indice del bucle para acceder a ese valor especifico y cambiarlo
    {
        EvenMoreNumbers[idx] = 0;
    }
}
// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
// MyString[7] = "p";
// Los string son inmutables, por lo que no podemos modificar su valor usando un indice.
// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12); // Esto devuelve un número aleatorio entre 0 y 11, el 12 no esta contemplado
Console.WriteLine(randomNum); // Se imprime en pantalla para ver el número que esta arrojando.
if (randomNum == 11) // Conforme a lo de arriba se modifica para que cumpla la condición.
{
    Console.WriteLine("Hello");
}

