using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public Transform DropPosition;

    public abstract void Interact();
}
