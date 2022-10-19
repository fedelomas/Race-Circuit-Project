using System;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    public float timer = 12f;

    public Text textoTimer;
   
    void Awake()
    {
        
    }
    void Update()
    {
        timer -= Time.deltaTime;
        textoTimer.text = "" + timer.ToString("f0"); 

           if (timer <= 0f)
            {
                timer = 0;
            }
        
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

    
}
