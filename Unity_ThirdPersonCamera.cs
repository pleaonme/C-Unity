using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform target;            // Ссылка на игрока
    public Transform cameraTransform;   // Ссылка на Main Camera

    public float distance = 4.0f;       // Расстояние камеры от игрока
    public float sensitivity = 2.0f;    // Чувствительность мыши
    public Vector2 pitchLimits = new Vector2(-40f, 75f); // Ограничения по вертикали

    private float yaw = 0f;
    private float pitch = 0f;

    void Start()
    {
        if (target != null) // Проверяем, что ссылка на игрока установлена
        {
            Vector3 angles = transform.eulerAngles; // Получаем текущие углы поворота камеры
            yaw = angles.y; // Угол поворота по горизонтали
            pitch = angles.x; // Угол поворота по вертикали

            Cursor.lockState = CursorLockMode.Locked; // Блокируем курсор в центре экрана
            Cursor.visible = false; // Делаем курсор невидимым
        }
    }

    // Update is called once per frame
    void LateUpdate() // Используем LateUpdate для корректного обновления камеры после всех перемещений игрока
    {
        if (target == null || cameraTransform == null) return;

        // Управление мышью (Input Manager)
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        yaw += mouseX * sensitivity;
        pitch -= mouseY * sensitivity;
        pitch = Mathf.Clamp(pitch, pitchLimits.x, pitchLimits.y);

        // Позиция и поворот pivot-объекта
        // Следуем за игроком с небольшим смещением вверх
        transform.position = target.position;
        transform.rotation = Quaternion.Euler(pitch, yaw, 0);

        // Смещение камеры за pivot
        Vector3 offset = transform.rotation * new Vector3(0, 0, -distance);
        cameraTransform.position = transform.position + offset;
        cameraTransform.LookAt(target);
    }
}

