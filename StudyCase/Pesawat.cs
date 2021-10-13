using System;

namespace StudyCase
{
    public class Pesawat
    {

        public string Nama, Ketinggian, JumlahPenumpang;
        public int JumlahRoda;

        public void Terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.Nama);
        }

        public void SudahTerbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}, berada di ketinggian ", this.Ketinggian);
        }
    }
}