using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Belong.Logic.Code
{
    [Serializable]
    public sealed class BClass
    {
        public BClass()
            : this("BelongGlobal")
        {

        }

        public BClass(string className)
        {
            this.ClassId = Guid.NewGuid().ToString();
            this.ClassName = className;
            this.Fields = new List<BField>();
        }

        public string ClassId { get; set; }
        /// <summary>
        /// 类名
        /// </summary>
        /// <value>The name of the class.</value>
        public string ClassName { get; set; }
        /// <summary>
        /// 所有字段
        /// </summary>
        /// <value>The fields.</value>
        public List<BField> Fields { get; set; }
    }
}

