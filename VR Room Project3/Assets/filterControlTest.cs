using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class filterControlTest : MonoBehaviour, IDial
{
    
    public AudioMixer masterMixer;
    public GameObject dialType;

    public void DialChanged(float dialvalue)
    {
        //Debug.Log(dialvalue);


        var requiredFilterPercentage = (dialvalue / 360f) *100f;
        var ResPercentage = dialvalue / 360f;

        var filterFlip = 100f;
        var osc1Value = -36.0f;
        var osc2Value = 0.0f;

        if(dialType.name == "FilterID")
        {
            //messured in 0-100%
            masterMixer.SetFloat("Synth1Cutoff", filterFlip - requiredFilterPercentage);
        }
        else if(dialType.name == "ResID")
        {
            masterMixer.SetFloat("Synth1Res", requiredFilterPercentage);
        }
        else if(dialType.name == "ReverbID")
        {
            masterMixer.SetFloat("Synth1Reverb", ResPercentage);
        }
        else if(dialType.name == "OctID")
        {
            if(requiredFilterPercentage == 0.0f || requiredFilterPercentage < 15.0f)
            {
                //0%
                osc1Value = -36.0f;
                osc2Value = -0.0f;

                masterMixer.SetFloat("Osc1transpose", osc1Value);
                masterMixer.SetFloat("Osc2transpose", osc2Value);
            }
            else if(requiredFilterPercentage > 15.0f || requiredFilterPercentage < 25.0f)
            {
                //20%
                osc1Value = -24.0f;
                osc2Value = 12.0f;

                masterMixer.SetFloat("Osc1transpose", osc1Value);
                masterMixer.SetFloat("Osc2transpose", osc2Value);
            }
            else if(requiredFilterPercentage > 25.0f || requiredFilterPercentage < 45.0f)
            {
                //40%
                osc1Value = -12.0f;
                osc2Value = 24.0f;

                masterMixer.SetFloat("Osc1transpose", osc1Value);
                masterMixer.SetFloat("Osc2transpose", osc2Value);
            }
            else if(requiredFilterPercentage > 55.0f || requiredFilterPercentage < 65.0f)
            {
                //60%
                osc1Value = 0.0f;
                osc2Value = 24.0f;

                masterMixer.SetFloat("Osc1transpose", osc1Value);
                masterMixer.SetFloat("Osc2transpose", osc2Value);
            }
            else if(requiredFilterPercentage > 75.0f || requiredFilterPercentage < 95.0f)
            {
                //80%
                osc1Value = 12.0f;
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
        else
        {
            Debug.Log("No Match");
        }
    	

        // Debug.Log($"percentage power {requiredLightPercentage}");

        // var lightIntensity = maxLightIntensity / 100f * requiredLightPercentage;
        // var lightmaterialEmission = maxMaterialEmission / 100f * (requiredLightPercentage/4);

        // Debug.Log($"light material property {lightmaterialEmission}");
        // lightCoilMaterial.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Vector4(15f, 5f, 0f) * lightmaterialEmission);
        // lightBulb.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Vector4(15f, 5f, 0f) * lightmaterialEmission/2);

        // linkedLight.intensity = lightIntensity;
    }

    
}
