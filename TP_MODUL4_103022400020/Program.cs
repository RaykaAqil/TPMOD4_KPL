// See https://aka.ms/new-console-template for more information
using TP_MODUL4_103022400020;

class Program
{
    static void Main(string[] args)
    {
        KodePos.Kelurahan kelurahan1 = KodePos.Kelurahan.Batununggal;
        int kodePosHasil1 = KodePos.GetKodePos(kelurahan1);

        Console.WriteLine("Nama Kelurahan : " + kelurahan1.ToString());
        Console.WriteLine("Kode Pos : " + kodePosHasil1);

        KodePos.Kelurahan kelurahan2 = KodePos.Kelurahan.Kujangsari;
        int kodePosHasil2 = KodePos.GetKodePos(kelurahan2);

        Console.WriteLine("Nama Kelurahan : " + kelurahan2.ToString());
        Console.WriteLine("Kode Pos : " + kodePosHasil2);

        DoorMachine pintu = new DoorMachine();

        Console.WriteLine("\nMembukaPintu");
        pintu.AktivasiTrigger(DoorMachine.Trigger.BukaPintu);

        Console.WriteLine("\nMengunciPintu");
        pintu.AktivasiTrigger(DoorMachine.Trigger.KunciPintu);
    }
}
