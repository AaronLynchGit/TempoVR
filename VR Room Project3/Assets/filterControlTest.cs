using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class filterControlTest : MonoBehaviour, IDial
{
    
    public AudioMixer masterMixer;

    public void DialChanged(float dialvalue)
    {
        //Debug.Log(dialvalue);


        var requiredFilterPercentage = (dialvalue / 360f) *100f;

        masterMixer.SetFloat("Synth1Cutoff", requiredFilterPercentage);


        // Debug.Log($"percentage power {requiredLightPercentage}");

        // var lightIntensity = maxLightIntensity / 100f * requiredLightPercentage;
        // var lightmaterialEmission = maxMaterialEmission / 100f * (requiredLightPercentage/4);

        // Debug.Log($"light material property {lightmaterialEmission}");
        // lightCoilMaterial.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Vector4(15f, 5f, 0f) * lightmaterialEmission);
        // lightBulb.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Vector4(15f, 5f, 0f) * lightmaterialEmission/2);

        // linkedLight.intensity = lightIntensity;
    }

    
}
