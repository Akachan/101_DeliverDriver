using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pantalla : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI mostrar;
    [SerializeField] Image reloj;
    [SerializeField] Timer timer;
    [SerializeField] Contador pantalla;
    public string info;
   

    void Start()
    {
        mostrar = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Update() 
    {
        if(!timer.termino)
        {       
        mostrar.text = info;
        reloj.fillAmount = timer.vaciadoReloj;
        }
        else
        {
            mostrar.text = "Te mordió el barry, salvaste " + pantalla.contador.ToString() + " Barrys";
        }



    }

 
  
}
