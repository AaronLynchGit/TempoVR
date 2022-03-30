using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sequencer_time : MonoBehaviour
{
    public AudioHelm.Sequencer sequencerHelm;
    public GameObject indicator1;
    public GameObject indicator2;
    public GameObject indicator3;
    public GameObject indicator4;

    public Material otherMaterial = null;
    private Material originalMaterial = null;

    private MeshRenderer mesh1;
    private MeshRenderer mesh2;
    private MeshRenderer mesh3;
    private MeshRenderer mesh4;

    private double position;
    private float pos;

    // Start is called before the first frame update
    void Start()
    {
        mesh1 = indicator1.GetComponent<MeshRenderer>();
        mesh2 = indicator2.GetComponent<MeshRenderer>();
        mesh3 = indicator3.GetComponent<MeshRenderer>();
        mesh4 = indicator4.GetComponent<MeshRenderer>();

        originalMaterial = mesh1.material;
    }

    // Update is called once per frame
    void Update()
    {
        position = sequencerHelm.GetSequencerPosition();
        pos = sequencerHelm.GetSixteenthTime();


        if(position < 16)
        {
            mesh1.material = otherMaterial;
            mesh2.material = originalMaterial;
            mesh3.material = originalMaterial;
            mesh4.material = originalMaterial;
        }
        else if(position > 16 && position < 32)
        {
            mesh1.material = originalMaterial;
            mesh2.material = otherMaterial;
            mesh3.material = originalMaterial;
            mesh4.material = originalMaterial;
        }
        else if(position > 32 && position < 48)
        {
            mesh1.material = originalMaterial;
            mesh2.material = originalMaterial;
            mesh3.material = otherMaterial;
            mesh4.material = originalMaterial;
        }
        else if(position > 48)
        {
            mesh1.material = originalMaterial;
            mesh2.material = originalMaterial;
            mesh3.material = originalMaterial;
            mesh4.material = otherMaterial;
        }
        else
        {
            mesh1.material = originalMaterial;
            mesh2.material = originalMaterial;
            mesh3.material = originalMaterial;
            mesh4.material = originalMaterial;
        }

        // if(position < 16)
        // {
        //     indicator1.SetActive(true);
        //     indicator2.SetActive(false);
        //     indicator3.SetActive(false);
        //     indicator4.SetActive(false);
        // }
        // else if(position > 16 && position < 32)
        // {
        //     indicator1.SetActive(false);
        //     indicator2.SetActive(true);
        //     indicator3.SetActive(false);
        //     indicator4.SetActive(false);
        // }
        // else if(position > 32 && position < 48)
        // {
        //     indicator1.SetActive(false);
        //     indicator2.SetActive(false);
        //     indicator3.SetActive(true);
        //     indicator4.SetActive(false);
        // }
        // else if(position > 48)
        // {
        //     indicator1.SetActive(false);
        //     indicator2.SetActive(false);
        //     indicator3.SetActive(false);
        //     indicator4.SetActive(true);
        // }
        // else
        // {
        //     indicator1.SetActive(false);
        //     indicator2.SetActive(false);
        //     indicator3.SetActive(false);
        //     indicator4.SetActive(false);
        // }


    }
}
