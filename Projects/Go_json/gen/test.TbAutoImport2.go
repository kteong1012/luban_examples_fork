
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


type TestTbAutoImport2 struct {
    _dataMap map[int32]*TestAutoImport2
    _dataList []*TestAutoImport2
}

func NewTestTbAutoImport2(_buf []map[string]interface{}) (*TestTbAutoImport2, error) {
    _dataList := make([]*TestAutoImport2, 0, len(_buf))
    dataMap := make(map[int32]*TestAutoImport2)

    for _, _ele_ := range _buf {
        if _v, err2 := NewTestAutoImport2(_ele_); err2 != nil {
            return nil, err2
        } else {
            _dataList = append(_dataList, _v)
            dataMap[_v.Id] = _v
        }
    }
    return &TestTbAutoImport2{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *TestTbAutoImport2) GetDataMap() map[int32]*TestAutoImport2 {
    return table._dataMap
}

func (table *TestTbAutoImport2) GetDataList() []*TestAutoImport2 {
    return table._dataList
}

func (table *TestTbAutoImport2) Get(key int32) *TestAutoImport2 {
    return table._dataMap[key]
}

