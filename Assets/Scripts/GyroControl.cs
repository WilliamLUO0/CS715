using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GyroControl : MonoBehaviour
{
    public GameObject avatar;
    private bool gyroEnabled;
    private Gyroscope gyro;
    private GameObject cameraContainter;
    private Quaternion rot;
    public TextMeshProUGUI debugText;


    // Start is called before the first frame update
    void Start()
    {
        // Create a new camera container that contains the main Wikitude camera
        cameraContainter = new GameObject("Camera Container");
        cameraContainter.transform.position = transform.position;
        transform.SetParent(cameraContainter.transform);

        // Set camera container as avatar child
        cameraContainter.transform.SetParent(avatar.transform);

        // Transform the camera position and pointing angle to the original player object setting
        cameraContainter.transform.position = avatar.transform.position + (new Vector3(0, 20, 0));

        gyroEnabled = EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }

        // Show debug messages
        // debugText.text = "[DEBUG]: gyroEnabled: " + gyroEnabled;
    }

    private bool EnableGyro()
    {
        // Check if phone supports gyroscope
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainter.transform.rotation = Quaternion.Euler(90f, 180f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }
}
