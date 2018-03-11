using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCreationScripth : MonoBehaviour {

    public float mapWidth;
    public float mapHeight;

    public GameObject quad;
    public GameObject ground;

	// Use this for initialization
	void Start () {
        GameObject leGround = Instantiate(ground, new Vector3(transform.position.x-0.5f,transform.position.y - 0.001f, transform.position.z), ground.transform.rotation);
        leGround.transform.localScale = new Vector3(mapWidth, mapHeight, 1);

        transform.position = new Vector3(0 - mapWidth / 2, 0, 0 + mapHeight / 2);
        createWorld(mapWidth, mapHeight);
	}
	
	// Update is called once per frame
	void createWorld (float width, float height) {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Instantiate(quad, transform.position, quad.transform.rotation);
                transform.Translate(new Vector3(1, 0, 0));
            }
            transform.Translate(new Vector3(0, 0, -1));
            transform.Translate(new Vector3(-width, 0, 0));
        }
	}
}
