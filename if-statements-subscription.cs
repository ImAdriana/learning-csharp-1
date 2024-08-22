// REGLAS
// Si la suscripción del usuario expira en 10 días o menos
// Si la suscripción del usuario expira en 5 días o menos
// Si la suscripción del usuario expira en un día
// Si la suscripción del usuario ha expirado
// Si la suscripción del usuario no expira en 10 días o menos, no muestre ningún mensaje

Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
