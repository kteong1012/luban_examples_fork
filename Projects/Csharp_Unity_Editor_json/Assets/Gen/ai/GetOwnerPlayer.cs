
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

namespace editor.cfg.ai
{

public sealed class GetOwnerPlayer :  ai.Service 
{
    public GetOwnerPlayer()
    {
            playerActorKey = "";
    }
    public override string GetTypeStr() => TYPE_STR;
    private const string TYPE_STR = "ai.GetOwnerPlayer";

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
            var _fieldJson = _json["node_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  nodeName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["player_actor_key"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  playerActorKey = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {

            if (nodeName == null) { throw new System.ArgumentNullException(); }
            _json["node_name"] = new JSONString(nodeName);
        }
        {

            if (playerActorKey == null) { throw new System.ArgumentNullException(); }
            _json["player_actor_key"] = new JSONString(playerActorKey);
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
        UnityEditor.EditorGUILayout.LabelField("node_name", GUILayout.Width(100));
        nodeName = UnityEditor.EditorGUILayout.TextField(nodeName, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.BeginHorizontal();
        UnityEditor.EditorGUILayout.LabelField("player_actor_key", GUILayout.Width(100));
        playerActorKey = UnityEditor.EditorGUILayout.TextField(playerActorKey, GUILayout.Width(150));
        UnityEditor.EditorGUILayout.EndHorizontal();
        UnityEditor.EditorGUILayout.EndVertical();
    }

    public static GetOwnerPlayer LoadJsonGetOwnerPlayer(SimpleJSON.JSONNode _json)
    {
        GetOwnerPlayer obj = new ai.GetOwnerPlayer();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonGetOwnerPlayer(GetOwnerPlayer _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string playerActorKey;
    public UnityEngine.Object playerActorKey_UnityObject;

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "playerActorKey:" + playerActorKey + ","
        + "}";
    }
}

}
