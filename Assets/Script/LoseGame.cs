using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour

{   [SerializeField] ParticleSystem deadeffect;
    [SerializeField] float reloadtime = 1f;

    bool Lose = false;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground" && !Lose){
            Debug.Log("You Lose");
            {   
                Lose = true;
                FindObjectOfType<Controller_Player>().DisableControl();
                GetComponent<AudioSource>().Play();
                Invoke("ReloadScene", reloadtime);
                deadeffect.Play();
            }   
        }    
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
