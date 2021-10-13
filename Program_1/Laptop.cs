using System;


    class Laptop
    {
        public string merk;
        public int ram,memory;
        public float harga;

        public void Chatting()
        {
            Console.WriteLine("\n{0} sedang chatting", this.merk);
        }

        public void Sosmed()
        {
            Console.WriteLine("\n{0} sedang sosmed", this.merk);
        }

        public void OnlineShop()
        {
            Console.WriteLine("\n{0} sedang online shop", this.merk);
        }

        public void Merk()
        {
            Console.WriteLine("\nMerk Laptop adalah {0}", this.merk);
        }

        public void Ram()
        {
            Console.WriteLine("Kapasitas ram {0} GB", this.ram);
        }

        public void Memory()
        {
            Console.WriteLine("Kapasitas memory adalah {0} GB", this.memory);
        }

        public void Harga()
        {
            Console.WriteLine("Harga laptop adalah {0} juta rupiah", this.harga);
        }

    }
