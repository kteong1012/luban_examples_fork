
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.tag
{
public partial class TbTestTag
{
    private readonly System.Collections.Generic.Dictionary<int, tag.TestTag> _dataMap;
    private readonly System.Collections.Generic.List<tag.TestTag> _dataList;
    
    public TbTestTag(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, tag.TestTag>();
        _dataList = new System.Collections.Generic.List<tag.TestTag>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            tag.TestTag _v;
            _v = tag.TestTag.DeserializeTestTag(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, tag.TestTag> DataMap => _dataMap;
    public System.Collections.Generic.List<tag.TestTag> DataList => _dataList;

    public tag.TestTag GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public tag.TestTag Get(int key) => _dataMap[key];
    public tag.TestTag this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

