using System.Collections;
using UnityEngine;
using Pathfinding;

public class KnockbackController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private float duration = 0.2f;
    private Enemy enemy;
    private Rigidbody2D rb;
    private AIPath path;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
        enemy.OnTakeDamageEvent += ApplyKnockback;
        rb = enemy.MyRoot.GetComponent<Rigidbody2D>();
        path = enemy.MyRoot.GetComponent<AIPath>();
    }

    private void ApplyKnockback()
    {
        Debug.Log($"Applied knockback {enemy.MyRoot.transform.up * -force}");
        path.canMove = false;
        rb.AddForce(enemy.MyRoot.transform.up * -force, ForceMode2D.Impulse);
        StartCoroutine(RemoveKnockback());
    }

    private IEnumerator RemoveKnockback()
    {
        yield return new WaitForSeconds(duration);
        rb.velocity = Vector2.zero;
        path.canMove = true;
    }
}
