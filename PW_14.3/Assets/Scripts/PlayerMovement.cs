using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using WildBall.Inputs;

// Объявляем необходимый компонент для работы Rigidbody. Удалить компонент из инспектора тепель незьля.
[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0, 10)] private float speed = 5f;
    [SerializeField, Range(0, 10)] private float powerJump = 5f;

    private Rigidbody playerRigidbody;
    
    private void Awake()
    {
        // Инициализируем переменную для дальнейшей работы с RigidBody
        // Без инициализации нельзя будет работать с компонентом RigidBody
        playerRigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Движение шарика
    /// </summary>
    /// <param name="movement"></param>
    public void MoveCharacter(Vector3 movement)
    {
        // Прикладываем к шарику силу в нашем направлении и умножаем на скорость
        playerRigidbody.AddForce(movement * speed);
    }

    /// <summary>
    /// Прыжок шарика
    /// </summary>
    /// <param name="jumpMove"></param>
    public void JumpCharacter(Vector3 jumpMove)
    {
        // Прикладываем к шарику силу для прыжка
        playerRigidbody.AddForce(jumpMove * powerJump, ForceMode.Impulse);
    }    

    /// <summary>
    /// Меню в редакторе для сброса настроек скорости
    /// </summary>
#if UNITY_EDITOR // Нужно для того, чтобы пункт меню не попал в окончательную сборку. Он будет доступен только в EDITOR
    [ContextMenu("Reset Values")]

    public void ResetValues()
    {
        speed = 7;
    }
#endif
}
