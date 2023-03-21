using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{   
    public float mouseSens = 20;
    public Transform player = null;
    public float xRotation = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Mouse X") * mouseSens;
        float moveY = Input.GetAxis("Mouse Y") * mouseSens;

        xRotation -= moveY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.Rotate(Vector3.up * moveX);
        //transform.RotateAround(player.transform.position, -Vector3.up, moveX * mouseSens);
        //transform.RotateAround(Vector3.zero, transform.right, moveY * mouseSens);
    }
}
