using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using XLua;

public class XLuasEnv
{

    private LuaEnv _Env;
    private static XLuasEnv _instance;

    private XLuasEnv()
    {
        _Env = new LuaEnv();
        _Env.AddLoader(_ProjectLoader);
        // LuaFileLoaderAdd(_Env);
    }

    public static XLuasEnv Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new XLuasEnv();
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
    /// <summary>
    /// 调用方式为填写对应的文件名
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public object[] LuaDoString(string code)
    {

        if (File.Exists(code + ".lua") == false)
        {
            FileStream luaFileName_Creating = File.Create(code + ".lua");
            luaFileName_Creating.Close();
            Debug.Log("为空创建" + code);
            return _Env.DoString("require('" + code + "')");
        }

        return _Env.DoString("require('" + code + "')");
    }

    public object[] LuaDoStrings(string luaFileName)
    {
        return _Env.DoString("require('" + luaFileName + "')");
    }

    /// <summary>
    /// 调用方式为通过路径和文件名来调用
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="luaFileName"></param>
    /// <returns></returns>
    public object[] LuaDoString_by_Path_FileName(string filePath, string luaFileName)
    {
        string path = filePath + "/" + luaFileName;

        if (File.Exists(path + ".lua") == false)
        {
            FileStream luaFileName_Creating = File.Create(path + ".lua");
            luaFileName_Creating.Close();
            Debug.Log("为空创建" + path);
        }
        return LuaDoStrings(path);
    }

    public object[] LuaDoString1(string filePath)
    {
        var type = GetType();

        string luaFileName = type.ToString();
        return _Env.DoString("require('" + filePath + "/" + luaFileName + "')");
    }



}