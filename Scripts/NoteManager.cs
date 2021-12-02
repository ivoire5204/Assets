using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noteinfo {
    public double time; // note1.time과 같은 식으로 사용
    public short type;
    public Noteinfo(double _time, short _type) {
        time = _time;
        type = _type;
    }
}

public void createNote(List<Noteinfo> line, Transform tfNoteAppear, GameObject goNote, double currentTime) {
    if(currentTime >= line[0].time) {
        GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
        currentTime += Time.deltaTime;
        t_note.transform.SetParent(this.transform);
        line.RemoveAt(0);
    }
}

/*
            if(currentTime >= line1[0].time) // currentTime >= notetime 식으로? 배열 첫째 객체의 시간값 대조. 이후 해당 객체 삭제. 
        {
            GameObject t_note = Instantiate(goNote1, tfNoteAppear1.position, Quaternion.identity);
            currentTime += Time.deltaTime;
            t_note.transform.SetParent(this.transform);
            line1.RemoveAt(0);
        }
*/

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

    // 바이너리파일 1줄 정보
    public int numBasicNotes = 0;
    public int numOnNotes = 0;
    public int numOffNotes = 0;
    public int numLines = 0;

    // 바이너리파일 2줄 정보
    public double musicDelay = 0;

    // 게임데이터는 Noteinfo 객체의 리스트에 입력.
    public List<Noteinfo> line1 = new List<Noteinfo>();
    public List<Noteinfo> line2 = new List<Noteinfo>();
    public List<Noteinfo> line3 = new List<Noteinfo>();
    public List<Noteinfo> line4 = new List<Noteinfo>();

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        
        createNote(line1, tfNoteAppear1, goNote1, currentTime);
        createNote(line2, tfNoteAppear2, goNote2, currentTime);
        createNote(line3, tfNoteAppear3, goNote3, currentTime);
        createNote(line4, tfNoteAppear4, goNote4, currentTime);
    }
}
