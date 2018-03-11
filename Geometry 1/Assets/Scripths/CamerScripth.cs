using UnityEngine;

public class CamerScripth : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPos = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothPos;

        //Zooming
        const int orthographicSizeMin = 1;
        const int orthographicSizeMax = 15;

        if (Input.GetAxis("Mouse ScrollWheel") < 0) // forward
 {
            Camera.main.orthographicSize++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0) // back
 {
            Camera.main.orthographicSize--;
        }
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax);
    }
}