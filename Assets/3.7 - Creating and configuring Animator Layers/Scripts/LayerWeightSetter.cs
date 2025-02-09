using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerWeightSetter : MonoBehaviour
{
    public int layerIndex = 1;
    [Range(0f, 1f)]
    public float weight;
    
    Animator m_Animator;

    void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        m_Animator.SetLayerWeight(layerIndex, weight);
    }
}
