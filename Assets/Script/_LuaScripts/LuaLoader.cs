using System.Collections;
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

    public void LuaFileLoader()
    {
        LuaEnv env = new LuaEnv();
        //对应test.lua
        //内置加载器会扫描预制文件streamingAssets文件中是否存在lua文件
        //xlua默认streamingAssets为加载文件的目录

        //将自定义的加载器添加到xlua解析环境中
        env.AddLoader(ProjectLoader);

        env.DoString("require('test0')");

        env.Dispose();

    }
    public void SystemLoader()
    {

    }

    public byte[] ProjectLoader(ref string filepath)
    {
        Debug.Log(filepath);

        return null;
    }
}
