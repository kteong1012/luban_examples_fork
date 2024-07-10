
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.ai
{
public sealed partial class MoveToTarget : ai.Task
{
    public MoveToTarget(ByteBuf _buf)  : base(_buf) 
    {
        TargetActorKey = _buf.ReadString();
        AcceptableRadius = _buf.ReadFloat();
    }

    public static MoveToTarget DeserializeMoveToTarget(ByteBuf _buf)
    {
        return new ai.MoveToTarget(_buf);
    }

    public readonly string TargetActorKey;
    public readonly float AcceptableRadius;
   
    public const int __ID__ = 514987779;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "decorators:" + Luban.StringUtil.CollectionToString(Decorators) + ","
        + "services:" + Luban.StringUtil.CollectionToString(Services) + ","
        + "ignoreRestartSelf:" + IgnoreRestartSelf + ","
        + "targetActorKey:" + TargetActorKey + ","
        + "acceptableRadius:" + AcceptableRadius + ","
        + "}";
    }
}

}

