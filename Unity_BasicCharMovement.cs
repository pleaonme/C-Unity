using UnityEngine;

public class CharMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float walkSpeed = 5f;
    public float sprintSpeed = 9f;
    public float crouchSpeed = 2.5f;
    public float jumpHeight = 2f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;
    private bool isCrouching = false;

    private float originalHeight;
    public float crouchHeight = 1.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>(); // Прикрепляем CharacterController к персонажу
        originalHeight = controller.height; // Сохраняем оригинальную высоту CharacterController
    }

    // Update is called once per frame
    void Update()
    {
        // Проверяем, если персонаж на земле
        isGrounded = controller.isGrounded;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Небольшое значение для предотвращения "залипания" на земле
        }

        // Перемещение персонажа
        float x = Input.GetAxis("Horizontal"); // Получаем горизонтальное перемещение
        float z = Input.GetAxis("Vertical"); // Получаем вертикальное перемещение

        Vector3 move = transform.right * x + transform.forward * z;

        float currentSpeed = walkSpeed;

        // Проверка на спринт
        if (Input.GetKey(KeyCode.LeftShift) && !isCrouching)
        {
            currentSpeed = sprintSpeed;
        }
        // Проверка на приседание
        if ((Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.C)) && !isCrouching)
        {
            isCrouching = true;
            controller.height = crouchHeight;
        }
        else if ((Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.C)) && isCrouching)
        {
            isCrouching = false;
            controller.height = originalHeight;
        }

        if (isCrouching)
        {
            currentSpeed = crouchSpeed;
        }

        controller.Move(move * currentSpeed * Time.deltaTime); // Перемещение персонажа с учетом скорости через CharacterController

        // Прыжок
        if (Input.GetButtonDown("Jump") && isGrounded && !isCrouching)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); // Вычисляем скорость прыжка на основе высоты прыжка и гравитации
        }

        // Гравитация
        velocity.y += gravity * Time.deltaTime; // Применяем гравитацию к вертикальной скорости
        controller.Move(velocity * Time.deltaTime); // Перемещение персонажа с учетом гравитации
    }
}
