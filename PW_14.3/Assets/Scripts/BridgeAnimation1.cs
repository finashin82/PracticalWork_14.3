using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeAnimation1 : MonoBehaviour
{
    [Tooltip("Мост.")]
    [SerializeField] private Animator _animBridge;

    private bool bridgePermission = false;

    // Update is called once per frame
    void Update()
    {
        if (bridgePermission)
        {
            // Опускаем мост
            _animBridge.SetBool("trueBridge", true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Если игрок коснулся кнопки опускания моста, даем разрешние на опускание моста
        if (collision.gameObject.tag == "Player")
        {
            bridgePermission = true;
        }
    }
}
