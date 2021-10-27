using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinClipPlay : MonoBehaviour
{
    public AudioClip clip;

    void OnCollisionEnter(Collision collision)
    {
        AudioManage.Instance().Play(clip);

        Debug.Log("사운드출력");

        Destroy(this.gameObject);

       
    }

}

