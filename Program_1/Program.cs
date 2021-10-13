using System;


namespace Program_1
{

    class Program
    {
        public static void Main(string[] args)
        {
            string merk;
            int ram, memory;
            float harga;

            Laptop pc = new Laptop();

            Console.Write("Masukkan merk laptop         : ");
            merk = Console.ReadLine();

            Console.Write("Masukkan total ram (GB)      : ");
            ram = int.Parse(Console.ReadLine());

            Console.Write("Masukkan total memory (GB)   : ");
            memory = int.Parse(Console.ReadLine());

            Console.Write("Harga Laptop (juta)          : ");
            harga = float.Parse(Console.ReadLine());

            pc.merk = merk;
            pc.ram = ram;
            pc.memory = memory;
            pc.harga = harga;

            pc.Chatting();
            pc.Sosmed();
            pc.OnlineShop();

            pc.Merk();
            pc.Ram();
            pc.Memory();
            pc.Harga();

        }
}
}
