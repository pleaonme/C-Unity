// Place it in Player Controller

[SerializeField] private float jumpVelocity = 5f;

[SerializeField] private Transform groundCheck; // empty GameObject at player's feet
[SerializeField] private float groundDistance = 0.3f;
[SerializeField] private LayerMask groundMask;  // assign to "Ground" layer in Inspector

private Rigidbody rb;

void FixedUpdate() {
  if(Input.GetKeyDown(KeyCode.Space)) {
    if(IsGrounded()) {
      rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
    }
  }
}

private bool IsGrounded() {
  bool isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

  return isGrounded;
}
