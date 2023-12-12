//MohammadRezaFatahi
//T.me/SirNopo
using Practice88;
first:
List<Cow> Cows = new List<Cow>();
List<Sheep> Sheeps = new List<Sheep>();


Console.WriteLine("******************");
Console.WriteLine("Adad mored nazar ra vared konid");
Console.WriteLine("1 : Daramd Rozne");
Console.WriteLine("2 : Hazine Rozne");
Console.WriteLine("3 : Olavioyat Koshtar ");
Console.WriteLine("4 : Sood Rozane");
Console.WriteLine("5 : Daramd Rozne Az Goosht");
switch (Console.ReadLine())
{
    case "1":
        Income();
        goto first;
    case "2":
        Cost();
        goto first;
    case "3":
        KillPriority();
        goto first;
    case "4":
        Profit();
        goto first;
    case "5":
        MeatIncome();
        goto first;
    default:
        Console.WriteLine("Adad vared shode eshtebah mibashad");
        goto first;

}


void KillPriority()
{
    foreach (Cow cow in Cows.OrderByDescending(c => c.KillPriority()))
    {
        Console.WriteLine($"Name:{cow.Name} Koshtar:{cow.KillPriority()}");
    }

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.KillPriority()))
    {
        Console.WriteLine($"Name:{sheep.Name} Koshtar:{sheep.KillPriority()}");
    }
}

void Income()
{
    foreach (Cow cow in Cows.OrderByDescending(c => c.IncomePerDay()))
    {
        Console.WriteLine($"Name:{cow.Name} Income:{cow.IncomePerDay()}");
    }

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.IncomePerDay()))
    {
        Console.WriteLine($"Name:{sheep.Name} Income:{sheep.IncomePerDay()}");
    }
}

void Cost()
{

    foreach (Cow cow in Cows.OrderByDescending(c => c.CostPerDay()))
    {
        Console.WriteLine($"Name:{cow.Name} Hazine:{cow.CostPerDay()}");
    }

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.CostPerDay()))
    {
        Console.WriteLine($"Name:{sheep.Name} Hazine:{sheep.CostPerDay()}");
    }
}

void Profit()
{

    foreach (Cow cow in Cows.OrderByDescending(c => c.IncomePerDay() - c.CostPerDay()))
    {
        Console.WriteLine($"Name:{cow.Name} Sood:{cow.IncomePerDay() - cow.CostPerDay()} ");
    }

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.IncomePerDay() - s.CostPerDay()))
    {
        Console.WriteLine($"Name:{sheep.Name} Sood:{sheep.IncomePerDay() - sheep.CostPerDay()}");
    }
}

void MeatIncome()
{

    foreach (Cow cow in Cows.OrderByDescending(c => c.MeatIncome(350000m)))
    {
        Console.WriteLine($"Name:{cow.Name} Daramad az gosht:{cow.MeatIncome(350000m)}");
    }

    foreach (Sheep sheep in Sheeps.OrderByDescending(s => s.MeatIncome(500000m)))
    {
        Console.WriteLine($"Name:{sheep.Name} Daramad az gosht:{sheep.MeatIncome(500000m)}");
    }
}