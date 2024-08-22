using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 5f; // 障害物のライフタイム（秒）

    void Start()
    {
        // ライフタイムが過ぎたら障害物を削除
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 障害物が何かに当たったときに削除する（例えば、プレイヤーや他の障害物）
        Destroy(gameObject);
    }
}
