using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 0.3f;
    [SerializeField]  float moveSpeed = 10f;
    [SerializeField] float slowSpeed = 7f;
    [SerializeField] float boostSpeed = 15f;
    
    
    [Header("Audio")]
        [SerializeField] AudioClip boost;
        [SerializeField] AudioClip choque;


    [Header("Acceso a scripts")]
    [SerializeField] Timer timer;
    [SerializeField] Pantalla pantalla;


    
    
    
   
   

   


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(!timer.termino)
        {
            Movimiento();
        }

        

    }

    private void Movimiento()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
            pantalla.info = "esto es un boost";
            GetComponent<AudioSource>().PlayOneShot(boost);
            Destroy(other.gameObject, 0.1f);
        }     

    }
    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
        pantalla.info = "Sos una tortuga pibe";
        GetComponent<AudioSource>().PlayOneShot(choque);
    }


    
}
