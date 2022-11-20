using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
  
    [SerializeField] float tiempoTotal;
    float tiempoActual;
    public float vaciadoReloj;
    public bool termino = false;
    void Start()
    {
        tiempoActual = tiempoTotal;
    }

 
    void Update()
    {
        tiempoActual-= Time.deltaTime;
        vaciadoReloj = tiempoActual/tiempoTotal;
        if(tiempoActual <= 0)
        {
            termino = true;
        }
    }
}
