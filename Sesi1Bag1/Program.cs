

namespace Sesi1Bag1
{
    static class Program
    {
        static void Main()
        {
            Console.Write("Nama: ");
            string? nama = Console.ReadLine();

            Console.Write("Umur: ");
            int umur = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Kota: ");
            string? kota = Console.ReadLine();

            Console.WriteLine($"Halo {nama} dari {kota}.");
            Console.WriteLine($"Tahun depan umur kamu {umur + 1} tahun.");

            Console.WriteLine("Halo " + nama + " dari " + kota + ".");
            Console.WriteLine("Tahun depan umur kamu " + (umur + 1) + " tahun.");

            //const double Phi = 3.14159;

            // Salah
            //Phi = 3.14;

            //Console.Write("Nama: ");
            //string nama = Console.ReadLine();

            //Console.Write("Umur: ");
            //int umur = int.Parse(Console.ReadLine());

            //Console.Write("Tinggi badan: ");
            //double tinggi = double.Parse(Console.ReadLine());

            //Console.Write("Berat badan: ");
            //double berat = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Nama: {nama}");
            //Console.WriteLine($"Umur: {umur} tahun");
            //Console.WriteLine($"Tinggi: {tinggi} cm");
            //Console.WriteLine($"Berat: {berat} kg");

            //ini komen 1 baris
            Console.ReadLine();
            /*
             ini komen multi line
            baris ke 2
            Console.WriteLine(
             */
        
        }
    }
}