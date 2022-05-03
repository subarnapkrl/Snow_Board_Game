using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayTime=0.8f;
     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Player"){
            Invoke("ReloadLevel",delayTime);
        }
    }
    void ReloadLevel(){
        SceneManager.LoadScene(0);
    }
}