using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayTime=0.8f;
    [SerializeField] ParticleSystem finishEffect;
     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Player"){
            finishEffect.Play();
            Invoke("ReloadLevel",delayTime);
            GetComponent<AudioSource>().Play();
        }
    }
    void ReloadLevel(){
        
        SceneManager.LoadScene(0);
    }
}
