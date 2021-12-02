using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 

public class Noteinfo {
    // 바이너리 파일 3줄부터의 정보
    private double noteTime;
    private short noteLine;
    private short noteType;
    private bool isLineActive;

    public Noteinfo(double _noteTime, short _noteLine, short _noteType, bool _isLineActive) {
        double noteTime = _noteTime;
        short noteLine = _noteLine;
        short noteType = _noteType;
        bool isLineActive = _isLineActive;
    }
}

public class NoteManager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;

    // 제어할 오브젝트. GameManager 없이 여기서 4개 라인 모두 관리.
    [SerializeField] Transform tfNoteAppear1 = null;
    [SerializeField] Transform tfNoteAppear2 = null;
    [SerializeField] Transform tfNoteAppear3 = null;
    [SerializeField] Transform tfNoteAppear4 = null;
    [SerializeField] GameObject goNote1 = null;
    [SerializeField] GameObject goNote2 = null;
    [SerializeField] GameObject goNote3 = null;
    [SerializeField] GameObject goNote4 = null;

    // 바이너리파일 1줄 정보. gamedata.
    public int numBasicNotes = 0;
    public int numOnNotes = 0;
    public int numOffNotes = 0;
    public int numLines = 0;
    public double musicDelay = 0;

    // 게임데이터는 Noteinfo 객체의 리스트에 입력.
    /*
    Noteinfo note1 = new Noteinfo(0.0, 0, 0, true);
    Noteinfo note2 = new Noteinfo(1.0, 1, 0, true);
    Noteinfo note3 = new Noteinfo(2.0, 2, 0, true);
    Noteinfo note4 = new Noteinfo(3.0, 3, 0, true);
    */

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= 60d / bpm) // 라인별로 조건문? bull IsNoteCreated.
        {
            GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            currentTime += Time.deltaTime;
            t_note.transform.SetParent(this.transform);
            currentTime -= 60d / bpm;
        }
    }
}
