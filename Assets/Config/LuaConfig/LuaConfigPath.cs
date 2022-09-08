using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class LuaConfigPath : MonoBehaviour
{

    [Header("需要的lua文件名和路径结构体")]
    public FileConfigClass[] configFileList;
    //public  string[] filepaths;
    //public FilePathStruct filePathStruct;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


public enum FilePathFolder
{
    NullCon,
    LuaCon,
    UnityCon,
    CSharpCon
}

public class FileConfigClass : MonoBehaviour
{
    FilePathFolder fileType;
    public string[] filepaths;
}

