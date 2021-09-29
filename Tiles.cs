using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    Color pink = new Color(0.673f, 0.000f, 1.000f, 1.000f);

    public void OnMouseDown(){
        transform.GetComponent<Renderer>().material.color= Color.green;
    }
    void OnCollisionEnter (Collision other){
    if (other.collider.name == "Ball" && transform.GetComponent<Renderer>().material.color == Color.black){

        transform.GetComponent<Renderer>().material.color= Color.green;
        Global.count += 1;
        Debug.Log(Global.count);

    }
    else if (other.collider.name == "Ball" && transform.GetComponent<Renderer>().material.color == Color.green){
        Global.count -= 1;
        transform.GetComponent<Renderer>().material.color= Color.black;
        Debug.Log(Global.count);
    }





}
}
