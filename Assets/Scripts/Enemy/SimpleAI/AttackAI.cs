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

    private void Start()
    {
        Transform g = FindObjectOfType<Player>().gameObject.transform;
        dest.target = g;
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
