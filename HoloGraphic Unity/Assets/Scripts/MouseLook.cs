using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerBody;

    public float mouseSensitivityX;
    public float mouseSensitivityY;
    public Transform orientation;
    float xRotation;
    float yRotation;
    public bool flipY = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSensitivityX * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSensitivityY * Time.deltaTime * (flipY ? -1 : 1);

        xRotation += mouseY;
        yRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        //playerBody.Rotate(Vector3.up * xRotation);
    }
}
