using UnityEngine;

public class MultipleMovingPlatforms : MonoBehaviour
{
    public GameObject[] platforms; // �����̑���I�u�W�F�N�g
    public float speed = 2f; // ����̈ړ����x
    public float moveRange = 5f; // ���ꂪ�ړ�����͈�

    void Start()
    {
        foreach (GameObject platform in platforms)
        {
            // �e����I�u�W�F�N�g�� MovingPlatform �R���|�[�l���g��ǉ�
            MovingPlatform movingPlatform = platform.AddComponent<MovingPlatform>();
            movingPlatform.speed = speed;
            movingPlatform.moveRange = moveRange;
        }
    }
}

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    public float moveRange = 5f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosX = Mathf.PingPong(Time.time * speed, moveRange) - (moveRange / 2);
        transform.position = startPosition + new Vector3(newPosX, 0, 0);
    }
}
