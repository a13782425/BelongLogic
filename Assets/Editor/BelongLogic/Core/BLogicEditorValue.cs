using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Belong.Logic.Editor
{
    public class BLogicEditorValue
    {
        private static Assembly[] assemblys = new Assembly[] { typeof(Type).Assembly, typeof(GameObject).Assembly };

        public static List<string> AllTypeList = null;

        public static void Init()
        {
            AllTypeList = new List<string>();
            for (int i = 0; i < assemblys.Length; i++)
            {
                Type[] types= assemblys[i].GetTypes();
                for (int j = 0; j < types.Length; j++)
                {
                    if (types[i].IsSealed)
                    {
                        continue;
                    }
                    AllTypeList.Add(types[j].Name);
                }
            }
        }

    }
}