using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class luatest : MonoBehaviour
{
    
    
    void Start()
    {
        //luaΪ���������ԣ���Ҫ��ȡ������
        //��ȡlua������

        LuaEnv env = new LuaEnv();

        //����������lua����
        env.DoString("print('hello world')");
        //�ͷŽ�����

        env.Dispose();

        LuaCodeCSharp();

    }

    public void LuaCodeCSharp()
    {
        //c#����lua����
        LuaEnv env = new LuaEnv();
        env.DoString("print('hello world')");

        //lua����c#����
        Debug.Log("");
        env.DoString("CS.UnityEngine.Debug.Log('from lua hello worldss')");
        env.Dispose();
    }

}
