using UnityEngine;
using UnityEngine.UI;
using UnityToolKit.IO;

public class DemoTest : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text = FileReader
            .Read(FileReader.StreamingAssets + "/demo.txt");
    }

}
