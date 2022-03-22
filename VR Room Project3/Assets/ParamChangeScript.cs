using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ParamChangeScript : MonoBehaviour
{

    public AudioHelm.HelmController helmController;
    public float cutOff = 0.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void adjustCutOff()
    {
        //helmController.setParameterPercent(AudioHelm.Param.kSubVolume,subLevel)
        //helmController.setParameterPercent(AudioHelm.Param.kFilterCutoff,subLevel);
        //sequencerHelm.setParameterPercent(AudioHelm.Param.kSubVolume,subLevel);

       //void SetFloat(string Synth1Cutoff,float cutOff);

    }

    
}
