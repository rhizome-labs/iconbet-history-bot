
using System;

public class IconBetModel
{
    public Data[] data { get; set; }
    public int listSize { get; set; }
    public int totalSize { get; set; }
    public string result { get; set; }
    public string description { get; set; }
    public string pageCount { get; set; }
}

public class Data
{
    public string txHash { get; set; }
    public int height { get; set; }
    public DateTime createDate { get; set; }
    public string fromAddr { get; set; }
    public string toAddr { get; set; }
    public string txType { get; set; }
    public object dataType { get; set; }
    public string amount { get; set; }
    public string fee { get; set; }
    public int state { get; set; }
    public object errorMsg { get; set; }
    public string targetContractAddr { get; set; }
    public object id { get; set; }
}
