
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Linq;


namespace cfg.test
{
    public partial class TbCompositeJsonTable2
    {
        private readonly System.Func<string, int, int, ByteBuf> _byteBufLoader;
        private readonly string _fileName;
        private Tables _tables;

        private readonly System.Collections.Generic.Dictionary<int, test.CompositeJsonTable2> _dataMap;
        private readonly System.Collections.Generic.Dictionary<int, int> _offsetMap;
        private readonly System.Collections.Generic.Dictionary<int, int> _lengthMap;

        private readonly System.Collections.Generic.List<test.CompositeJsonTable2> _dataList;
    
        public TbCompositeJsonTable2(ByteBuf _buf,string fileName, System.Func<string, int, int, ByteBuf> byteBufLoader)
        {
            _dataMap = new System.Collections.Generic.Dictionary<int, test.CompositeJsonTable2>();
            _offsetMap = new System.Collections.Generic.Dictionary<int, int>();
            _lengthMap = new System.Collections.Generic.Dictionary<int, int>();
            _fileName = fileName;
            _byteBufLoader = byteBufLoader;
        
            for (int n = _buf.ReadSize(); n > 0; --n)
            {
                int key;
                key = _buf.ReadInt();
                int offset = _buf.ReadInt();
                int length = _buf.ReadInt();
                _offsetMap.Add(key, offset);
                _lengthMap.Add(key, length);
            }
        }

        public void LoadAll(System.Action<int,test.CompositeJsonTable2> onLoad = null)
        {
            foreach(var (key,offset) in _offsetMap)
		    {
                var value = this.Get(key);
                if (value != null)
			    {
				    onLoad?.Invoke(key, value);
			    }
		    }
        }

        public test.CompositeJsonTable2 GetOrDefault(int key) => this.Get(key) ?? default;
        public test.CompositeJsonTable2 Get(int key)
        {
            if (_dataMap.TryGetValue(key, out var v))
            {
                return v;
            }
            int offset = _offsetMap[key];
            int length = _lengthMap[key];
            ByteBuf buf = this._byteBufLoader(this._fileName, offset, length);
            v = test.CompositeJsonTable2.DeserializeCompositeJsonTable2(buf);;
            _dataMap[key] = v;
            v.ResolveRef(_tables);
            return v;
        }
        public test.CompositeJsonTable2 this[int key] => this.Get(key);

        public void ResolveRef(Tables tables)
        {
            this._tables = tables;
        }

    }

}
