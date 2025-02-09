using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    Vector3 m_Offset;
    
    void Start()
    {
        m_Offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        transform.position = target.position + m_Offset;
    }
}
