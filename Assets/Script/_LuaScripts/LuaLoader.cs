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
        //��Ӧtest.lua
        //���ü�������ɨ��Ԥ���ļ�streamingAssets�ļ����Ƿ����lua�ļ�
        //xluaĬ��streamingAssetsΪ�����ļ���Ŀ¼

        //���Զ���ļ�������ӵ�xlua����������
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
