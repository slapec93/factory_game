using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerController : MonoBehaviour
{

    Animator animator;
    bool isRolling = false;
    float rollingSpeed = 1;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = rollingSpeed;
        ToggleRolling();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleRolling()
    {
        isRolling = !isRolling;
        animator.SetBool("IsRolling", isRolling);
    }

    public void SetSpeed(float newSpeed)
    {
        rollingSpeed = newSpeed;
    }
}
