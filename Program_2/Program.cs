using System;


namespace Program_2{


    class Program
    {
        public static void Main(string[] args)
        {
            string name;
            string high;

            Program_2.Pesawat airplane = new Program_2.Pesawat();

            Console.Write("Masukkan Nama Pesawat     : ");
            name = Console.ReadLine();

            Console.Write("Ketinggian Pesawat       : ");
            high = Console.ReadLine();

            airplane.nama = name;
            airplane.Ketinggian = high;

            airplane.terbang();
            airplane.sudahterbang();
            
        }
    }
}