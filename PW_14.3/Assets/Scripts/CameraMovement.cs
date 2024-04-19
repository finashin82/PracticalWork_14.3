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
        // Расстояние от объекта до камеры.
        offset = transform.position - _playerTransform.position;
    }

    private void FixedUpdate()
    {
        // Положение камеры = Положение игрока + смещение
        transform.position = _playerTransform.position + offset;
    }
}
