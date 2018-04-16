using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Belong.Logic.Utils
{
    public static class GlobalValue
    {


        public static string ConfigFile
        {
            get { return "/BelongLogic.b"; }
        }
        public static string ConfigPath
        {
            get
            {
                string filepath = string.Empty;
#if UNITY_EDITOR
                filepath = Application.dataPath + "/StreamingAssets/Belong";
#elif UNITY_IPHONE
                filepath = Application.dataPath +"/Raw/Belong";
#elif UNITY_ANDROID
                filepath = "jar:file://" + Application.dataPath + "!/assets/Belong";
#endif
                return filepath;
            }
        }

        public static string ConfigFilePath
        {
            get { return ConfigPath + ConfigFile; }
        }

    }

}
