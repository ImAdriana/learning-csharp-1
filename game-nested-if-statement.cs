// REGLAS
// Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
// Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
// Si la suma de los tres dados, junto con los puntos extra, es igual o mayor que 16, gana el juego. De lo contrario, pierde.

// PREMIOS
// Si el jugador obtiene una puntuación igual o mayor que 16, gana un coche nuevo.
// Si el jugador obtiene una puntuación igual o mayor que 10, gana un portátil nuevo.
// Si el jugador obtiene una puntuación de 7, gana un viaje.
// De lo contrario, el jugador gana un gatito.

Random value = new();

int roll1 = value.Next(1, 7);
int roll2 = value.Next(1, 7);
int roll3 = value.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Values: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}


if (total >= 16)
{
    Console.WriteLine("Congratulations, you win a car!");
}
else if (total >= 10)
{
    Console.WriteLine("Hey, not bad. Here is your new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("Now you can take a rest with this trip");
}
else
{
    Console.WriteLine("You win a kitten");

}
