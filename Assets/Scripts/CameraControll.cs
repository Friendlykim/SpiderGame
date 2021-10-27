using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform Player;

    private void Update()
    {
        CameraFollow();
    }

    private void CameraFollow()
    {
        Vector3 camvec = new Vector3(0, 50.0f, -30.0f);

        transform.position = Player.position + camvec;

        transform.LookAt(Player);
    }

}
