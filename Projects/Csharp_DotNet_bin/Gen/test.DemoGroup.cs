
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
public sealed partial class DemoGroup : Luban.BeanBase
{
    public DemoGroup(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X2 = _buf.ReadInt();
        X2_Ref = null;
        X4 = _buf.ReadInt();
        X5 = test.InnerGroup.DeserializeInnerGroup(_buf);
    }

    public static DemoGroup DeserializeDemoGroup(ByteBuf _buf)
    {
        return new test.DemoGroup(_buf);
    }

    public readonly int Id;
    public readonly int X2;
    public test.DemoGroup X2_Ref;
    public readonly int X4;
    public readonly test.InnerGroup X5;
   
    public const int __ID__ = -379263008;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        X2_Ref = tables.TbDemoGroupS.GetOrDefault(X2);
        X5?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x2:" + X2 + ","
        + "x4:" + X4 + ","
        + "x5:" + X5 + ","
        + "}";
    }
}

}

