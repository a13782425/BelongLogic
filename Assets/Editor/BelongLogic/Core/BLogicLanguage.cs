using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Belong.Logic.Editor
{
    public sealed class BLogicLanguage
    {
        
        private class LanguageDTO
        {
            public int Id;
            public string ChineseSimplified;
            public string English;
        }
        private static SystemLanguage Language = SystemLanguage.ChineseSimplified;

        private static Dictionary<string, string> languageDic = new Dictionary<string, string>();

        public static void GetLanguage()
        {
            Language = Application.systemLanguage;
        }


        /// <summary>
        /// 获取文字
        /// </summary>
        /// <returns>The text.</returns>
        public static string GetText(int id)
        {
            return null;
        }
    }
}