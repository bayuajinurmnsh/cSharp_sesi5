using System;

namespace StudyCase
{

    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            string ulang = "n";
           

            do{
                Console.WriteLine("Menu 1 untuk pesawat tempur ,\n2 untuk overload, \n3 untuk override , \n4 untuk about");
                Console.Write("Masukkan Pilihan : ");
                pilihan = int.Parse(Console.ReadLine());
                
                switch (pilihan)
                {
                    case 1:{
                        string nama_pesawat,ketinggian_pesawat,jlh_penumpang;
                        int jlh_roda;
                        Pesawat pst = new Pesawat();
                        PesawatTempur pst_tpr = new PesawatTempur();
                        
                        Console.Write("Masukkan Nama Pesawat            : ");
                        nama_pesawat = Console.ReadLine();

                        Console.Write("Masukkan Ketinggian Pesawat      : ");
                        ketinggian_pesawat = Console.ReadLine();

                        Console.Write("Masukkan Jumlah Penumpang        : ");
                        jlh_penumpang = Console.ReadLine();

                        Console.Write("Masukkan Jumlah Roda        : ");
                        jlh_roda = int.Parse(Console.ReadLine());
                        
                        pst.Nama = nama_pesawat;
                        pst.JumlahRoda = jlh_roda;
                        pst.Ketinggian = ketinggian_pesawat;
                        pst.JumlahPenumpang = jlh_penumpang;

                        pst_tpr.Nama = nama_pesawat;
                        pst_tpr.JumlahRoda = jlh_roda;
                        pst_tpr.Ketinggian = ketinggian_pesawat;
                        pst_tpr.JumlahPenumpang = jlh_penumpang;

                        pst.Terbang();
                        pst_tpr.TerbangTinggi();

                        break;
                    }
                    case 2:{
                        string nama;
                        double no_telp;

                        Overloaded over = new Overloaded();
                        Console.Write("Masukkan Nama            : ");
                        nama = Console.ReadLine();

                        Console.Write("Masukkan No Telp         : ");
                        no_telp = double.Parse(Console.ReadLine());
                        
                        over.print(nama);
                        over.print(no_telp);

                        break;
                    }case 3:{
                        int val1, val2, val3;

                        Overrided oride = new Overrided();

                        Console.Write("Masukkan Angka 1      : ");
                        val1 = int.Parse(Console.ReadLine());

                        Console.Write("Masukkan Angka 2      : ");
                        val2 = int.Parse(Console.ReadLine());

                        Console.Write("Masukkan Angka 3      : ");
                        val3 = int.Parse(Console.ReadLine());

                        oride.bilangan(val1,val2);
                        oride.penjumlahanperkalianll();
                        oride.penjumlahanperkalianll(val3);

                        break;
                    }case 4:{
                        About a = new About();

                        a.tentang();
                        break;
                    }
                    
                    default:{
                        break;
                    }
                }

                Console.Write("Kembali ke awal ? (y/n) ");
                ulang = Console.ReadLine();

            }while(ulang == "y");

        }
    }
}
