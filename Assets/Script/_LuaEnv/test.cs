using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class test : MonoBehaviour
{
    string[] filePath;
    // Start is called before the first frame update
    void Start()
    {
        XLuasEnv.Instance.LuaDoString("require('test0')");
       // LuaFileLoad(filePath, XLuasEnv.Instance.);

    }

    private void OnDestroy()
    {
        XLuasEnv.Instance.FreeEnv();
    }


    public void LuaFileLoad(string[] filepath, LuaEnv env)
    {
        foreach (string path in filepath)
        {
            env.DoString("require('" + path + "')");
        }
    }

}
