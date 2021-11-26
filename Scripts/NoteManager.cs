using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;

    [SerializeField] Transform tfNoteAppear = null;
    [SerializeField] GameObject goNote = null;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= 60d / bpm) // 이후 비트 정보를 조건문에 넣음. bull IsNoteCreated.
        {
            GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            currentTime += Time.deltaTime;
            currentTime -= 60d / bpm;
        }
    }
}
