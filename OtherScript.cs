using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherScript : MonoBehaviour
{
    public GameObject otherGameOJ;

    private Script01 script01;
    private Script02 script02;
    private BoxCollider boxcol;
    private Transform otherTransform;

    void Awake() {
        script01 = GetComponent<Script01>();
        script02 = otherGameOJ.GetComponent<Script02>();
        boxcol = otherGameOJ.GetComponent<BoxCollider>();
        otherTransform = otherGameOJ.GetComponent<Transform>();

    }

    void Start() {
        otherTransform.position = new Vector3(0, 2, -4);
        boxcol.center = new Vector3(0, 1, 0);
        boxcol.size = new Vector3(3, 3, 3);
        Debug.Log("This is score " + script01.playerscore);
        Debug.Log("Player has died " + script02.DeathCount + " times");
    }
}
