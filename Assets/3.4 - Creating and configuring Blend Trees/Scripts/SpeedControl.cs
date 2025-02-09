using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{
    [Range(0f, 1f)]
    public float speed;

    Animator m_Animator;

    static readonly int k_HashSpeed = Animator.StringToHash("Speed");

    void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        m_Animator.SetFloat(k_HashSpeed, speed);
    }
}
