using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DebugMenuConfigure : EditorWindow
{

    //游戏管理器
    static GameManager gm;

    //菜单
    static int m_SelectedPage = 0;//菜单索引
    static string[] m_ButtonStr = new string[] { "对话调试", "其他" };//菜单选项
    Vector2 _scrollPos;//菜单滚动条

    [@MenuItem("调试/开启")]
    static void OpenDebugWindow()
    {
        EditorWindow window = EditorWindow.GetWindow(typeof(DebugMenuConfigure), false, "调试菜单", true);
        window.autoRepaintOnSceneChange = false;
        window.Show();
    }

    void OnInspectorUpdate()
    {
        if (!gm)
        {
            gm = GameManager.Instance;
        }
    }

    private void OnGUI()
    {
        if (gm)
        {
            //标题选择
            m_SelectedPage = GUILayout.Toolbar(m_SelectedPage, m_ButtonStr, GUILayout.Height(25));
            switch (m_SelectedPage)
            {
                case 0:
                    DrawDialogGUI();
                    break;
            }
        }
        else
        {
            EditorGUILayout.LabelField("--请运行游戏以进行测试--");
        }
    }

    void DrawDialogGUI()
    {
        _scrollPos = EditorGUILayout.BeginScrollView(_scrollPos);
        //菜单选项 = EditorGUILayout.ObjectField("对话", Dialog, typeof(DialogController), true) as DialogController;
        gm.Dialog.DialogRoleName.text = EditorGUILayout.TextArea(gm.Dialog.DialogRoleName.text, GUILayout.MinWidth(40));
        gm.Dialog.DialogContent.text = EditorGUILayout.TextArea(gm.Dialog.DialogContent.text, GUILayout.MinHeight(100));
        if (GUILayout.Button("发送对话"))
        {
            gm.Dialog.ShowDialog(gm.Dialog.DialogRoleName.text + "#Test", gm.Dialog.DialogContent.text + "#Test");
        }
        EditorGUILayout.EndScrollView();
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