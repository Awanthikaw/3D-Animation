using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSetter : MonoBehaviour
{
    public Animator animator;
    public float acceleration = 1f;

    float m_TargetSpeed = 1f;
    float m_CurrentSpeed = 1f;

    static readonly int k_HashSpeed = Animator.StringToHash ("SpeedMultiplier");

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Alpha1))
            m_TargetSpeed = 1f;
        
        if (Input.GetKeyDown (KeyCode.Alpha2))
            m_TargetSpeed = 2f;

        if (Input.GetKeyDown (KeyCode.Alpha3))
            m_TargetSpeed = 3f;

        if (Input.GetKeyDown (KeyCode.Alpha4))
            m_TargetSpeed = 4f;

        if (Input.GetKeyDown (KeyCode.Alpha5))
            m_TargetSpeed = 5f;


        m_CurrentSpeed = Mathf.MoveTowards (m_CurrentSpeed, m_TargetSpeed, acceleration * Time.deltaTime);
        
        animator.SetFloat (k_HashSpeed, m_CurrentSpeed);
    }
}
