/**************************************************
Copyright : Copyright (c) RealaryVR. All rights reserved.
Description: Script for VR Button functionality.
***************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR2 : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed;
    bool toggleNote = false;

    public GameObject octave1;
    public GameObject octave2;

    public int startingNote = 60;
    public int stepInSequence = 0;
    public AudioHelm.Sequencer sequencer;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;
            
            if(!toggleNote)
            {
                toggleNote = true;
            }
            else if(toggleNote) 
            {
                toggleNote = false;
            }


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser)
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SpawnSphere()
    {
        // if(toggleNote)
        // {
        //     octave1.SetActive();
        // }
        // else if(!toggleNote) 
        // {
        //     octave2.SetActive();
        // }


        octave1.SetActive(toggleNote);
        octave2.SetActive(!toggleNote);
    }

    public void addNoteToSequencer()
    {
        // if(toggleNote)
        // {
        //     octave1.SetActive();
        // }
        // else if(!toggleNote) 
        // {
        //     octave2.SetActive();
        // }
        //sequencer.AddNote(startingNote,stepInSequence,stepInSequence+1);
    }

    public void removeNoteFromSequencer()
    {
        //sequencer.AddNote(startingNote,stepInSequence,stepInSequence+1);
        sequencer.RemoveNotesInRange(startingNote,stepInSequence,stepInSequence+1);
    }
}
