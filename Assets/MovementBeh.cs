using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBeh : MonoBehaviour
{
    Transform CameraTransform;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        CameraTransform = transform;
        transform.GetComponent<Camera>().orthographicSize = 5;
        transform.position = new Vector3(0, 0,-10);
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y>=transform.position.y)
        {
            CameraTransform.position = new Vector3(CameraTransform.position.x,Player.transform.position.y,CameraTransform.position.z);
        }
    }
}
