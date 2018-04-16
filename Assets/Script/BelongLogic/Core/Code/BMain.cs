using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Belong.Logic.Code
{
    [Serializable]
    public class BMain
    {
        /// <summary>
        /// 主方法
        /// </summary>
        /// <value>The main method.</value>
        public BMethod MainMethod { get; set; }

        /// <summary>
        /// 模块组
        /// </summary>
        /// <value>The module listy.</value>
        public List<BModule> ModuleList { get; set; }

        /// <summary>
        /// 全局变量
        /// </summary>
        /// <value>The global field list.</value>
        public List<BField> GlobalFieldList { get; set; }

        /// <summary>
        /// 全局方法
        /// </summary>
        /// <value>The global method list.</value>
        public List<BField> GlobalMethodList { get; set; }
    }

}