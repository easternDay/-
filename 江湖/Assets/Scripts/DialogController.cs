using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[CanEditMultipleObjects, CustomEditor(typeof(DialogController))]
public class ScriptEditor_DialogController : Editor
{
    string content = "";
    public override void OnInspectorGUI()
    {
        //获取脚本对象
        DialogController script = target as DialogController;
        GUILayout.Box("------------------------");
        //GUILayout.Label("讲述人");
        //content = EditorGUILayout.TextField(content);
        EditorGUILayout.Space();
        GUILayout.Label("显示内容");
        content = EditorGUILayout.TextField(content);
        if (GUILayout.Button("发送测试"))
        {
            script.ShowDialog(content);
        }
        GUILayout.Box("------------------------");
        // 绘制全部原有属性
        base.DrawDefaultInspector();
        // 后面可以扩展自己功能
    }
}
#endif

public class DialogController : MonoBehaviour
{
    public Text dialogContent;

    public void ShowDialog(string content)
    {
        dialogContent.text = content;
    }
}
