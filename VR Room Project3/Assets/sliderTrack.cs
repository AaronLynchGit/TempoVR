using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class sliderTrack : MonoBehaviour
{

    [SerializeField] private GameObject slider;
    [SerializeField] private GameObject idTag;
    public AudioMixer masterMixer;
    public Text text;
    [SerializeField] private float startPosition;
    [SerializeField] private float currentPosition;
    [SerializeField] private float currentPosDiff;

    [SerializeField] private float zeroPos;
    [SerializeField] private float topPos;
    [SerializeField] private float onePer;

    private float mixerValue;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = slider.transform.position.y;
        zeroPos = startPosition - 0.10f;
        topPos = startPosition + 0.10f;
        onePer = (topPos - zeroPos)/100;
        //Debug.Log("Start slider value " + startPosition);


    }

    // Update is called once per frame
    void Update()
    {
        //currentPosDiff = startPosition - currentPosition;
        //zeroPos - currentPosition;

        currentPosition = slider.transform.position.y;
        

        // Debug.Log("Current slider value " + (zeroPos - currentPosition));
       // Debug.Log("Current slider value " + (((topPos - currentPosition) / 0.002f) - 80.0f));
        //Debug.Log("Current slider value " + (((((topPos - currentPosition) / 0.002f) - 100.0f)*-1) - 80.0f));

        mixerValue = ((((topPos - currentPosition) / 0.002f) - 100.0f)*-1) - 65.0f;
       // masterMixer.SetFloat("Synth1Volume", mixerValue);

        //text.text = mixerValue + "%";

        if(idTag.name == "mixerID")
        {
            //messured in 0-100%
            masterMixer.SetFloat("Synth1Volume", mixerValue);
        }
        else if(idTag.name == "kickID")
        {
            masterMixer.SetFloat("kickVolume", mixerValue);
        }
        else if(idTag.name == "hatID")
        {
            masterMixer.SetFloat("hatVolume", mixerValue);
        }
        else if(idTag.name == "clapID")
        {
            masterMixer.SetFloat("clapVolume", mixerValue);
        }
        else if(idTag.name == "symbolID")
        {
            masterMixer.SetFloat("symbolVolume", mixerValue);
        }
        else if(idTag.name == "snareID")
        {
            masterMixer.SetFloat("snareVolume", mixerValue);
        }


    }
}
