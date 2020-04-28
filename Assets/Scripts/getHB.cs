using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

[ExecuteInEditMode]
public class getHB : MonoBehaviour
{
    public int heartBeat = 0;
    public GameObject Vfx;


    void Update(){
        ReadString();
    }

       /*[MenuItem("Tools/Write file")]
    static void WriteString()
    {
        string path = "Assets/miband-heartrate-1.1.0/heartrate.txt";

        Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Heartrate");
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path); 
        TextAsset asset = Resources.Load("heartrate");

        //Print the text from the file
        Debug.Log(asset.text);
    }
    */

    //[MenuItem("Tools/Read file")]


    void ReadString()
    {
        string path = "Assets/miband-heartrate-1.1.0/heartrate.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path); 
        //Debug.Log(reader.ReadToEnd());
        var heartBeatReaded = int.Parse(reader.ReadToEnd());
        if(heartBeatReaded < 120 && heartBeatReaded > 60){
            updateHB(heartBeatReaded);
        }
        reader.Close();
    }

    void updateHB(int HB){
        heartBeat = HB;
        Vfx.GetComponent<var2Vfx>().UpdateFloatVar4(heartBeat);
    }

}
