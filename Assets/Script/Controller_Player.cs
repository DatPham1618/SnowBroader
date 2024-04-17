using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : MonoBehaviour
{   
    [SerializeField] float torqueamount = 1f;
    [SerializeField] float torqueamount2 = 1f;
    Rigidbody2D rb2d;

    [SerializeField] float boostSpeed = 30f;

    [SerializeField] float baseSpeed = 20f;

    public bool canmove = true;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(canmove)
        {
        RespondSpeed();
        NewMethod();
        }
    }
    void RespondSpeed(){
        if(Input.GetKey(KeyCode.UpArrow)){
            surfaceEffector2D.speed = boostSpeed;
        }
        else{
            surfaceEffector2D.speed = baseSpeed;
        }
    }
    void NewMethod()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueamount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(torqueamount2);
        }
    }

    public void DisableControl(){
        canmove = false;
    }
}
