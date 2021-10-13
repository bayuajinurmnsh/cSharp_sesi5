using System;

namespace StudyCase
{
    public class Overloaded
    {
        public string nama;
        public double no_telp;

        public void print(string nama)
        {
            this.nama = nama;
            Console.WriteLine("Namanya adalah : {0}", this.nama);
        }

        public void print(double nomor_telepon)
        {
            this.no_telp = nomor_telepon;
            Console.WriteLine("Nomor HP : {0}", this.no_telp);
        }

    }
}