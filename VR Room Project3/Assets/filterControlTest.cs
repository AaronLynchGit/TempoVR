using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class filterControlTest : MonoBehaviour, IDial
{
    
    public AudioMixer masterMixer;
    public GameObject dialType;
    
    public AudioHelm.HelmController helmController;
    public void DialChanged(float dialvalue)
    {
        //Debug.Log(dialvalue);


        var requiredFilterPercentage = (dialvalue / 360f) *100f;
        var ResPercentage = dialvalue / 360f;

        float delayVal;
        float testVar2;
        

        var filterFlip = 100f;
        var osc1Value = -36.0f;
        var osc2Value = 0.0f;

        var testVar = 0.0f;

        if(dialType.name == "FilterID")
        {
            //messured in 0-100%
            masterMixer.SetFloat("Synth1Cutoff", filterFlip - requiredFilterPercentage);
        }
        else if(dialType.name == "ResID")
        {
            masterMixer.SetFloat("Synth1Res", requiredFilterPercentage);
        }
        else if(dialType.name == "FreqID")
        {
            //masterMixer.SetFloat("Synth1Res", requiredFilterPercentage);
            helmController.SetParameterPercent(AudioHelm.Param.kResonance, ResPercentage);
        }
        else if(dialType.name == "NewFilterID")
        {
            //masterMixer.SetFloat("Synth1Res", requiredFilterPercentage);
            helmController.SetParameterPercent(AudioHelm.Param.kFilterCutoff,ResPercentage);
        }
        else if(dialType.name == "SubID")
        {
            //masterMixer.SetFloat("Synth1Res", requiredFilterPercentage);
            helmController.SetParameterPercent(AudioHelm.Param.kNoiseVolume,ResPercentage);
        }
        else if(dialType.name == "ReverbID")
        {
            masterMixer.SetFloat("Synth1Reverb", ResPercentage);
        }
        else if(dialType.name == "delayID")
        {
            //2.5 times seems to be sweet spot for in time
            delayVal = requiredFilterPercentage * 5f;
            masterMixer.SetFloat("Synth1Delay", delayVal);
        }
        else if(dialType.name == "GateID")
        {
            masterMixer.SetFloat("Synth1Gate", ResPercentage);
           // Debug.Log("GateTest:"+ ResPercentage);
           Debug.Log("GateTest:"+ masterMixer.GetFloat("Synth1Gate",out testVar2));
        }
        else if(dialType.name == "OctID")
        {

            Debug.Log("OctTest:"+ requiredFilterPercentage);
            if(requiredFilterPercentage < 18f)
            {
                //0%
                osc1Value = -36.0f;
                osc2Value = -0.0f;

                masterMixer.SetFloat("Osc1transpose", osc1Value);
                masterMixer.SetFloat("Osc2transpose", osc2Value);
            }
            else if(requiredFilterPercentage > 19f && dialvalue < 38f)
            {
                //20%
                osc1Value = -24.0f;
                osc2Value = 12.0f;

                masterMixer.SetFloat("Osc1transpose", osc1Value);
                masterMixer.SetFloat("Osc2transpose", osc2Value);
            }
            else if(dialvalue > 39f && dialvalue < 59f)
            {
                //40%
                osc1Value = -12.0f;
                osc2Value = 24.0f;

                masterMixer.SetFloat("Osc1transpose", osc1Value);
                masterMixer.SetFloat("Osc2transpose", osc2Value);
            }
            
            else
            {
                // osc1Value = -36.0f;
                // osc2Value = -0.0f;

                // masterMixer.SetFloat("Osc1transpose", osc1Value);
                // masterMixer.SetFloat("Osc2transpose", osc2Value);
            }
            
        }

        //*****Here i will put my drum delay controls*****

        else if(dialType.name == "kickID")
        {
            delayVal = requiredFilterPercentage * 5f;
            masterMixer.SetFloat("kickDelay", delayVal);
        }
        else if(dialType.name == "kickFilterID")
        {
            delayVal = requiredFilterPercentage * 25f;
            masterMixer.SetFloat("kickFilter", delayVal);
        }

        else if(dialType.name == "hatID")
        {
            delayVal = requiredFilterPercentage * 10f;
            masterMixer.SetFloat("hatDelay", delayVal);
        }
        else if(dialType.name == "hatFilterID")
        {
            delayVal = requiredFilterPercentage * 25f;
            masterMixer.SetFloat("hatFilter", delayVal);
        }

        else if(dialType.name == "clapID")
        {
            delayVal = requiredFilterPercentage * 10f;
            masterMixer.SetFloat("clapDelay", delayVal);
        }
        else if(dialType.name == "clapFilterID")
        {
            delayVal = requiredFilterPercentage * 25f;
            masterMixer.SetFloat("clapFilter", delayVal);
        }

        else if(dialType.name == "symbolID")
        {
            delayVal = requiredFilterPercentage * 10f;
            masterMixer.SetFloat("symbolDelay", delayVal);
        }
        else if(dialType.name == "symbolFilterID")
        {
            delayVal = requiredFilterPercentage * 25f;
            masterMixer.SetFloat("symbolFilter", delayVal);
        }

        else if(dialType.name == "snareID")
        {
            delayVal = requiredFilterPercentage * 10f;
            masterMixer.SetFloat("snareDelay", delayVal);
        }
        else if(dialType.name == "snareFilterID")
        {
            delayVal = requiredFilterPercentage * 25f;
            masterMixer.SetFloat("snareFilter", delayVal);
        }

        else
        {
            Debug.Log("No Match");
        }
    	Debug.Log("OctTest2:"+ masterMixer.GetFloat("Osc1transpose",out testVar));

        // Debug.Log($"percentage power {requiredLightPercentage}");

        // var lightIntensity = maxLightIntensity / 100f * requiredLightPercentage;
        // var lightmaterialEmission = maxMaterialEmission / 100f * (requiredLightPercentage/4);

        // Debug.Log($"light material property {lightmaterialEmission}");
        // lightCoilMaterial.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Vector4(15f, 5f, 0f) * lightmaterialEmission);
        // lightBulb.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Vector4(15f, 5f, 0f) * lightmaterialEmission/2);

        // linkedLight.intensity = lightIntensity;
    }

    
}
