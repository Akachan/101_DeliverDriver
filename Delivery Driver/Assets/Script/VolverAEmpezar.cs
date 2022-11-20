using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAEmpezar : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] GameObject boton;
    bool recargar = false;

private void Start() {
    
    
}
    // Update is called once per frame
    void Update()
    {
        if(timer.termino)
        {
            boton.SetActive(true);
            
        }
        else
        {
            boton.gameObject.SetActive(false);
        }

        if(recargar)
        {
            SceneManager.LoadScene("AtrapaLosBurrys");
        }
        
        
    }

    public void Cargar()
    {
        recargar = true;
    }

}
