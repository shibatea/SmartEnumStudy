namespace SmartEnumStudy.Fee
{
    public class ChildFee : IFee
    {
        public int Yen() => 500;

        public string Label() => "child";
    }
}