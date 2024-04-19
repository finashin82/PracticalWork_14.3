using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Tooltip("Player.")]
    [SerializeField] private Transform _playerTransform;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // ���������� �� ������� �� ������.
        offset = transform.position - _playerTransform.position;
    }

    private void FixedUpdate()
    {
        // ��������� ������ = ��������� ������ + ��������
        transform.position = _playerTransform.position + offset;
    }
}
