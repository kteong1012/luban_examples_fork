
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using SimpleJSON;
using Luban;
using UnityEngine;
using System.Linq;

namespace editor.cfg.test
{

public sealed class MultiIndexList :  Luban.EditorBeanBase 
{
    public MultiIndexList()
    {
            id3 = "";
            desc = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["id2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id2 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["id3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  id3 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["num"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  num = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["desc"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  desc = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id1"] = new JSONNumber(id1);
        }
        {
            _json["id2"] = new JSONNumber(id2);
        }
        {

            if (id3 == null) { throw new System.ArgumentNullException(); }
            _json["id3"] = new JSONString(id3);
        }
        {
            _json["num"] = new JSONNumber(num);
        }
        {

            if (desc == null) { throw new System.ArgumentNullException(); }
            _json["desc"] = new JSONString(desc);
        }
    }


    public override void Render()
    {
        UnityEditor.EditorGUILayout.BeginVertical();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("id1", GUILayout.Width(100));
        id1 = UnityEditor.EditorGUILayout.IntField(id1, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("id2", GUILayout.Width(100));
        id2 = UnityEditor.EditorGUILayout.LongField(id2, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("id3", GUILayout.Width(100));
        id3 = UnityEditor.EditorGUILayout.TextField(id3, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("num", GUILayout.Width(100));
        num = UnityEditor.EditorGUILayout.IntField(num, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("desc", GUILayout.Width(100));
        desc = UnityEditor.EditorGUILayout.TextField(desc, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.EndVertical();
    }

    public static MultiIndexList LoadJsonMultiIndexList(SimpleJSON.JSONNode _json)
    {
        MultiIndexList obj = new test.MultiIndexList();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMultiIndexList(MultiIndexList _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id1;
    public UnityEngine.Object id1_UnityObject;
    public long id2;
    public UnityEngine.Object id2_UnityObject;
    public string id3;
    public UnityEngine.Object id3_UnityObject;
    public int num;
    public UnityEngine.Object num_UnityObject;
    public string desc;
    public UnityEngine.Object desc_UnityObject;

    public override string ToString()
    {
        return "{ "
        + "id1:" + id1 + ","
        + "id2:" + id2 + ","
        + "id3:" + id3 + ","
        + "num:" + num + ","
        + "desc:" + desc + ","
        + "}";
    }
}

}
