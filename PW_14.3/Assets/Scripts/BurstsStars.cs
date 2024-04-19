using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;

public class BurstsStars : MonoBehaviour
{
    private ParticleSystem burstsStars;

    private void Start()
    {
        burstsStars = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���� ������ �������� �����, ���������� ����� ������
        if (other.CompareTag("Player"))
        {                     
            burstsStars.Play();            
        }
    }

    
}
