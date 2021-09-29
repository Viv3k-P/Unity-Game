using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeL : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter (Collision other)
    {
        if (other.collider.name == "Ball" && Global.count == 13)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1);
        }
        else{
            Debug.Log(Global.count);
        }
    }
}
