using System;
using System.Collections;
using System.Collections.Generic;
using Belong.Logic.Code;
using Belong.Logic.Utils;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;


namespace Belong.Logic.Editor
{
    public partial class BLogicEditor : EditorWindow
    {
        #region 成员变量

        private static BLogicEditor _windows;

        public Rect logicRect;

        private Rect windowRect;

        private Vector3 offset = Vector3.zero;

        private Vector3 mousePos;

        private BModule _currentModule;

        /// <summary>
        /// id,name
        /// </summary>
        private Dictionary<string, string> _allNamespaceDic;
        /// <summary>
        /// id,name
        /// </summary>
        private Dictionary<string, string> _currentClassDic;
        /// <summary>
        /// id;name
        /// </summary>
        private Dictionary<string, string> _currentVariableDic;

        private BLogicEnum _bLogicEnum = BLogicEnum.Main;

        private List<string> testName = new List<string>() { "dsadas", "wqeqwe" };
        private int index = -1;

        #endregion
        [MenuItem("Tools/窗口 &4", false, 4)]
        public static void Open()
        {
            _windows = (BLogicEditor)EditorWindow.GetWindow(typeof(BLogicEditor));
            _windows.minSize = new Vector2(300, 500);
            _windows.titleContent = new GUIContent("逻辑图");
            _windows.InitLogicData();

            _windows._bLogicEnum = BLogicEnum.Main;
            BLogicLanguage.GetLanguage();
        }

        private void InitLogicData()
        {
            _currentModule = SerializedUtils.DeserializeObject<BModule>();
            if (_currentModule == null)
            {
                _currentModule = new BModule();
                //_currentModule.MainMethod = new BMain();
                _currentModule.NamespacesList = new List<BNamespace>();

                BNamespace bNamespace = new BNamespace();
                BClass @class = new BClass();
                //@class.NamespaceId = bNamespace.NamespaceId;
                bNamespace.Classes.Add(@class);
                _currentModule.NamespacesList.Add(bNamespace);
                SerializedUtils.SerializeObject(this._currentModule);
            }
            _allNamespaceDic = new Dictionary<string, string>();
            _currentClassDic = new Dictionary<string, string>();
            _currentVariableDic = new Dictionary<string, string>();
            _allNamespaceDic.Add("", "None");
            for (int i = 0; i < _currentModule.NamespacesList.Count; i++)
            {
                _allNamespaceDic.Add(_currentModule.NamespacesList[i].NamespaceId, _currentModule.NamespacesList[i].NamespaceName);
            }
            BLogicEditorValue.Init();
        }

        Object o;
        private void OnGUI()
        {

            if (Application.isPlaying)
                return;
            EditorGUIUtility.labelWidth = 60;
            windowRect = new Rect(20, 30, position.width - 40, position.height - 50);
            mousePos = Event.current.mousePosition;

            GUILayout.BeginHorizontal();
            GUILayout.Label("逻辑图");
            GUI.color = _bLogicEnum == BLogicEnum.Main ? Color.green : Color.white;
            if (GUILayout.Button("入口", GUILayout.MinWidth(60)))
            {
                if (_bLogicEnum != BLogicEnum.Main)
                {
                    _bLogicEnum = BLogicEnum.Main;
                }
            }
            GUI.color = _bLogicEnum == BLogicEnum.GlobalVariable ? Color.green : Color.white;
            if (GUILayout.Button("全局变量", GUILayout.MinWidth(60)))
            {
                if (_bLogicEnum != BLogicEnum.GlobalVariable)
                {
                    _bLogicEnum = BLogicEnum.GlobalVariable;
                }
            }
            if (GUILayout.Button("变量", GUILayout.MinWidth(60)))
            {
                if (_bLogicEnum != BLogicEnum.GlobalVariable)
                {
                    _bLogicEnum = BLogicEnum.GlobalVariable;
                }
            }
            GUI.color = Color.white;
            index = GUILayout.Toolbar(index, testName.ToArray(), "toolbarbutton");
            GUILayout.Label("宽:" + _windows.windowRect.width);
            GUILayout.Label("高:" + _windows.windowRect.height);

            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();

            GUILayout.BeginArea(windowRect, "", "box");

            switch (_bLogicEnum)
            {
                case BLogicEnum.GlobalVariable:
                    ShowGlobalVariableGUI();
                    break;
                case BLogicEnum.Main:
                default:
                    ShowMainGUI();
                    break;
            }

            GUILayout.EndArea();
        }
    }

}
