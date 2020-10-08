using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class DebugMenuConfigure : EditorWindow
{
    //菜单
    int m_SelectedPage = 0;
    string[] m_ButtonStr = new string[] { "对话调试", "其他" };

    //对话组件
    static DialogController Dialog;
    static string DialogContent = "The message u want to sent.";

    [MenuItem("调试/发送对话")]
    static void Init()
    {

        EditorWindow window = EditorWindow.GetWindow(typeof(DebugMenuConfigure), false, "调试菜单", true);
        window.Show();
    }

    private void OnGUI()
    {
        //标题选择
        m_SelectedPage = GUILayout.Toolbar(m_SelectedPage, m_ButtonStr, GUILayout.Height(25));
        switch (m_SelectedPage)
        {
            case 0:
                //自定义标题GUI风格
                GUIStyle TitleStyle = new GUIStyle();
                TitleStyle.fontSize = 18;
                TitleStyle.alignment = TextAnchor.MiddleCenter;
                TitleStyle.normal.textColor = Color.white;
                //标题绘制
                GUILayout.Space(10);
                GUILayout.Label("调试工具", TitleStyle);
                GUILayout.Label("Made by EasternDay", TitleStyle);
                GUILayout.Space(10);
                //菜单选项
                Dialog = EditorGUILayout.ObjectField("对话", Dialog, typeof(DialogController), true) as DialogController;
                DialogContent = EditorGUILayout.TextArea(DialogContent, GUILayout.MinHeight(100));
                if (GUILayout.Button("发送对话"))
                {
                    Dialog.ShowDialog(DialogContent);
                }

                break;
        }
    }

    private void OnInspectorUpdate()
    {
        //Debug.Log("监视面板调用");
        this.Repaint();  //重新画窗口 
    }
    /*
    private void OnProjectChange()
    {
        //Debug.Log("当场景改变时调用");
        Repaint();
    }

    private void OnHierarchyChange()
    {
        //Debug.Log("当选择对象属性改变时调用");
    }

    void OnGetFocus()
    {
        //Debug.Log("当窗口得到焦点时调用");
    }

    private void OnLostFocus()
    {
        //Debug.Log("当窗口失去焦点时调用");
    }

    private void OnSelectionChange()
    {
        //Debug.Log("当改变选择不同对象时调用");
    }

    private void OnInspectorUpdate()
    {
        //Debug.Log("监视面板调用");
        this.Repaint();  //重新画窗口 
    }

    private void OnDestroy()
    {
        //Debug.Log("当窗口关闭时调用");
    }

    private void OnFocus()
    {
        //Debug.Log("当窗口获取键盘焦点时调用");
    }
    */
}