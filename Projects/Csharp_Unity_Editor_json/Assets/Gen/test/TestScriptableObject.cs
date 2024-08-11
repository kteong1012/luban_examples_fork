
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

public sealed class TestScriptableObject :  Luban.EditorBeanBase 
{
    public TestScriptableObject()
    {
            desc = "";
            v2 = new vec2();
            v3 = new vec3();
            v4 = new vec4();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["desc"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  desc = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["rate"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  rate = _fieldJson;
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
            var _fieldJson = _json["v2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  v2 = vec2.LoadJsonvec2(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["v3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  v3 = vec3.LoadJsonvec3(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["v4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  v4 = vec4.LoadJsonvec4(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {

            if (desc == null) { throw new System.ArgumentNullException(); }
            _json["desc"] = new JSONString(desc);
        }
        {
            _json["rate"] = new JSONNumber(rate);
        }
        {
            _json["num"] = new JSONNumber(num);
        }
        {
            { var __bjson = new JSONObject();  vec2.SaveJsonvec2(v2, __bjson); _json["v2"] = __bjson; }
        }
        {
            { var __bjson = new JSONObject();  vec3.SaveJsonvec3(v3, __bjson); _json["v3"] = __bjson; }
        }
        {
            { var __bjson = new JSONObject();  vec4.SaveJsonvec4(v4, __bjson); _json["v4"] = __bjson; }
        }
    }


    public override void Render()
    {
        UnityEditor.EditorGUILayout.BeginVertical();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("id", GUILayout.Width(100));
        id = UnityEditor.EditorGUILayout.IntField(id, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("desc", GUILayout.Width(100));
        desc = UnityEditor.EditorGUILayout.TextField(desc, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("rate", GUILayout.Width(100));
        rate = UnityEditor.EditorGUILayout.FloatField(rate, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("num", GUILayout.Width(100));
        num = UnityEditor.EditorGUILayout.IntField(num, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("v2", GUILayout.Width(100));
        {
            UnityEditor.EditorGUILayout.BeginVertical("Box");UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("x");
        v2.x = UnityEditor.EditorGUILayout.FloatField(v2.x, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("y");
        v2.y = UnityEditor.EditorGUILayout.FloatField(v2.y, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
        }
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("v3", GUILayout.Width(100));
        {
            UnityEditor.EditorGUILayout.BeginVertical("Box");UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("x");
        v3.x = UnityEditor.EditorGUILayout.FloatField(v3.x, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("y");
        v3.y = UnityEditor.EditorGUILayout.FloatField(v3.y, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("z");
        v3.z = UnityEditor.EditorGUILayout.FloatField(v3.z, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
        }
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("v4", GUILayout.Width(100));
        {
            UnityEditor.EditorGUILayout.BeginVertical("Box");UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("x");
        v4.x = UnityEditor.EditorGUILayout.FloatField(v4.x, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("y");
        v4.y = UnityEditor.EditorGUILayout.FloatField(v4.y, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("z");
        v4.z = UnityEditor.EditorGUILayout.FloatField(v4.z, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("w");
        v4.w = UnityEditor.EditorGUILayout.FloatField(v4.w, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();    UnityEditor.EditorGUILayout.EndVertical();
        }
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.EndVertical();
    }

    public static TestScriptableObject LoadJsonTestScriptableObject(SimpleJSON.JSONNode _json)
    {
        TestScriptableObject obj = new test.TestScriptableObject();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestScriptableObject(TestScriptableObject _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;
    public UnityEngine.Object id_UnityObject;
    public string desc;
    public UnityEngine.Object desc_UnityObject;
    public float rate;
    public UnityEngine.Object rate_UnityObject;
    public int num;
    public UnityEngine.Object num_UnityObject;
    public vec2 v2;
    public UnityEngine.Object v2_UnityObject;
    public vec3 v3;
    public UnityEngine.Object v3_UnityObject;
    public vec4 v4;
    public UnityEngine.Object v4_UnityObject;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "desc:" + desc + ","
        + "rate:" + rate + ","
        + "num:" + num + ","
        + "v2:" + v2 + ","
        + "v3:" + v3 + ","
        + "v4:" + v4 + ","
        + "}";
    }
}

}
