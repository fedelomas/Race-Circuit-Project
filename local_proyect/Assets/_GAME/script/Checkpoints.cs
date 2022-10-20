using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Checkpoints : MonoBehaviour
{

    public Text textoPoints;

    [SerializeField] private int cantidadPuntos;
     


   void Awake()
   {
    
   }

    void Update()
    {
        textoPoints.text = "" + cantidadPuntos.ToString("f0");
        CambiarEscena();

    }

    
        void CambiarEscena()
        {
            if (cantidadPuntos == 8)
            {
                SceneManager.LoadScene(1);
            }
            
        }

 void OnTriggerEnter(Collider col)
        {
            if (col.CompareTag  ("Player"))
        {
            Puntuacion.instance.SumarPuntos(cantidadPuntos);
        } 

        }
}
