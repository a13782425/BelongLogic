using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Belong.Logic.Code
{
    /// <summary>
    /// 代码模块
    /// </summary>
    [Serializable]
    public sealed class BModule
    {
        public BModule()
        {
            this.ModuleId = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 命名空间集合
        /// </summary>
        /// <value>The namespaces list.</value>
        public List<BNamespace> NamespacesList { get; set; }

        /// <summary>
        /// 全局变量
        /// </summary>
        /// <value>The global field list.</value>
        public List<BField> ModuleFieldList { get; set; }

        /// <summary>
        /// 全局方法
        /// </summary>
        /// <value>The global method list.</value>
        public List<BMethod> ModuleMethodList { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        /// <value>The module identifier.</value>
        public string ModuleId { get; set; }

    }
}
