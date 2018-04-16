using System;
using System.Collections;
using System.Collections.Generic;
using Belong.Logic.Code;
using UnityEngine;

namespace Belong.Logic
{
    public class BelongLogic : MonoBehaviour
    {
        private BMain _currentMain;
        /// <summary>
        /// dll
        /// </summary>
        /// <value>The r all name space.</value>
        public BMain R_CurrentMain { get { return _currentMain; } }

        private BelongLogic _instance = null;
        public BelongLogic Instance { get { return _instance; } }


        private void Awake()
        {
            _instance = this;
            _currentMain = Utils.SerializedUtils.DeserializeObject<BMain>();
            DontDestroyOnLoad(this.gameObject);
        }

        public int Begin(int args = 0, params string[] param)
        {
            this.Invoke(R_CurrentMain.MainMethod);
            return 1;
        }

        private void Invoke(BMethod mainMethod)
        {
          
        }
    }
}
