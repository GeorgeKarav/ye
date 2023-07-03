using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {     // CREATES STEVE
      GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
      GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 4, 0);
      GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 4, 0);
      GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 5, 0);
      GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 5, 0);
      GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
