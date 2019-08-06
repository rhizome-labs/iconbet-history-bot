
public class TransactionResultModel
{
    public Scoreaddress ScoreAddress { get; set; }
    public string[] Indexed { get; set; }
    public string[] Data { get; set; }
}

public class Scoreaddress
{
    public int[] Binary { get; set; }
    public int Size { get; set; }
    public string Prefix { get; set; }
}
