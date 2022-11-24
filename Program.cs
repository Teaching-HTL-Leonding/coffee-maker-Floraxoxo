Console.OutputEncoding = System.Text.Encoding.Default;

Console.Clear();
Console.ResetColor();

const decimal CAPPUCCINO = 3.5m; //price of the products
const decimal CACAO = 2.5m;
const decimal TEA = 1.5m;

decimal money = 0;
decimal cost = 0;
decimal five_cent = 0;
decimal two_coins = 0;
decimal one_coin = 0;
string coffee_type;
bool enough_money = true;


Console.WriteLine("Welcome to the Coffee Machine simulator");

do
{
    Console.WriteLine("Please enter the amount of money you have (multiple of 0.5)"); 
    money = decimal.Parse(Console.ReadLine()!);

    if (money % 0.5m != 0)
    {
        Console.WriteLine("The amount of money you entered isn't a multiple of 0.5! Please try again.");
    }
} while (money % 0.5m != 0); //

do
{
    Console.WriteLine("What do you want to buy?");
    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("A [Cappuccino] ☕ 3.5€, "); 
    Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("A [Cacao] 🥛 2.5€, "); 
    Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("a cup of [Tea] 🍵 1.5€ "); 
    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("or [nothing]");
    Console.ResetColor(); coffee_type = Console.ReadLine()!.ToLower();

    Console.ResetColor();

    switch (coffee_type)
    {
        case "cappuccino":
            cost = CAPPUCCINO;
            break;
        case "cacao":
            cost = CACAO;
            break;
        case "tea":
            cost = TEA;
            break;
        default:
            break;
    }

    if (cost <= money && coffee_type != "nothing")
    {
        money = money - cost;
    }
    else if (coffee_type != "nothing")
    {
        Console.WriteLine("You don't have enough money!");
        enough_money = false;
    }

} while (coffee_type != "nothing" && enough_money == true);

if (money!= 0)
{
    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"You get {money}$ back 😎"); Console.ResetColor();
    if (money / 2 >= 1)
    {
        two_coins = Math.Floor(money / 2); money -= two_coins * 2;
        if (money / 1 >= 1)
        {
            one_coin = Math.Floor(money / 1); money -= one_coin;
        }
    }

    if (money > 0)
    {
        five_cent = 1;
    }

    Console.WriteLine($"You get {two_coins}x2$ pieces");
    Console.WriteLine($"You get {one_coin}x1$ pieces");
    Console.WriteLine($"You get {five_cent}x0.5$ pieces");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You don't get any money back 🥰");
}

Console.ReadKey();
Console.Clear();