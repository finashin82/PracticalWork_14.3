using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticleTrackingPlayer : MonoBehaviour
{
    [Tooltip("���� ��� Player. �������� ������ �� Player")]
    [SerializeField] private GameObject _player;    
   
    // Update is called once per frame
    void Update()
    {
        transform.position = _player.transform.position;       
    }    
}
