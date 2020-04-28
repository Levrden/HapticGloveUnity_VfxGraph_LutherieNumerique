using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Globalization;
using UnityEngine.UI;
using MidiJack;

[ExecuteInEditMode]
public class testMidi : MonoBehaviour
{
    //public SendTestMIDIManager midiManager;
    //public Dropdown midiOutSelector;
	//public InputField message;

    uint ID = 932950976;
    uint midiValue = 0;//256, 512, 768, 1024, 1280, 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //uint id = midiManager.MidiOutDevices[ midiOutSelector.value ].Id;
		//uint msg = (uint)int.Parse(message.text, NumberStyles.HexNumber);
        MidiMaster.SendMessage(1079504864, midiValue);
    }
}
