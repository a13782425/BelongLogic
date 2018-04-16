using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Belong.Logic.Code
{
    [Serializable]
    public class BField
    {
        public BField()
        {
            this.FieldId = Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 字段唯一ID
        /// </summary>
        /// <value>The field identifier.</value>
        public string FieldId { get; set; }
        /// <summary>
        /// 字段名
        /// </summary>
        /// <value>The name of the field.</value>
        public string FieldName { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        /// <value>The type of the field.</value>
        public Type FieldType { get; set; }
        /// <summary>
        /// 字段值
        /// </summary>
        /// <value>The field value.</value>
        public object FieldValue { get; set; }
    }

}

