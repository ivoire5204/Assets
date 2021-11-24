using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        /*
        Pattern pattern = new Pattern(4,0,0,4);
        // tempdata
        pattern.addNote;
        pattern.addNote(1.0,0,0);
        pattern.addNote(1.5,0,0);
        pattern.addNote(2.0,0,0);
        */
        public int bpm = 0;
        double currentTime = 0d;

        [SerializeField] Transform tfNoteAppear = null;
        [SerializeField] GameObject goNote = null;

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            
        }
    }
}
