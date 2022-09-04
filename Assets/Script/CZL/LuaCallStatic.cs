using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LuaNameSpace
{
    public static class LuaStaticClass
    {
        public static int id = 10;

        public static string name
        {
            get;
            set;
        }

        public static string outPut()
        {
            return "static use";
        }

        public static void Defualt(string str="abc") 
        {
            Debug.Log(str);
        }
    }
}

public class LuaCallStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XLuasEnv.Instance.LuaDoString("CZL/LuaCallStatic");
    }

    // Update is called once per frame
    private void OnDestroy()
    {
        XLuasEnv.Instance.FreeEnv();
    }
}
