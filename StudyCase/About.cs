using System;

namespace StudyCase
{
    public class About
    {
        string nama = "Bayu Aji Nurmansah";
        string asal = "Kisaran, Asahan, Medan";
        string kesanPesan = "Belajar c# gampang gampang susah, tapi ya harus tetap di usahakan";
        string doa = "Semoga semua peserta berhasil jadi katap";

        public void tentang()
        {
            Console.WriteLine(nama);
            Console.WriteLine(asal);
            Console.WriteLine(kesanPesan);
            Console.WriteLine(doa);
        }
    }
}