using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float offset = 0.5f;
    [SerializeField] private Vector2 halfExt = new Vector2();
    [SerializeField] private LayerMask interactionMask = 0;
    private Vector2 currOffset;
    private Vector2 currHalfExt;
    private Move move;

    private void Start()
    {
        move = GetComponent<Move>();
        currOffset.x = offset;
        currHalfExt = halfExt;
    }

    private void Update()
    {
        InteractDirection();
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D interacted = Physics2D.OverlapBox((Vector2)transform.position + currOffset, halfExt, 0f, interactionMask);
            if (interacted)
            {
                Interactable tempInteract = interacted.GetComponent<Interactable>();
                if (tempInteract)
                    tempInteract.Interact();
            }
        }
    }

    private void InteractDirection()
    {
        switch(move.dir)
        {
            case Direction.up:
                currOffset.x = 0f;
                currOffset.y = offset;
                currHalfExt.Set(halfExt.x, halfExt.y);
                break;
            case Direction.down:
                currOffset.x = 0f;
                currOffset.y = -offset;
                currHalfExt.Set(halfExt.x, halfExt.y);
                break;
            case Direction.left:
                currOffset.x = -offset;
                currOffset.y = 0f;
                currHalfExt.Set(halfExt.y, halfExt.x);
                break;
            case Direction.right:
                currOffset.x = offset;
                currOffset.y = 0f;
                currHalfExt.Set(halfExt.y, halfExt.x);
                break;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position + (Vector3)currOffset, currHalfExt * 2f);
    }
}
