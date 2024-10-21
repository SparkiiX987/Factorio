using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float speed;
    [SerializeField] private float waterSpeed;
    [SerializeField] private float fallingSpeed;


    [Header("Inputs"), HideInInspector]
    private InputSystem_Actions inputs;
    private InputAction movements;
    //private InputAction ;

    [Header("Others")]
    [SerializeField] private float returnSpeed;
    private Transform _transform;
    private bool isUnderWater;
    Rigidbody2D rb;


    private void Awake()
    {
        inputs = new InputSystem_Actions();
        movements = inputs.Player.Move;
        
    }

    private void OnEnable()
    {
        movements.Enable();
    }

    private void OnDisable()
    {
        movements.Disable();
    }

    void Start()
    {
        _transform = transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movements();
    }

    private void Movements()
    {
        if(!isUnderWater)
        {
            Vector2 displacementAxe = movements.ReadValue<Vector2>();
            _transform.position = new Vector2(_transform.position.x + (displacementAxe.x * speed), _transform.position.y);
        }
        else
        {
            Vector2 DisplacementAxe = movements.ReadValue<Vector2>();
            rb.AddForce((DisplacementAxe * waterSpeed), ForceMode2D.Impulse);
        }
    }

    private void SwitchToAir()
    {
        isUnderWater = false;
        rb.gravityScale = 1;
        rb.mass = 1;
    }

    private void SwitchToWater()
    {
        isUnderWater = true;
        rb.linearVelocity = Vector2.zero;
        rb.gravityScale = 0.01f;
        rb.mass = 1f;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Air"))
        {
            SwitchToAir();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Air"))
        {
            SwitchToWater();
        }
    }
}
