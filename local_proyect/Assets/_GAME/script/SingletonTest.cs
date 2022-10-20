using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    public static SingletonTest instancia;
    void Awake()
    {
         if (instancia == null)
        {
            SingletonTest.instancia = this;
            DontDestroyOnLoad(gameObject);
        }else
        {
            Destroy(gameObject);
        }    
    }
    
    void Update()
    {
        
    }
}
