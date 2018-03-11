using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float speed;
    public GameObject worldCreator;
	
	// Update is called once per frame
	void Update () {
        speed = 2 * Camera.main.orthographicSize;

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);
    }
}
