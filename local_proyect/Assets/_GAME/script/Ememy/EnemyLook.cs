using UnityEngine;

public class EnemyLook : MonoBehaviour
{

    public float Speed = 1;
    Vector3 RelativePosition;
    Quaternion TargetRotation;
    public Transform Target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookPlayer1();
    }

    void LookPlayer1()
    {
        RelativePosition = Target.position - transform.position;
        TargetRotation = Quaternion.LookRotation (RelativePosition);
        transform.rotation = Quaternion.Lerp(transform.rotation, TargetRotation, Time.time * Speed);
    }
}
