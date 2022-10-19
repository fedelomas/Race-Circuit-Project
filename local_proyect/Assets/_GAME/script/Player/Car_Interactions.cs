using UnityEngine;

public class Car_Interactions : MonoBehaviour
{
    public GameObject Check1;
    public GameObject Check2;
    public GameObject Check3;
    public GameObject Check4;
    Vector3 posInicial;


    void Start()
    {
         ToggleCheck();
         posInicial = transform.position;
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
        {
            if (col.transform.gameObject.tag == "Cheked")
        {
            ToggleCheck();
        } 
        if (col.transform.gameObject.tag == "Floor" )
        {
            Respawn();
        }
        }

        void OnCollisionEnter(Collision col)
        {
            if (col.transform.gameObject.tag == "Enemy" )
        {
            Respawn();
        }
        }

    void ToggleCheck()
        {
                if (Check4.activeInHierarchy)
                {
                    Check1.SetActive(true);
                    Check2.SetActive(false);
                    Check3.SetActive(false);
                    Check4.SetActive(false);
                }
                else if (Check1.activeInHierarchy)
                {
                    Check1.SetActive(false);
                    Check2.SetActive(true);
                    Check3.SetActive(false);
                    Check4.SetActive(false);
                }
                else if (Check2.activeInHierarchy)
                {
                    Check1.SetActive(false);
                    Check2.SetActive(false);
                    Check3.SetActive(true);
                    Check4.SetActive(false);
                }
                else if (Check3.activeInHierarchy)
                {
                    Check1.SetActive(false);
                    Check2.SetActive(false);
                    Check3.SetActive(false);
                    Check4.SetActive(true);
                }
                 
        }

        void Respawn() 
        {
            transform.position = posInicial;
        }
}
