using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip clip;
    private float RotateSpeed;
    // Update is called once per frame

    private void Start()
    {
        RotateSpeed = Random.Range(40, 70);
    }
    void Update()
    {
        float RotTime = RotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward,RotTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        AudioManage.Instance().Play(clip);
        AudioManage.Instance().GetPoint();

        Debug.Log("사운드출력");

        Destroy(gameObject);
    }
}
