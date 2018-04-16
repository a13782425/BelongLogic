using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


namespace Belong.Logic.Utils
{

    public static class SerializedUtils
    {
        public static bool SerializeObject(object obj)
        {
            if (obj == null)
                return false;
            //内存实例  
            MemoryStream ms = new MemoryStream();
            //创建序列化的实例  
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);//序列化对象，写入ms流中    
            byte[] bytes = ms.GetBuffer();
            if (!Directory.Exists(GlobalValue.ConfigPath))
            {
                Directory.CreateDirectory(GlobalValue.ConfigPath);
            }
            if (File.Exists(GlobalValue.ConfigFilePath))
            {
                File.Delete(GlobalValue.ConfigFilePath);
            }
            //创建一个文件流
            FileStream fs = new FileStream(GlobalValue.ConfigFilePath, FileMode.Create);

            //将byte数组写入文件中
            fs.Write(bytes, 0, bytes.Length);
            //所有流类型都要关闭流，否则会出现内存泄露问题
            fs.Close();

            return true;
        }

        public static T DeserializeObject<T>() where T : class
        {
            if (!File.Exists(GlobalValue.ConfigFilePath))
            {
                Debug.LogError("没有找到文件");
                return null;
            }
            FileStream fs = new FileStream(GlobalValue.ConfigFilePath, FileMode.Open);
            ////获取文件大小
            //long size = fs.Length;
            //byte[] array = new byte[size];
            ////将文件读到byte数组中
            //fs.Read(array, 0, array.Length);

            object obj = null;
            BinaryFormatter formatter = new BinaryFormatter();
            obj = formatter.Deserialize(fs);//把内存流反序列成对象    
            fs.Close();

            return obj as T;
        }
        public static T DeserializeObject<T>(byte[] bytes) where T : class
        {
            object obj = null;
            if (bytes == null)
                return null;
            //利用传来的byte[]创建一个内存流  
            MemoryStream ms = new MemoryStream(bytes);
            ms.Position = 0;
            BinaryFormatter formatter = new BinaryFormatter();
            obj = formatter.Deserialize(ms);//把内存流反序列成对象    
            ms.Close();
            return obj as T;
        }
    }

}
