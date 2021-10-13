using System;

namespace StudyCase
{
    public class Overrided
    {
        public int bil1, bil2;

        public void bilangan(int angka1, int angka2)
        {
            bil1 = angka1;
            bil2 = angka2;
        }

        public virtual void penjumlahanperkalianll()
        {
            Console.WriteLine("Overriding ");
            Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1}  = {2} ", bil1, bil2, bil1+bil2);
            Console.WriteLine("Hasil perkalian angka {0} dan angka {1}  = {2} ", bil1, bil2, bil1*bil2);
        }

        public virtual void penjumlahanperkalianll(int bil3)
        {
            Console.WriteLine("Overriding ");
            Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1}  = {2} ", bil1, bil3, bil1+bil3);
            Console.WriteLine("Hasil perkalian angka {0} dan angka {1}  = {2} ", bil1, bil3, bil1*bil3);
        }
    }
}