
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
    public sealed partial class Item : test.ItemBase
    {
        public Item(ByteBuf _buf)  : base(_buf) 
        {
            Num = _buf.ReadInt();
            Price = _buf.ReadInt();
        }

        public static Item DeserializeItem(ByteBuf _buf)
        {
            return new test.Item(_buf);
        }

        public readonly int Num;
        public readonly int Price;
   
        public const int __ID__ = -1226641649;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(Tables tables)
        {
            base.ResolveRef(tables);
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "desc:" + Desc + ","
            + "num:" + Num + ","
            + "price:" + Price + ","
            + "}";
        }
    }

}
