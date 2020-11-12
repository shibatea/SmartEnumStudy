using Ardalis.SmartEnum;

namespace SmartEnumStudy.Fee
{
    public sealed class SmartFeeType : SmartEnum<SmartFeeType>
    {
        public static readonly SmartFeeType Adult = new SmartFeeType(nameof(Adult), 1, new AdultFee());
        public static readonly SmartFeeType Child = new SmartFeeType(nameof(Child), 2, new ChildFee());

        private readonly IFee _fee;

        public SmartFeeType(string name, int value, IFee fee) : base(name, value)
        {
            _fee = fee;
        }

        public int Yen()
        {
            return _fee.Yen();
        }

        public string Label()
        {
            return _fee.Label();
        }
    }
}