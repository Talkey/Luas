using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using XLua;

public class XLuasEnv
{

    private LuaEnv _Env;
    [Header("需要的lua文件名")]
    public string[] filepath;
    private static XLuasEnv _instance;

    private XLuasEnv()
    {
        _Env=new LuaEnv();
        _Env.AddLoader(_ProjectLoader);
        // LuaFileLoaderAdd(_Env);
    }

    public  static XLuasEnv Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance=new XLuasEnv();
            }    
            return _instance;
        }

    }
    /*
    public void LuaFileLoaderAdd(LuaEnv env)
    {
        //对应test.lua
        //内置加载器会扫描预制文件streamingAssets文件中是否存在lua文件
        //xlua默认streamingAssets为加载文件的目录

        //将自定义的加载器添加到xlua解析环境中
        env.AddLoader(_ProjectLoader);

        LuaFileLoad(filepath, env);

        env.Dispose();

    }

    */
    public byte[] _ProjectLoader(ref string filepath)
    {
        string path = Application.dataPath;
        path = path.Substring(0, path.Length - 7) + "/DataPath/Lua/" + filepath + ".lua";

        
        if (File.Exists(path))
        {
            return File.ReadAllBytes(path);
        }
        else
        {
            return null;
        }
    }


    public void FreeEnv()
    {
        _Env.Dispose();
        _instance = null;
    }

    public object[] LuaDoString(string code)
    {
        return _Env.DoString(code);
    }
}
