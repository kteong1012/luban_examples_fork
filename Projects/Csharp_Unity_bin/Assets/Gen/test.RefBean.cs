
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
public sealed partial class RefBean : test.RefDynamicBase
{
    public RefBean(ByteBuf _buf)  : base(_buf) 
    {
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Arr = new System.Collections.Generic.List<int>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { int _e0;  _e0 = _buf.ReadInt(); Arr.Add(_e0);}}
    }

    public static RefBean DeserializeRefBean(ByteBuf _buf)
    {
        return new test.RefBean(_buf);
    }

    public readonly System.Collections.Generic.List<int> Arr;
    public System.Collections.Generic.List<test.TestBeRef> Arr_Ref;
   
    public const int __ID__ = 1963260263;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        Arr_Ref = new System.Collections.Generic.List<test.TestBeRef>();
        foreach (var _v in Arr) { Arr_Ref.Add(tables.TbTestBeRef.GetOrDefault(_v)); }

    }

    public override string ToString()
    {
        return "{ "
        + "x:" + X + ","
        + "arr:" + Luban.StringUtil.CollectionToString(Arr) + ","
        + "}";
    }
}

}
