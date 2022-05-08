using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] float delayTime=0.5f;
    [SerializeField] ParticleSystem crashEffect;

    [SerializeField] AudioClip crashSFX;

    bool hasCrashed=false;



    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Ground" && hasCrashed==false){
            hasCrashed=true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke("ReloadLevel",delayTime);
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
        }
    }
     void ReloadLevel(){
        SceneManager.LoadScene(0);
    }
}
