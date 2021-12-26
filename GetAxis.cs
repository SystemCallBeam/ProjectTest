using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxis : MonoBehaviour
{
    public float range;
    public float z;
    public float y;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xpos = h * range;


        transform.position = new Vector3(xpos, y, z);
        Debug.Log(h);
    }
}
