using System;
using UnityEngine;

namespace Assets.Scripts.Drops
{
   public class Hearts : Dropable
   {
        private int MaxLifePoints { get; set; }
        public float LifePoints = 0.5f;
        private Player player;

        private void Awake()
        {
            player = FindObjectOfType<Player>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player != null)
            {
                player.AddNewLife(LifePoints);
                Debug.Log("Player has: " + player.Life.LifePoints);
                Destroy(root);
            }
        }

        public override void SetItem(Bag Owner)
        {
            
        }
    }
}
