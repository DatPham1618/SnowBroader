using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSkisnow : MonoBehaviour
{   
    [SerializeField] ParticleSystem Skieffect;
        void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.tag == "Ground"){
                Skieffect.Play();
            }}
        void OnCollisionExit2D(Collision2D other) {
            if(other.gameObject.tag == "Ground"){
                Skieffect.Stop();
            }
            
        }
        
    
}
