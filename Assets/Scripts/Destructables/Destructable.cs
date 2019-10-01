using UnityEngine;

public class Destructable : MonoBehaviour
{
    public Dropper dropper;

    public float DropRate = 0.1f;

    public int coins;
    public float LP;
    private bool dropped = false;

    private void Start()
    {
        if(dropper != null)
        {
            dropper.MyOwner = new Bag
            {
                gold = new CoinBag(coins),
                heart = new Heart(LP)
            };
        }
        
    }

    public void OnDestructed()
    {
        if(dropper != null)
        {
            if(Random.Range(0f, 1f) < DropRate)
            {
                int item = Random.Range(0, dropper.drops.Count );
                if(!dropped) dropper.Drop(item);
                dropped = true;
            }
        }

        Destroy(gameObject, 0.3f);
    }
}