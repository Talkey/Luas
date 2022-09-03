using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XLuasEnv.Instance.LuaDoString("require('test0')");
        

    }

    private void OnDestroy()
    {
        XLuasEnv.Instance.FreeEnv();
    }


}
