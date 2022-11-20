using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Delivery : MonoBehaviour
{

    [SerializeField] Contador burry;
    [SerializeField] Pantalla pantalla;



    bool hasPet;
    [SerializeField] float delayDestroy;
    [SerializeField] Color32 hasPetColor = new Color32(0, 0, 0, 0);
    [SerializeField] Color32 notPetColor = new Color32(0, 0, 0, 0);
    SpriteRenderer spriteRenderer;





    [Header("Audio")]
    [SerializeField] AudioClip agarrar;
    [SerializeField] AudioClip entregar;


    
    
    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   
       
    }

  
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Pet" && !hasPet)
        {
            pantalla.info = "¡Encontré un Burry!";
            GetComponent<AudioSource>().PlayOneShot(agarrar);
            hasPet = true;
            Destroy(other.gameObject, delayDestroy);
            spriteRenderer.color = hasPetColor;
        }
        if (other.tag == "House" && hasPet)
        {
            pantalla.info = "¡Devolví al Burry a casita!";
            burry.contador++;
            GetComponent<AudioSource>().PlayOneShot(entregar);
            hasPet = false;
            spriteRenderer.color = notPetColor;
        }               
        
    }
}
