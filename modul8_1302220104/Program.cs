// See https://aka.ms/new-console-template for more information
using System.Numerics;
using modul8_1302220104;

BankTransferAppConfig configAPP = new BankTransferAppConfig();

string lang = configAPP.config.lang;

if (lang == "en")
{
    Console.WriteLine("please insert amount of money to transfer:");
}else if  (lang == "id")
{
    Console.WriteLine("masukan jumlah uang untuk ditransfer:");
}

int nom_tf = int.Parse(Console.ReadLine());

int biaya_tf =
    (nom_tf > configAPP.config.transfer.threshold) ? configAPP.config.transfer.threshold : nom_tf;

if (lang == "eng")
{
    Console.WriteLine($"transfer fee :{biaya_tf}");
    Console.WriteLine($"total amount :{nom_tf}");

    Console.WriteLine("select transfer method:");
}else if (lang == "id")
{
    Console.WriteLine($"biaya transfer :{biaya_tf}");
    Console.WriteLine($"nominal transfer :{nom_tf}");

    Console.WriteLine("pilih methode transfer:");
}

for (int i = 0; i < configAPP.config.transfer.threshold; i++)
{
    
}