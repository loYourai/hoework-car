


//var engine = new Engine();
//engine.Drive2();
//var wheels = new Wheels();
//wheels.Drive2();
//var lockcar = new Lockcar();
//lockcar.Drive2();


void Startengine()
{
    var engine = new Engine();
    engine.Drive2();
        Console.ReadLine();
}

void Lockyourcar()
{
    var lockcar = new Lockcar();
    lockcar.Drive2();
    Console.ReadLine();
}
void Unlockcar()
{
    
    var unlockcar = new UnLockcar();
    unlockcar.Drive2();
    Console.ReadLine();

}
void Menu()
{
    Console.Clear();
    Console.WriteLine("3. Start engine");
    Console.WriteLine("2. Lock car");
    Console.WriteLine("1. Unlock car");
}
while (true)
{
    Menu();
    var keyInfo = Console.ReadKey();
    switch (keyInfo.Key)
    {
        case ConsoleKey.D1:
            Unlockcar();
            break;
        case ConsoleKey.D2:
            Lockyourcar();
            break;
        case ConsoleKey.D3:
            Startengine();
            break;
        default: break;
    }
}

//var engine = new Engine("Mercedes", 2455);
//var wheels = new Wheels("Mercedes", 20);





//var engine1 = new Engine("Mercedes", 2455);
//var engine2 = new Engine("Bmw", 2635);



