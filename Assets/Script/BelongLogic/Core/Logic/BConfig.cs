using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Belong.Logic
{

    public static class BConfig
    {
        //reflect

        public static List<Type> ReflectClassList = new List<Type>()
        {
            typeof(UnityEngine.GameObject),
            typeof(UnityEngine.Transform),
            typeof(UnityEngine.Mathf),
            typeof(System.Math),
            typeof(UnityEngine.Debug)
        };

        public static List<Type> SystemType = new List<Type>() {
            typeof(System.Int32),
            typeof(System.Single),
            typeof(System.Int64),
            typeof(System.String),
            typeof(System.Boolean)
        };
    }
}