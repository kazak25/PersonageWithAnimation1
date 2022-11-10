using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBehaviour : StateMachineBehaviour
{
     private PlayerController _playerController;
    public bool isAttack=true;

    private void Awake()
    {
        _playerController = FindObjectOfType<PlayerController>();
    }
    

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _playerController.Change();
    }

    
    
    

}
