using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSequencerScript : MonoBehaviour
{
    bool toggleNote = false;

    public int startingNote = 60;
    public int stepInSequence = 0;
    public int octave = 0;
    public float subLevel = 0.0f;
    public AudioHelm.Sequencer sequencerHelm;
    public AudioHelm.HelmController helmController;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addNoteToSequencer()
    {
        sequencerHelm.AddNote(startingNote,stepInSequence,stepInSequence+1); 
    }

    public void removeNoteFromSequencer()
    {
        sequencerHelm.RemoveNotesInRange(startingNote,stepInSequence,stepInSequence+1); 
    }

    public void addChordToSequencer()
    {
        sequencerHelm.AddNote(startingNote,stepInSequence,stepInSequence+16); 
    }

    public void removeChordFromSequencer()
    {
        sequencerHelm.RemoveNotesInRange(startingNote,stepInSequence,stepInSequence+16); 
    }

    public void addFullNoteToSequencer()
    {
        sequencerHelm.AddNote(startingNote+(octave*12),stepInSequence,stepInSequence+16); 
    }

    public void removeFullNoteFromSequencer()
    {
        sequencerHelm.RemoveNotesInRange(startingNote+(octave*12),stepInSequence,stepInSequence+16); 
    }

    public void changeOctaveUp()
    {
        octave++;
    }

    public void changeOctaveDown()
    {
        octave--;
    }
}
