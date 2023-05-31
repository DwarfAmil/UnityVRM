using System;
using UnityEngine;

public class key : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _animator.SetTrigger("01");
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _animator.SetTrigger("02");
        }
    }
}
