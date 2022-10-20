using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntuacion : MonoBehaviour
{

    
     public static Puntuacion instance;
     [SerializeField] private int cantidadPuntos;


       void Awake()
    {
         if (instance == null)
        {
            Puntuacion.instance = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }    
    }

    public void SumarPuntos(int Points)
    {
        cantidadPuntos += Points;
    }
}
