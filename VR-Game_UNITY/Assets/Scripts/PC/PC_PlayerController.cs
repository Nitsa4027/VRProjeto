using UnityEngine;
using UnityEngine.InputSystem;

public class PC_PlayerController : MonoBehaviour
{
#if UNITY_STANDALONE
    [Header("Movement")]
    [SerializeField] private float speed = 5f;
    private float runningMultiplier = 1f;
    private Vector2 inputVector;
    private float gravity = -9.81f;
    private CharacterController controller;

    [Header("Jump Check")]
    [SerializeField] private Transform playerFoot;
    private float sphereRadius = 0.4f;
    [SerializeField] private LayerMask layerGround;

    [Header("Support Variables")]
    private Vector3 velocity;
    private bool isGrounded;
    [HideInInspector] public bool moving, running, crouched;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(playerFoot.position, sphereRadius, layerGround);

        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }

        Vector3 direction = transform.right * inputVector.x + (transform.forward * inputVector.y * runningMultiplier);

        controller.Move(direction * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        inputVector = value.Get<Vector2>();
    }
#endif
}
