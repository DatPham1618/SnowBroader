using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finisheffect;
    [SerializeField] ParticleSystem finisheffect2;

    [SerializeField] float reloadtime = 1f;
    bool winning = false;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && !winning ){
            winning = true;
            FindObjectOfType<Controller_Player>().DisableControl();
            Debug.Log("You win");
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadtime);}
            finisheffect.Play();
            finisheffect2.Play();
        }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
      // Start is called before the first frame update
}
