using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class luatest : MonoBehaviour
{
    
    
    void Start()
    {
        //lua为解释性语言，需要获取解析器
        //获取lua解析器

        LuaEnv env = new LuaEnv();

        //解析器运行lua代码
        env.DoString("print('hello world')");
        //释放解析器

        env.Dispose();

        LuaCodeCSharp();

    }

    public void LuaCodeCSharp()
    {
        //c#调用lua函数
        LuaEnv env = new LuaEnv();
        env.DoString("print('hello world')");

        //lua调用c#代码
        Debug.Log("");
        env.DoString("CS.UnityEngine.Debug.Log('from lua hello worldss')");
        env.Dispose();
    }

}
