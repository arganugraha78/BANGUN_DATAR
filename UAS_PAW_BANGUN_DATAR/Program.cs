using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PILIHAN_BANGUN_DATAR
{
    public class Segitiga
    {
        double alas, tinggi;
        public void InputSegitiga()
        {
            Console.Write("Masukan Alas= ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Tinggi= ");
            tinggi = Convert.ToDouble(Console.ReadLine());

        }
        public double LuasSegi(Double a, Double t)
        {
            return 0.5 * a * t;
        }
        public void HasilSegi()
        {
            Console.Write("Luas Segitiga = " + this.LuasSegi(alas, tinggi));
            Console.ReadKey();
        }
    }
    public class Persegi
    {
        double sisi;
        public void InputPersegi()
        {
            Console.Write("Masukan Sisi= ");
            sisi = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasPer(Double s)
        {
            return s * s;
        }
        public void HasilPersegi()
        {
            Console.Write("Luas Persegi = " + this.LuasPer(sisi));
            Console.ReadKey();
        }
    }
    public class PersegiPanjang
    {
        double panjang, lebar;
        public void InputPP()
        {
            Console.Write("Masukan Panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan Lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasPP(Double p, Double l)
        {
            return p * l;
        }
        public void HasilPP()
        {
            Console.Write("Luas Persegi Panjang = " + this.LuasPP(panjang, lebar));
            Console.ReadKey();
        }
    }
    public class Lingkaran
    {
        double jari;
        public void InputLk()
        {
            Console.Write("Masukan jari-jari = ");
            jari = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasLk(Double r)
        {
            return 3.14 * r * r;
        }
        public void HasilLk()
        {
            Console.Write("Luas Lingkaran = " + this.LuasLk(jari));
            Console.ReadKey();
        }
    }
    public class SwitchCase
    {
        static void Main(string[] args)
        {
            Segitiga sg = new Segitiga();
            Persegi ps = new Persegi();
            PersegiPanjang pp = new PersegiPanjang();
            Lingkaran lk = new Lingkaran();

            int chois;

            Console.WriteLine("PILIHAN BANGUN DATAR");
            Console.WriteLine("=====================");
            Console.WriteLine("1.Segitiga");
            Console.WriteLine("2.Persegi");
            Console.WriteLine("3.Persegi Panjang");
            Console.WriteLine("4.Lingkaran");
            Console.WriteLine("5.Keluar");
            Console.WriteLine("Pilih [1/2/3/4/5]");
            Console.WriteLine("Masukan Pilihan= ");
            chois = Convert.ToInt32(Console.ReadLine());

            switch (chois)
            {
                case 1:
                    sg.InputSegitiga();
                    sg.HasilSegi();
                    break;
                case 2:
                    ps.InputPersegi();
                    ps.HasilPersegi();
                    break;
                case 3:
                    pp.InputPP();
                    pp.HasilPP();
                    break;
                case 4:
                    lk.InputLk();
                    lk.HasilLk();
                    break;
                case 5:
                    break;

                default:
                    Console.WriteLine("PILIHAN SALAH!");
                    Console.ReadKey();
                    break;
            }
        }

    }



}
