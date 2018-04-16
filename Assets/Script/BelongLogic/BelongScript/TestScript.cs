using System.Collections;
using System.Collections.Generic;
using Belong.Logic.Code;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        BMain bMain = new BMain();
        bMain.MainMethod = new BMethod();
        bMain.MainMethod.ReturnType = typeof(int);
        Belong.Logic.Utils.SerializedUtils.SerializeObject(bMain);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
