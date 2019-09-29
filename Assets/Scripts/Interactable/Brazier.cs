using UnityEngine;

public class Brazier : Interactable
{
    [SerializeField] private Sprite brazierOn = null;
    [SerializeField] private Sprite brazierOff = null;
    private bool isOn;
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public override void Interact()
    {
        ToggleState();
    }

    private void ToggleState()
    {
        isOn = !isOn;
        sr.sprite = isOn ? brazierOn : brazierOff;
    }
}
