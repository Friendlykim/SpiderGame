using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    int myPoint = 0;
    public Text Ptext;

    static AudioManage _instance = null;
    public static AudioManage Instance()
    {
        return _instance;
    }

    void Start()
    {
        if (_instance == null)
            _instance = this;
    }

    void Update()
    {

        if(myPoint==12)
            Ptext.text = "        WIN";
        else Ptext.text = "Point : " + myPoint;

    }

    public void Play(AudioClip Clip)
    {
        GetComponent<AudioSource>().PlayOneShot(Clip);
    }

    public int GetPoint()
    {
        myPoint = myPoint + 1;
        return myPoint;
    }
}
