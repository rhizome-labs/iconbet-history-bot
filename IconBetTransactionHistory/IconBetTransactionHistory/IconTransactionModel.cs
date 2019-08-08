
using System;

public class IconTransactionModel
{
    public Data[] data { get; set; }
    public string result { get; set; }
    public string description { get; set; }
}

public class Data
{
    public string txHash { get; set; }
    public string fromAddr { get; set; }
    public DateTime createDate { get; set; }
}
