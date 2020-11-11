using Ardalis.SmartEnum;

namespace SmartEnumStudy
{
    /// <summary>
    ///     基本的な定義
    /// </summary>
    public sealed class TestEnum : SmartEnum<TestEnum>
    {
        public static readonly TestEnum One = new TestEnum(nameof(One), 1);
        public static readonly TestEnum Two = new TestEnum(nameof(Two), 2);
        public static readonly TestEnum Three = new TestEnum(nameof(Three), 3);

        private TestEnum(string name, int value) : base(name, value)
        {
        }
    }

    /// <summary>
    ///     Name プロパティは好きな文字列を定義できる
    ///     Value プロパティは int 型にキャストできる型なら指定可能（例：ushort）
    /// </summary>
    public sealed class TestEnum2 : SmartEnum<TestEnum2>
    {
        public static readonly TestEnum2 One = new TestEnum2("A string!", 1);
        public static readonly TestEnum2 Two = new TestEnum2("Another string!", 2);
        public static readonly TestEnum2 Three = new TestEnum2("Yet another string!", 3);

        private TestEnum2(string name, ushort value) : base(name, value)
        {
        }
    }

    /// <summary>
    ///     ・同一区分(Name)に異なる値(Value)を定義することはできない
    ///     → そもそもビルドエラー
    ///     ・異なる区分(Name)に同一値(Value)を定義することはできる。
    ///     → FromValue メソッドで取得できるのは先に見つかったインスタンス
    /// </summary>
    public sealed class TestEnum3 : SmartEnum<TestEnum3>
    {
        public static readonly TestEnum3 One = new TestEnum3(nameof(One), 1);
        public static readonly TestEnum3 Two = new TestEnum3(nameof(Two), 2);
        public static readonly TestEnum3 Three = new TestEnum3(nameof(Three), 3);

        public static readonly TestEnum3 AnotherThree = new TestEnum3(nameof(AnotherThree), 3);
        // public static readonly TestEnum Three = new TestEnum(nameof(Three), 4); // -> throws exception

        private TestEnum3(string name, int value) : base(name, value)
        {
        }
    }
}