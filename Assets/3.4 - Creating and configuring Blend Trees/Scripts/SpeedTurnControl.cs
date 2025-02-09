using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTurnControl : MonoBehaviour
{
    [Range(0f, 1f)]
    public float speed;

    [Range(-1, 1f)]
    public float turn;

    Animator m_Animator;

    static readonly int k_HashSpeed = Animator.StringToHash("Speed");
    static readonly int k_HashTurn = Animator.StringToHash("Turn");

    void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        m_Animator.SetFloat(k_HashSpeed, speed);
        m_Animator.SetFloat(k_HashTurn, turn);
    }
}
