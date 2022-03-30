using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sequencer_time_16 : MonoBehaviour
{
    public AudioHelm.Sequencer sequencerHelm;
    public GameObject indicator1;
    public GameObject indicator2;
    public GameObject indicator3;
    public GameObject indicator4;
    public GameObject indicator5;
    public GameObject indicator6;
    public GameObject indicator7;
    public GameObject indicator8;
    public GameObject indicator9;
    public GameObject indicator10;
    public GameObject indicator11;
    public GameObject indicator12;
    public GameObject indicator13;
    public GameObject indicator14;
    public GameObject indicator15;
    public GameObject indicator16;

    public Material otherMaterial = null;
    private Material originalMaterial = null;

    private MeshRenderer mesh1;
    private MeshRenderer mesh2;
    private MeshRenderer mesh3;
    private MeshRenderer mesh4;
    private MeshRenderer mesh5;
    private MeshRenderer mesh6;
    private MeshRenderer mesh7;
    private MeshRenderer mesh8;
    private MeshRenderer mesh9;
    private MeshRenderer mesh10;
    private MeshRenderer mesh11;
    private MeshRenderer mesh12;
    private MeshRenderer mesh13;
    private MeshRenderer mesh14;
    private MeshRenderer mesh15;
    private MeshRenderer mesh16;

    private double position;
    private float pos;

    // Start is called before the first frame update
    void Start()
    {
        mesh1 = indicator1.GetComponent<MeshRenderer>();
        mesh2 = indicator2.GetComponent<MeshRenderer>();
        mesh3 = indicator3.GetComponent<MeshRenderer>();
        mesh4 = indicator4.GetComponent<MeshRenderer>();
        mesh5 = indicator5.GetComponent<MeshRenderer>();
        mesh6 = indicator6.GetComponent<MeshRenderer>();
        mesh7 = indicator7.GetComponent<MeshRenderer>();
        mesh8 = indicator8.GetComponent<MeshRenderer>();
        mesh9 = indicator9.GetComponent<MeshRenderer>();
        mesh10 = indicator10.GetComponent<MeshRenderer>();
        mesh11 = indicator11.GetComponent<MeshRenderer>();
        mesh12 = indicator12.GetComponent<MeshRenderer>();
        mesh13 = indicator13.GetComponent<MeshRenderer>();
        mesh14 = indicator14.GetComponent<MeshRenderer>();
        mesh15 = indicator15.GetComponent<MeshRenderer>();
        mesh16 = indicator16.GetComponent<MeshRenderer>();

        originalMaterial = mesh2.material;
    }

    // Update is called once per frame
    void Update()
    {
        position = sequencerHelm.GetSequencerPosition();
        pos = sequencerHelm.GetSixteenthTime();


        if(position < 1 && position > 0)
        { //MESH 1 CHANGE
            mesh16.material = originalMaterial;
            mesh1.material = otherMaterial;
            // mesh2.material = originalMaterial;
            // mesh3.material = originalMaterial;
            // mesh4.material = originalMaterial;
            // mesh5.material = originalMaterial;
            // mesh6.material = originalMaterial;
            // mesh7.material = originalMaterial;
            // mesh8.material = originalMaterial;
            // mesh9.material = originalMaterial;
            // mesh10.material = originalMaterial;
            // mesh11.material = originalMaterial;
            // mesh12.material = originalMaterial;
            // mesh13.material = originalMaterial;
            // mesh14.material = originalMaterial;
            // mesh15.material = originalMaterial;
            
        }
        else if(position > 1 && position < 2)
        {
            //MESH 2 CHANGE
            mesh1.material = originalMaterial;
            mesh2.material = otherMaterial;
        }
        else if(position > 2 && position < 3)
        {
            //MESH 3 CHANGE
            mesh2.material = originalMaterial;
            mesh3.material = otherMaterial;
            
        }
        else if(position > 3 && position < 4)
        {
            //MESH 4 CHANGE
            mesh3.material = originalMaterial;
            mesh4.material = otherMaterial;
            
        }
        else if(position > 4 && position < 5)
        {
            //MESH 5 CHANGE
            mesh4.material = originalMaterial;
            mesh5.material = otherMaterial;
            
        }
        else if(position > 5 && position < 6)
        {
            //MESH 6 CHANGE
            mesh5.material = originalMaterial;
            mesh6.material = otherMaterial;
            
        }
        else if(position > 6 && position < 7)
        {
            //MESH 7 CHANGE
            mesh6.material = originalMaterial;
            mesh7.material = otherMaterial;
            
        }
        else if(position > 7 && position < 8)
        {
            //MESH 8 CHANGE
            mesh7.material = originalMaterial;
            mesh8.material = otherMaterial;
            
        }
        else if(position > 8 && position < 9)
        {
            //MESH 9 CHANGE
            mesh8.material = originalMaterial;
            mesh9.material = otherMaterial;
            
        }
        else if(position > 9 && position < 10)
        {
            //MESH 10 CHANGE
            mesh9.material = originalMaterial;
            mesh10.material = otherMaterial;
            
        }
        else if(position > 10 && position < 11)
        {
            //MESH 11 CHANGE
            mesh10.material = originalMaterial;
            mesh11.material = otherMaterial;
            
        }
        else if(position > 11 && position < 12)
        {
            //MESH 12 CHANGE
            mesh11.material = originalMaterial;
            mesh12.material = otherMaterial;
            
        }
        else if(position > 12 && position < 13)
        {
            //MESH 13 CHANGE
            mesh12.material = originalMaterial;
            mesh13.material = otherMaterial;
            
        }
        else if(position > 13 && position < 14)
        {
            //MESH 14 CHANGE
            mesh13.material = originalMaterial;
            mesh14.material = otherMaterial;
            
        }
        else if(position > 14 && position < 15)
        {
            //MESH 15 CHANGE
            mesh14.material = originalMaterial;
            mesh15.material = otherMaterial;
            
        }
        else if(position > 15 && position < 16)
        {
            //MESH 16 CHANGE
            mesh15.material = originalMaterial;
            mesh16.material = otherMaterial;
            
        }
        else
        {
            mesh1.material = originalMaterial;
            mesh2.material = originalMaterial;
            mesh3.material = originalMaterial;
            mesh4.material = originalMaterial;
            mesh5.material = originalMaterial;
            mesh6.material = originalMaterial;
            mesh7.material = originalMaterial;
            mesh8.material = originalMaterial;
            mesh9.material = originalMaterial;
            mesh10.material = originalMaterial;
            mesh11.material = originalMaterial;
            mesh12.material = originalMaterial;
            mesh13.material = originalMaterial;
            mesh14.material = originalMaterial;
            mesh15.material = originalMaterial;
            mesh16.material = originalMaterial;
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
