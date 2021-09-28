using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;

    private float xI;
    private float yI;
    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xI = Input.GetAxis("Horizontal");
        yI = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement(){
        rb.AddForce(new Vector3(xI,0,yI)*speed);

    }

  
}
