using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using WildBall.Inputs;

[RequireComponent(typeof(PlayerMovement))]
    

public class PlayInput : MonoBehaviour
{
    private Vector3 movement;
    private Vector3 jumpMove;

    private PlayerMovement playerMovement;

    private bool isJumpPermission = false;

    private const string _horizontalAxis = "Horizontal";
    private const string _verticalAxis = "Vertical";
    private const string _jumpButton = "Jump";

    private void Awake()
    {
        // Инициализируем переменную для работы со скриптом PlayerMovement
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        // Выбираем направления по осям
        float horizontal = Input.GetAxis(_horizontalAxis);
        float vertical = Input.GetAxis(_verticalAxis);
        float jump = Input.GetAxis(_jumpButton);

        // Создаем новый вектор для движения по осям x и z, и нормализуем его, создавая направление.
        movement = new Vector3 (-horizontal, 0, -vertical).normalized;

        // Создаем вектор для прыжка по оси y
        jumpMove = new Vector3 (0, jump, 0).normalized;

        // Если есть разрешение на прыжок, то можно прыгнуть
        if (isJumpPermission)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerMovement.JumpCharacter(jumpMove);
                isJumpPermission = false;
            }
        }
    }

    private void FixedUpdate()
    {
        playerMovement.MoveCharacter(movement);        
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        // Если игрок столкнулся с землей даем разрешение на прыжок
        if (collision.gameObject.CompareTag("Ground") == true)
            isJumpPermission = true;
    }
}
