using UnityEngine;
using UnityEngine.InputSystem;

public class PC_CameraController : MonoBehaviour
{
#if UNITY_STANDALONE
    [SerializeField] private float sens;
    [SerializeField] private Transform playerBody;
    private Vector2 lookVector;
    private float xRotation = 0f, maxRotation = 90f;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    void Update()
    {
        xRotation -= lookVector.y;
        xRotation = Mathf.Clamp(xRotation, -maxRotation, maxRotation);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * lookVector.x); 
    }

    public void OnLook(InputValue value)
    {
        lookVector = value.Get<Vector2>() * sens * Time.deltaTime;
    }
#endif
}
