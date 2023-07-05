using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int lives = 10;
    public int speed = 20;
    public int levels = 2;
    // Start is called before the first frame update
    void Start()
    {
        lives += levels;
        print(lives);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
    }
}
