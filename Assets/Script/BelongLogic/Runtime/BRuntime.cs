using System;
using System.Collections;
using System.Collections.Generic;
using Belong.Logic.Code;
using UnityEngine;

namespace Belong.Logic.Runtime
{
    public class BRuntime
    {
        /// <summary>
        /// 程序模块加载
        /// key id | value 实例
        /// </summary>
        private Dictionary<string, BModule> _moduleDic;

        private Dictionary<string, Type> _typeDic;



        public BRuntime()
        {
            _moduleDic = new Dictionary<string, BModule>();
            _typeDic = new Dictionary<string, Type>();
        }

        public bool LoadType(Type type)
        {
            if (_typeDic.ContainsKey(type.Name))
            {
                Debug.LogError("重复加载相同模块!");
                return false;
            }
            _typeDic.Add(type.Name, type);
            return true;
        }

        public bool LoadAssembly(BModule module)
        {
            if (_moduleDic.ContainsKey(module.ModuleId))
            {
                Debug.LogError("重复加载相同模块!");
                return false;
            }
            _moduleDic.Add(module.ModuleId, module);
            return ResolverModule();
        }

        private bool ResolverModule()
        {
            return true;
        }

        public object Run()
        {
            return null;
        }
    }
}