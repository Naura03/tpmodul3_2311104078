using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan nama kelurahan:");
        string? kelurahan = Console.ReadLine(); // Pakai nullable string (string?)

        // Jika kelurahan null atau kosong, berikan nilai default "Tidak diketahui"
        kelurahan = kelurahan ?? "Tidak diketahui";

        // Memanggil method getKodePos() dari class KodePos
        string kodePos = KodePos.getKodePos(kelurahan);

        Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");
    }
}
