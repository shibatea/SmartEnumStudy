using Ardalis.SmartEnum;

namespace SmartEnumStudy
{
    /// <summary>
    ///     switch 文を使わずに、区分毎に "振る舞い" を持たせることができる
    /// </summary>
    public abstract class EmployeeType : SmartEnum<EmployeeType>
    {
        public static readonly EmployeeType Manager = new ManagerType();
        public static readonly EmployeeType Assistant = new AssistantType();

        private EmployeeType(string name, int value) : base(name, value)
        {
        }

        public abstract decimal BonusSize { get; }

        public abstract string Label();

        private sealed class ManagerType : EmployeeType
        {
            public ManagerType() : base("Manager", 1)
            {
            }

            public override decimal BonusSize => 10_000m;

            public override string Label()
            {
                return "Manager's bonus is";
            }
        }

        private sealed class AssistantType : EmployeeType
        {
            public AssistantType() : base("Assistant", 2)
            {
            }

            public override decimal BonusSize => 1_000m;

            public override string Label()
            {
                return "Assistant's bonus is";
            }
        }
    }
}