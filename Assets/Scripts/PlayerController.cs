using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private StateBehaviour _stateBehaviour;
    private bool _stop;
    private RandomHit _randomHit;
    private bool _IsAttack;
    
    public void Initialize(RandomHit randomHit)
    {
        _randomHit = randomHit;
    }
  
    private void Awake()
    {
        _stateBehaviour = FindObjectOfType<StateBehaviour>();
        _animator = GetComponent<Animator>();
        
    }

    public void Change()
    {
        _IsAttack = false;
    }

    void Update()
    {
        
        var step = Time.deltaTime * 1;
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetTrigger(_randomHit.GetRandomHit());
            _stop = false;
            _IsAttack = true;
        }

        if (_IsAttack)
        {
            return;
        }
        _stop = true;
        if (Input.GetKey(KeyCode.W))
        {
            _stop = false;
            transform.Translate(0,0,step,Space.Self);
           _animator.SetTrigger("Forward");
           
        }

        if (Input.GetKey(KeyCode.S))
        {
            _stop = false;
            transform.Translate(0,0,-step,Space.Self);
            _animator.SetTrigger("Back");
        }
        _animator.SetBool("Stop",_stop);

    }
}
