using System.IO;
using UnityEngine;

namespace UnityToolKit.IO{
    public class FileReader
    {
        ///<summary>
        /// revert cross-platform path to streaming assets
        ///</summary>
        public static string StreamingAssets {
            get{
                #if UNITY_ANDROID && !UNITY_EDITOR
                return "jar:file://" + Application.dataPath + "!/assets";
                #endif
                #if UNITY_IOS
                return  Application.dataPath + "/Raw";
                #endif
                return  Application.streamingAssetsPath;
            }
        }

        public static string Read(string path){
            #if UNITY_ANDROID && !UNITY_EDITOR
            WWW reader = new WWW(path);
            while(!reader.isDone){}
            return reader.text;
            #endif
            return File.ReadAllText(path);
        }

        public static void Write(string path , string data){
            throw new System.NotImplementedException();
        }
    }
}
