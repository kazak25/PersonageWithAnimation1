using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController _gameManager;
    [SerializeField] private RandomHit _randomHit;
    
    
    void Start()
    {
        _gameManager.Initialize(_randomHit);
    }
    
}
