using UnityEngine;

public class Movement_Enemy : MonoBehaviour
{

    public GameObject Player1;
    public float distanciaMaxima = 10f;
    public float Speed = 1f;
    
    void Update()
    {
        LookPlayer1();
        MovementEnemy();
        DistancePlayer1();
    }

    void LookPlayer1()
    {
        Quaternion rot = Quaternion.LookRotation(Player1.transform.position - transform.position);
        transform.rotation = rot;


    }

    void MovementEnemy()
    {
        transform.position = Vector3.Lerp(transform.position, Player1.transform.position, Speed * Time.deltaTime);
    }
    void DistancePlayer1()
    {
        float dist = Vector3.Distance(transform.position, Player1.transform.position);
        
        if (dist > distanciaMaxima)
        {
            Speed = 1f;
        } 
        else
        {
            Speed = 0f;
        }
    }

    void OnTriggerEnter(Collider col)
        {
            if(col.transform.gameObject.name =="Car_Blue")
            {
                Debug.Log("colisionaste");
            }
        }
}
