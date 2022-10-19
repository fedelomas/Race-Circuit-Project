using System.Collections;
using UnityEngine;

public class enemy_behavior : MonoBehaviour
{
    public GameObject Player1;
    public float distanciaMaxima = 10f;
    public float Speed = 1f;

    public enum enemy_behaviors
    {
        LookPlayer1,
        MovementEnemy,
        Look_and_Movement
    }

    public enemy_behaviors type_of_behaviors;

    void Update()
    {
        SwitchBehavior();
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

    public void SwitchBehavior()
    {
        switch (type_of_behaviors)
        {
            case enemy_behaviors.LookPlayer1:
                LookPlayer1();
                break;
            case enemy_behaviors.MovementEnemy:
                MovementEnemy(); DistancePlayer1();
                break;
            case enemy_behaviors.Look_and_Movement:
            LookPlayer1(); MovementEnemy(); DistancePlayer1();
            break;
        }
        
    }
}
