using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using WildBall.Inputs;

// ��������� ����������� ��������� ��� ������ Rigidbody. ������� ��������� �� ���������� ������ ������.
[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(0, 10)] private float speed = 5f;
    [SerializeField, Range(0, 10)] private float powerJump = 5f;

    private Rigidbody playerRigidbody;
    
    private void Awake()
    {
        // �������������� ���������� ��� ���������� ������ � RigidBody
        // ��� ������������� ������ ����� �������� � ����������� RigidBody
        playerRigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// �������� ������
    /// </summary>
    /// <param name="movement"></param>
    public void MoveCharacter(Vector3 movement)
    {
        // ������������ � ������ ���� � ����� ����������� � �������� �� ��������
        playerRigidbody.AddForce(movement * speed);
    }

    /// <summary>
    /// ������ ������
    /// </summary>
    /// <param name="jumpMove"></param>
    public void JumpCharacter(Vector3 jumpMove)
    {
        // ������������ � ������ ���� ��� ������
        playerRigidbody.AddForce(jumpMove * powerJump, ForceMode.Impulse);
    }    

    /// <summary>
    /// ���� � ��������� ��� ������ �������� ��������
    /// </summary>
#if UNITY_EDITOR // ����� ��� ����, ����� ����� ���� �� ����� � ������������� ������. �� ����� �������� ������ � EDITOR
    [ContextMenu("Reset Values")]

    public void ResetValues()
    {
        speed = 7;
    }
#endif
}
