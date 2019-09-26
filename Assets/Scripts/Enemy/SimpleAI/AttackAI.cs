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
    public AIState state;

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
