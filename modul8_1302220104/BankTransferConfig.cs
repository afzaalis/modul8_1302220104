using System.Text.Json;
using static modul8_1302220104.BankTransferConfig;

namespace modul8_1302220104;

public class BankTransferConfig
{
    public string lang { get; set; }
    public TransferClass transfer { get; set; }
    public string[] methods { get; set; }
    public ConfirmationClass confirmation { get; set; }

    public class TransferClass
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }
    public class ConfirmationClass
    {
        public string en { get; set; }
        public string id { get; set; }
    }
}

public class BankTransferAppConfig
{
    public BankTransferConfig config;
    private const String file_path = "bank_transfer_config.json";

    private void ReadConfigFile()
    {
        string configJsonData = File.ReadAllText(file_path);
        config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
    }

    private void WriteNewConfigFile()
    {
        JsonSerializerOptions option = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(config, option);
        File.WriteAllText(file_path, jsonString);
    }

    private void SetDefault()
    {
        config = new BankTransferConfig();

        config.lang = "en";
        TransferClass transfer = new();
        transfer.threshold = 25000000;
        transfer.low_fee = 6500;
        transfer.high_fee = 15000;
        config.transfer = transfer;
        config.methods = new string[] { "RTO (real-time)", "SKN", "RTGS", "BI FAST" };
        ConfirmationClass confirmation = new();
        confirmation.en = "yes";
        confirmation.id = "ya";
        config.confirmation = confirmation;
    }

    public BankTransferAppConfig()
    {
        try
        {
            ReadConfigFile();
        }
        catch
        {
            SetDefault();
            WriteNewConfigFile();
        }
    }
}