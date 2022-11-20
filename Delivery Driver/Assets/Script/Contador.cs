using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
   
   [SerializeField] TextMeshProUGUI numero;
   public int contador;
    void Start()
    {
        numero = GetComponentInChildren<TextMeshProUGUI>();
        
    }

  
    void Update()
    {
        numero.text = contador.ToString();
        
    }
}
