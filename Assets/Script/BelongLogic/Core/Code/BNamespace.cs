using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Belong.Logic.Code
{
    [Serializable]
    public sealed class BNamespace
    {
        public BNamespace()
            :this("BelongNameSpace")
        {
           
        }
        public BNamespace(string name)
        {
            this.NamespaceId = Guid.NewGuid().ToString();
            this.NamespaceName = name;
            Classes = new List<BClass>();
        }

        /// <summary>
        /// 命名空间ID
        /// </summary>
        /// <value>The namespace identifier.</value>
        public string NamespaceId { get; set; }
        /// <summary>
        /// 命名空间名称
        /// </summary>
        /// <value>The name of the namespace.</value>
        public string NamespaceName { get; set; }
        /// <summary>
        /// 所有类
        /// </summary>
        /// <value>The classes.</value>
        public List<BClass> Classes { get; set; }
    }
}

