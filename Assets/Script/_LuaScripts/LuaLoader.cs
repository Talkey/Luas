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
        //��Ӧtest.lua
        //���ü�������ɨ��Ԥ���ļ�streamingAssets�ļ����Ƿ����lua�ļ�
        //xluaĬ��streamingAssetsΪ�����ļ���Ŀ¼

        //���Զ���ļ�������ӵ�xlua����������
        env.AddLoader(ProjectLoader);

        LuaFileLoad(filepath, env);

        env.Dispose();

    }
    public void SystemLoader()
    {

    }

    //�Զ���·���µļ���lua�ļ�
    public byte[] ProjectLoader(ref string filepath)
    {
        Debug.Log(filepath);

        string path = Application.dataPath;
        path = path.Substring(0,path.Length-7)+"/DataPath/Lua/"+filepath+".lua";
        Debug.Log(path);
        //��ȡΪ�ֽ�����
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
