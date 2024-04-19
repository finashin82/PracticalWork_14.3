using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeAnimation1 : MonoBehaviour
{
    [Tooltip("����.")]
    [SerializeField] private Animator _animBridge;

    private bool bridgePermission = false;

    // Update is called once per frame
    void Update()
    {
        if (bridgePermission)
        {
            // �������� ����
            _animBridge.SetBool("trueBridge", true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ���� ����� �������� ������ ��������� �����, ���� ��������� �� ��������� �����
        if (collision.gameObject.tag == "Player")
        {
            bridgePermission = true;
        }
    }
}
