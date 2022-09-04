using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaCallObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XLuasEnv.Instance.LuaDoString("require('CZL/LuaCallObject')");
    }

    // Update is called once per frame
    void Update()
    {
        XLuasEnv.Instance.FreeEnv();
    }
}

public class NPC
{
    public string name;
    public int HP
    {
        get;
        set;
    }

    public NPC()
    {

    }

    public NPC(string name)
    {
        this.name = name;
    }

    public void PrintMe()
    {
        Debug.Log("Ãû³Æ"+name);
        Debug.Log("HP" + HP);
    }
}
