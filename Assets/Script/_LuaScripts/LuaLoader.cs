using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using XLua;
public class LuaLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaFileLoader();
    }

    public string[] filepath;

    public void LuaFileLoader()
    {
        LuaEnv env = new LuaEnv();
        //对应test.lua
        //内置加载器会扫描预制文件streamingAssets文件中是否存在lua文件
        //xlua默认streamingAssets为加载文件的目录

        //将自定义的加载器添加到xlua解析环境中
        env.AddLoader(ProjectLoader);

        LuaFileLoad(filepath, env);

        env.Dispose();

    }
    public void SystemLoader()
    {

    }

    //自定义路径下的加载lua文件
    public byte[] ProjectLoader(ref string filepath)
    {
        Debug.Log(filepath);

        string path = Application.dataPath;
        path = path.Substring(0,path.Length-7)+"/DataPath/Lua/"+filepath+".lua";
        Debug.Log(path);
        //读取为字节数组
        return File.ReadAllBytes(path);
    }

    public void LuaFileLoad(string[] filepath,LuaEnv env)
    {
        foreach( string path in filepath)
        {
            env.DoString("require('"+path+"')");
        }
    }
}
