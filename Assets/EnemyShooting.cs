using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject projectilePrefab; // î≠éÀÇ∑ÇÈè·äQï®ÇÃÉvÉåÉnÉu
    public float shootInterval = 2f; // î≠éÀä‘äuÅiïbÅj
    public float projectileSpeed = 5f; // è·äQï®ÇÃà⁄ìÆë¨ìx
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (projectilePrefab == null)
        {
            Debug.LogError("Projectile prefab is not assigned!");
            return;
        }

        if (player == null)
        {
            Debug.LogError("Player not found!");
            return;
        }

        InvokeRepeating("ShootAtPlayer", 0f, shootInterval);
    }

    void ShootAtPlayer()
    {
        if (player == null) return;

        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        if (projectile == null)
        {
            Debug.LogError("Failed to instantiate projectile!");
            return;
        }

        Vector2 direction = (player.position - transform.position).normalized;
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.velocity = direction * projectileSpeed;
        }
        else
        {
            Debug.LogError("Projectile does not have a Rigidbody2D component!");
        }
    }
}
