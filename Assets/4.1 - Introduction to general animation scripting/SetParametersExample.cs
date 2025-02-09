using UnityEngine;

public class SetParametersExample : MonoBehaviour
{
    public Animator animator;

    static readonly int speedParameterHash = Animator.StringToHash("Speed");

    void Update()
    {
        animator.SetFloat(speedParameterHash, 5f);
    }
}
