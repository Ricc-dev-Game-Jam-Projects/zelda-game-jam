using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AIState
{
    Around,
    Back,
    Following
}

public class AttackAI : MonoBehaviour
{
    public PlayerFind playerFinder;
    public AIPath path;
    public AIDestinationSetter dest;
    public AIState state;
    private Animator anim;

    private void Start()
    {
        Transform g = FindObjectOfType<Player>().gameObject.transform;
        dest.target = g;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerFinder.PlayerInside)
        {
            state = AIState.Following;
        } else
        {
            state = AIState.Around;
        }
        Vector3 dest = path.steeringTarget;
        dest.Normalize();
        //Debug.Log("x: " + dest.x + " y: " + dest.y + " magnitude: " + dest.magnitude);
        anim.SetFloat("Horizontal", dest.x);
        anim.SetFloat("Vertical", dest.y);
        anim.SetFloat("Magnitude", dest.magnitude);

        switch (state)
        {
            case AIState.Following:
                path.canSearch = true;
                break;
            case AIState.Around:
                path.canSearch = false;
                break;
        }
    }
}
