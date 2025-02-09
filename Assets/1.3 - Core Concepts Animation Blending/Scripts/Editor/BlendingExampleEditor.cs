using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BlendingExample))]
public class BlendingExampleEditor : Editor
{
    SerializedProperty m_WeightProp;
    float m_SquareWeight;
    
    static readonly GUIContent k_CircleWeightLabel = new GUIContent("Circle Weight");
    static readonly GUIContent k_SquareWeightLabel = new GUIContent("Square Weight");

    void OnEnable ()
    {
        m_WeightProp = serializedObject.FindProperty ("weight");
        m_SquareWeight = 1f - m_WeightProp.floatValue;
    }

    public override void OnInspectorGUI ()
    {
        serializedObject.Update ();
        
        EditorGUI.BeginChangeCheck ();
        EditorGUILayout.PropertyField (m_WeightProp, k_CircleWeightLabel);
        if (EditorGUI.EndChangeCheck ())
            m_SquareWeight = 1f - m_WeightProp.floatValue;
        
        EditorGUI.BeginChangeCheck ();
        EditorGUILayout.Slider (k_SquareWeightLabel, m_SquareWeight, 0f, 1f);
        if (EditorGUI.EndChangeCheck ())
            m_WeightProp.floatValue = 1f - m_SquareWeight;

        serializedObject.ApplyModifiedProperties ();
    }
}
