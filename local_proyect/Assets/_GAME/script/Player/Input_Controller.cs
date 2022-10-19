using UnityEngine;
[RequireComponent(typeof(movement))]

public class Input_Controller : MonoBehaviour
{

    
    [SerializeField] float Speed = 30f;
    [SerializeField] float RotationSpeed = 35f;

  


    private bool isCarGrounded;
    public float airDrag = 0.8f;
    public float groundDrag = 1f;
    public LayerMask groundLayer;
    public Rigidbody theRB;

    movement  _movement = null;



    void Awake()
    {
        _movement = GetComponent<movement>();
    }
    void Update()
    {
        Move();
                RaycastHit hit; 
        isCarGrounded = Physics.Raycast(transform.position, -transform.up, out hit, groundLayer);

        transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

        if (isCarGrounded)
        {
            theRB.drag = groundDrag;
        }
        else
        {
            theRB.drag = airDrag;
        }
    }

    void Move()
    {
        Vector2 input = _movement.MoveInput();

        transform.position += transform.forward * input.y * Speed * Time.deltaTime;
        transform.Rotate(Vector3.up * input.x * RotationSpeed * Time.deltaTime);
    }   
    


    



}