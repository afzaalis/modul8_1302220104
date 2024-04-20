using System.Numerics;
using modul8_1302220104;

BankTransferAppConfig configApp = new BankTransferAppConfig();

string lang = configApp.config.lang;

if (lang == "en")
{
    Console.WriteLine("Please insert the amount of money to transfer");
}
else if (lang == "id")
{
    Console.WriteLine("Masukan jumlah uang yang akan di-transfer");
}
int nominal_transfer = int.Parse(Console.ReadLine());

int biaya_transfer =
    (nominal_transfer > configApp.config.transfer.threshold)
    ? configApp.config.transfer.high_fee
    : configApp.config.transfer.low_fee;

if (lang == "en")
{
    Console.WriteLine($"transfer fee = {biaya_transfer}");
    Console.WriteLine($"total amount = {nominal_transfer + biaya_transfer}");
    Console.WriteLine("\nSelect transfer method:");
}
else if (lang == "id")
{
    Console.WriteLine($"Biaya transfer = {biaya_transfer}");
    Console.WriteLine($"Total biaya = {nominal_transfer + biaya_transfer}");
    Console.WriteLine("\nPilih metode transfer:");
}

for (int i = 0; i < configApp.config.methods.Length; i++)
{
    Console.WriteLine((i + 1) + ". " + configApp.config.methods[i]);
}
Console.ReadLine();

Console.WriteLine();
if (lang == "en")
{
    Console.WriteLine($"Please type {configApp.config.confirmation.en} to confirm the transaction");
}
else if (lang == "id")
{
    Console.WriteLine($"Ketik {configApp.config.confirmation.id} untuk mengonfirmasi transaksi");
}
string konfirmasi = Console.ReadLine();

if (lang == "en")
{
    Console.WriteLine(
        (konfirmasi == configApp.config.confirmation.en)
        ? "The transfer is completed"
        : "Transfer is cancelled");
}
else if (lang == "id")
{
    Console.WriteLine(
            (konfirmasi == configApp.config.confirmation.id)
            ? "Proses transfer berhasil"
            : "Transfer dibatalkan");
}