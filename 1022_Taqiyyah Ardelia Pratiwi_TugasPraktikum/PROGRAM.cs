using System;

public class LAPTOP
{
    public string Merk;
    public string Tipe;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"LAPTOP DINYALAKAN = {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"LAPTOP DIMATIKAN = {Merk} {Tipe} mati\n");
    }
}

public class Vivobook : LAPTOP
{
    public string Vga;
    public string Processor;

    public void Ngoding()
    {
        Console.WriteLine("=========== Ngoding ===========");
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!\n");
    }
}

public class IdeaPad : LAPTOP
{
    public string Vga { get; set; }
    public string Processor;
}


public class Predator : IdeaPad
{
    public void BermainGame()
    {
        Console.WriteLine($"BERMAIN GAME = Laptop {Merk} {Tipe} sedang memainkan game");
    }
}

public class ACER : IdeaPad
{
    public new void BermainGame()
    {
        Console.WriteLine($"BERMAIN GAME = Laptop {Merk} {Tipe} sedang memainkan game");
    }
}

class PROGRAM
{
    static void Main(string[] args)
    {
        var LAPTOP1 = new Vivobook
        {
            Merk = "ASUS",
            Tipe = "Vivobook",
            Vga = "Nvidia",
            Processor = "Core i5"
        };

        var LAPTOP2 = new IdeaPad
        {
            Merk = "Lenovo",
            Tipe = "IdeaPad",
            Vga = "AMD",
            Processor = "Ryzen"
        };

        var PREDATOR = new Predator
        {
            Merk = "Acer",
            Tipe = "Predator",
            Vga = "AMD",
            Processor = "Core i7"
        };

        var Acer = new ACER
        {
            Merk = "Acer",
            Tipe = "Predator",
            Vga = "AMD",
            Processor = "Core i7"
        };

        LAPTOP1.LaptopDinyalakan();
        LAPTOP1.LaptopDimatikan();
        LAPTOP1.Ngoding();
        PREDATOR.BermainGame();
        Acer.BermainGame();
    }
}
