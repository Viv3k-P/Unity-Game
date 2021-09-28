using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject target;
    public float x,y,z;
    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(x,y,z);
        transform.LookAt(target.transform.position);
    }
}
