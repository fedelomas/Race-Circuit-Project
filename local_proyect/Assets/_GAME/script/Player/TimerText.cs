using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerText : MonoBehaviour
{
    public float timer = 12;
    public int Points = 0;
    bool parar=false;

    public Text textoTimer;
    public Text textoPoints;
    
    void Awake()
    {

    }
    void Update()
    {
        //timer -= Time.deltaTime;
        textoTimer.text = "" + timer.ToString("f0");
        textoPoints.text = "" + Points.ToString("f0");
         
       
        CambiarEscena();
         
        if(!parar)
            {
                timer -= Time.deltaTime;
            }


        if (timer < 0)
            {
                parar = true;
            }
           
        
    }

    void OnTriggerEnter(Collider col)
        {
            if (col.transform.gameObject.tag == "Cheked")
            
        {
            AddTime();
            Points++;
          
           if (Points == 8)
            {
                SceneManager.LoadScene(1);
            }
        } 

        }

        void AddTime()
        {
            if (timer <= 12)
            {
                timer += 5;
            }
        }

        void CambiarEscena()
        {
            if (timer <= 0)
            {
                
                SceneManager.LoadScene(2);
            }
         
        }

    
}
