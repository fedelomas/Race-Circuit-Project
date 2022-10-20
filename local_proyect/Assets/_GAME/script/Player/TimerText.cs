using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerText : MonoBehaviour
{
    public float timer = 12f;
     public int Points = 0;

    public Text textoTimer;
    
   
    void Awake()
    {
       
    }
    void Update()
    {
        timer -= Time.deltaTime;
        textoTimer.text = "" + timer.ToString("f0");
         
       
        CambiarEscena();
           
        
    }

    void OnTriggerEnter(Collider col)
        {
            if (col.transform.gameObject.tag == "Cheked")
        {
            AddTime();
        } 

        }

        void AddTime()
        {
            if (timer <= 12f)
            {
                timer += 5f;
            }
        }

        void CambiarEscena()
        {
           if (timer <= 0f)
            {
                SceneManager.LoadScene(1);
            }
            if (Points == 8)
            {
                SceneManager.LoadScene(1);
            }
            
        }

    
}
