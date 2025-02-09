using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendingExample : MonoBehaviour
{
    [Range (0f, 1f)]
    public float weight = 1f;
    
    Animator m_Animator;
    
    static readonly int k_HashWeight = Animator.StringToHash("Weight");

    void Start ()
    {
        m_Animator = GetComponent<Animator> ();
    }

    void Update ()
    {
        m_Animator.SetFloat (k_HashWeight, weight);
    }
}
