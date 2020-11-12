namespace SmartEnumStudy.Fee
{
    public class AdultFee : IFee
    {
        public int Yen() => 1000;

        public string Label() => "Adult";
    }
}