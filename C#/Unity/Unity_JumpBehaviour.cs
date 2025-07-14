// Place it in Player Controller

[SerializeField] private float jumpVelocity = 5f;

[SerializeField] private Transform groundCheck; // empty GameObject at player's feet
[SerializeField] private float groundDistance = 0.3f;
[SerializeField] private LayerMask groundMask;  // assign to "Ground" layer in Inspector

private Rigidbody rb;

void Update() 
{
  CheckJump();
}

private void CheckJump()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        if (IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse); // Rigidbody force to make Player jump
        }
    }
}

private bool IsGrounded()
{
    bool isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

    if (isGrounded && GetComponent<Rigidbody>().linearVelocity.y < 0) // Check if not falling
    {
        Vector3 vel = GetComponent<Rigidbody>().linearVelocity;
        vel.y = 0;
        GetComponent<Rigidbody>().linearVelocity = vel; // Reset velocity
    }

    return isGrounded;
}
