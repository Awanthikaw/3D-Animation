using UnityEngine;

public class FlowControlExample : MonoBehaviour
{
    public Animator animator;

    static readonly int shootStateHash = Animator.StringToHash("Shoot");
    static readonly int walkStateHash = Animator.StringToHash("Walk");

    void Start()
    {
        animator.Play("Run", 0, 0.1f);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            animator.PlayInFixedTime(shootStateHash, 1, 0f);
        
        if(Input.GetKeyDown(KeyCode.LeftShift))
            animator.CrossFade(walkStateHash, 1f, 0, 0.1f, 0f);
    }
}
