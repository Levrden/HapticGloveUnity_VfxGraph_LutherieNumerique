using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

[ExecuteInEditMode]
public class eventTrigger : MonoBehaviour
{
    public Camera vCam;
    private Texture2D Text2d;
    private RenderTexture rText;
    private Rect rect;
    private float col;
    private float finger;
    uint midiValue = 6;
    //private float indexD = 0;

    public float Col{
        get
        {
            return col;
        }
        set
        {
            col = value;
        }
    }

    /*public float IndexD{
        get
        {
            return indexD;
        }
        set
        {
            indexD = value;
        }
    }*/

    void Update()
    {
        GetTexture();

        finger = Mathf.Round(Text2d.GetPixel(8,8).grayscale*100);
        //Debug.Log("col : " + finger);
        TestColor(col);
       
        //MidiMaster.SendMessage(1079504864, midiValue);
        //indexD = 0;
    }

    void TestColor(float col){
        //sendMidi = true;
        //Debug.Log("col : " + col);
        /*if(finger == 8){
            Debug.Log("UN");
        } else if (finger == 22){
            Debug.Log("DEUX");
        } else if (finger == 34){
            Debug.Log("TROIS");
        } else if (finger == 45){
            Debug.Log("QUATRE");
        } else if (finger == 53){
            Debug.Log("CINQ");
        } else if (finger == 58){
            Debug.Log("SIX");
        } else */if (finger == 64){
            Debug.Log("SEPT");
            midiValue = 0;
            midiSend();
        } else if (finger == 68){
            Debug.Log("HUIT");
            midiValue = 256;
            midiSend();
        } else if (finger == 70){
            Debug.Log("NEUF");
            midiValue = 512;
            midiSend();
        } else if (finger == 73){
            Debug.Log("DIX");
            midiValue = 768;
            midiSend();
        } else if (finger == 76){
            Debug.Log("ONZE");
            midiValue = 1024;
            midiSend();
        } else if (finger == 77){
            Debug.Log("DOUZE");
            midiValue = 1280;
            midiSend();
        } else if (finger < 19){
        //indexD = 1;
        }
    }
    
    void GetTexture(){
        Text2d = new Texture2D(16,16,TextureFormat.RGB24, false);
        RenderTexture.active = rText;
        rText = vCam.targetTexture;
        rect = new Rect(0,0,16,16);
        Text2d.ReadPixels(rect, 0, 0);
        Text2d.Apply();
    }

    void midiSend(){
        MidiMaster.SendMessage(274749184, midiValue);
        Debug.Log("send");
    }
}


