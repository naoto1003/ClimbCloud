using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 5f; // ��Q���̃��C�t�^�C���i�b�j

    void Start()
    {
        // ���C�t�^�C�����߂������Q�����폜
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ��Q���������ɓ��������Ƃ��ɍ폜����i�Ⴆ�΁A�v���C���[�⑼�̏�Q���j
        Destroy(gameObject);
    }
}
