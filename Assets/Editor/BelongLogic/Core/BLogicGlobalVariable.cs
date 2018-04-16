using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using System;

namespace Belong.Logic.Editor
{
    public partial class BLogicEditor : EditorWindow
    {
        bool addGlobalVariable = false;
        int varNamespaceIndex = 0;
        private void ShowGlobalVariableGUI()
        {
            GUILayout.BeginVertical();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("增加"))
            {
                addGlobalVariable = true;
            }
            varNamespaceIndex = EditorGUILayout.Popup("命名空间:", varNamespaceIndex, BLogicEditorValue.AllTypeList.ToArray());
            ////EditorGUILayout.Popup(0,);
            GUILayout.EndHorizontal();
            if (addGlobalVariable)
            {
                AddGlobalVariable();
            }
            GUILayout.EndVertical();
        }
        private string globalVarName;
        private void AddGlobalVariable()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("名字:");
            globalVarName = GUILayout.TextField(globalVarName);
            GUILayout.EndHorizontal();
        }
    }
}