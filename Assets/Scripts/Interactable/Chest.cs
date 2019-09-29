using UnityEngine;

public class Chest : Interactable
{
    [SerializeField] private float dropRadius = 1f;
    [SerializeField] private GameObject[] items = null;
    [SerializeField] private Sprite chestOn = null;
    private SpriteRenderer sr;
    private bool hasOpened;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    public override void Interact()
    {
        if (hasOpened)
            return;

        sr.sprite = chestOn;
        foreach (GameObject item in items)
        {
            Instantiate(item, Random.insideUnitCircle * dropRadius, Quaternion.identity);
        }
    }
}
