using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] float delayTime=0.5f;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Ground"){
            Invoke("ReloadLevel",delayTime);
        }
    }
     void ReloadLevel(){
        SceneManager.LoadScene(0);
    }
}
