using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultTargetMatching : MonoBehaviour
{
    public Animator animator;
    public Transform wallHandPosition;
    public float takeOffTime = 0.027f;
    public float handDownTime = 0.371f;

    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Vault"))
        {
            MatchTargetWeightMask mask = new MatchTargetWeightMask(Vector3.one, 0f);
            animator.MatchTarget(wallHandPosition.position, wallHandPosition.rotation, AvatarTarget.LeftHand, mask, takeOffTime, handDownTime);
        }
    }
}
