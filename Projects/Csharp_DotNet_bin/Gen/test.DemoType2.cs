
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public sealed partial class DemoType2 : Luban.BeanBase
{
    public DemoType2(ByteBuf _buf) 
    {
        X4 = _buf.ReadInt();
        X1 = _buf.ReadBool();
        X2 = _buf.ReadByte();
        X3 = _buf.ReadShort();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        X7 = _buf.ReadDouble();
        X80 = _buf.ReadShort();
        X8 = _buf.ReadInt();
        X9 = _buf.ReadLong();
        X10 = _buf.ReadString();
        X12 = test.DemoType1.DeserializeDemoType1(_buf);
        X13 = (test.DemoEnum)_buf.ReadInt();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf);
        S1 = _buf.ReadString();
        T1 = _buf.ReadLong();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K1 = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); K1[__index0] = __e0;}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K2 = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); K2.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K5 = new System.Collections.Generic.HashSet<int>(/*n0 * 3 / 2*/);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); K5.Add(_e0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K8 = new System.Collections.Generic.Dictionary<int, int>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); int _v0;  _v0 = _buf.ReadInt();     K8.Add(_k0, _v0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K9 = new System.Collections.Generic.List<test.DemoE2>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.DemoE2 _e0;  _e0 = test.DemoE2.DeserializeDemoE2(_buf); K9.Add(_e0);}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K15 = new test.DemoDynamic[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { test.DemoDynamic __e0;__e0 = test.DemoDynamic.DeserializeDemoDynamic(_buf); K15[__index0] = __e0;}}
    }

    public static DemoType2 DeserializeDemoType2(ByteBuf _buf)
    {
        return new test.DemoType2(_buf);
    }

    public readonly int X4;
    public readonly bool X1;
    public readonly byte X2;
    public readonly short X3;
    public readonly long X5;
    public readonly float X6;
    public readonly double X7;
    public readonly short X80;
    public readonly int X8;
    public readonly long X9;
    public readonly string X10;
    public readonly test.DemoType1 X12;
    public readonly test.DemoEnum X13;
    public readonly test.DemoDynamic X14;
    public readonly string S1;
    public readonly long T1;
    public readonly int[] K1;
    public readonly System.Collections.Generic.List<int> K2;
    public readonly System.Collections.Generic.HashSet<int> K5;
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    public System.Collections.Generic.Dictionary<int, test.DemoType2> K8_Ref;
    public readonly System.Collections.Generic.List<test.DemoE2> K9;
    public readonly test.DemoDynamic[] K15;
   
    public const int __ID__ = -367048295;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        X12?.ResolveRef(tables);
        X14?.ResolveRef(tables);
        K8_Ref = new System.Collections.Generic.Dictionary<int, test.DemoType2>();
        foreach (var kvp in K8) { K8_Ref.Add(kvp.Key, tables.TbFullTypes.GetOrDefault(kvp.Value)); }

        foreach (var _e in K15) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "x4:" + X4 + ","
        + "x1:" + X1 + ","
        + "x2:" + X2 + ","
        + "x3:" + X3 + ","
        + "x5:" + X5 + ","
        + "x6:" + X6 + ","
        + "x7:" + X7 + ","
        + "x80:" + X80 + ","
        + "x8:" + X8 + ","
        + "x9:" + X9 + ","
        + "x10:" + X10 + ","
        + "x12:" + X12 + ","
        + "x13:" + X13 + ","
        + "x14:" + X14 + ","
        + "s1:" + S1 + ","
        + "t1:" + T1 + ","
        + "k1:" + Luban.StringUtil.CollectionToString(K1) + ","
        + "k2:" + Luban.StringUtil.CollectionToString(K2) + ","
        + "k5:" + Luban.StringUtil.CollectionToString(K5) + ","
        + "k8:" + Luban.StringUtil.CollectionToString(K8) + ","
        + "k9:" + Luban.StringUtil.CollectionToString(K9) + ","
        + "k15:" + Luban.StringUtil.CollectionToString(K15) + ","
        + "}";
    }
}

}

