using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Belong.Logic.Code
{    
    [Serializable]
    public class BMethod
    {
        public BMethod()
        {
            this.MethodId = Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 方法唯一ID
        /// </summary>
        /// <value>The field identifier.</value>
        public string MethodId { get; set; }
        /// <summary>
        /// 方法名称
        /// </summary>
        /// <value>The name of the field.</value>
        public string MethodName { get; set; }
        /// <summary>
        /// 返回类型
        /// </summary>
        /// <value>The type of the field.</value>
        public Type ReturnType { get; set; }
        /// <summary>
        /// 方法里面的字段
        /// </summary>
        /// <value>The fields.</value>
        public List<BField> Fields { get; set; }
    }
}