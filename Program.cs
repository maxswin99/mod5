using System.ComponentModel.Design.Serialization;
using System.Globalization;


public class Program
{
    class PemrosesanData
    {
        public int DapatkanNilaiTerbesar<T>(T input1, T input2, T input3)
        {
            dynamic nilai1 = input1;
            dynamic nilai2 = input2;
            dynamic nilai3 = input3;
            dynamic nilaiTerbesar = input1;
            if (nilai1 > input2)
            {
                nilaiTerbesar = input1;
            }
            else if (nilai2 > input1 && nilai2 > input3)
            {
                nilaiTerbesar = input2;
            }
            else
            {
                nilaiTerbesar = input3;
            }
            return nilaiTerbesar;
        }

    }
    public static void Main()
    {
        PemrosesanData pemrosesanData = new PemrosesanData();
        int x1, x2, x3;
        System.Console.WriteLine("Masukkan nilai 1: ");
        x1 = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Masukkan nilai 2: ");
        x2 = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Masukkan nilai 3: ");
        x3 = int.Parse(System.Console.ReadLine());

        int nilaiTerbesar = pemrosesanData.DapatkanNilaiTerbesar(10, 20, 30);
        System.Console.WriteLine("Nilai terbesar adalah: " + nilaiTerbesar);
    }
}