using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    public LayerMask groundLayer;

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Движение влево/вправо
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");   // W/S
        Vector3 movement = new Vector3(moveX * moveSpeed, rb.velocity.y, moveZ * moveSpeed);
        rb.velocity = movement;

        // Прыжок
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }

        Quaternion targetRotation = transform.rotation;  

        if(moveX > 0.1f)
        {
            targetRotation = Quaternion.Euler(0, 90, 0);
        }
        else if (moveX < -0.1f)
        
        {
            targetRotation = Quaternion.Euler(0, -90, 0);
        }
        else
        {
            targetRotation = Quaternion.Euler(0, 0, 0);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 5f * Time.deltaTime) ;
    }

    bool IsGrounded()
    {
        // Проверка земли через Raycast
        return Physics.Raycast(transform.position, Vector3.down, 1.1f, groundLayer);
    }
}
