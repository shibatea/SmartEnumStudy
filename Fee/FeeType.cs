using SmartEnumStudy.SeedWork;

namespace SmartEnumStudy.Fee
{
    /// <summary>
    ///     区分オブジェクト
    ///     列挙型クラスで振る舞いを表現する
    ///     区分毎の振る舞いはコンストラクターで受け取ったオブジェクトに委譲する
    /// </summary>
    public sealed class FeeType : Enumeration
    {
        public static readonly FeeType Adult = new FeeType(1, nameof(Adult), new AdultFee());
        public static readonly FeeType Child = new FeeType(2, nameof(Child), new ChildFee());

        private readonly IFee _fee;

        public FeeType(int id, string name, IFee fee) : base(id, name)
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