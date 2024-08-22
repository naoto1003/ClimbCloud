using UnityEngine;

public class MultipleMovingPlatforms : MonoBehaviour
{
    public GameObject[] platforms; // 複数の足場オブジェクト
    public float speed = 2f; // 足場の移動速度
    public float moveRange = 5f; // 足場が移動する範囲

    void Start()
    {
        foreach (GameObject platform in platforms)
        {
            // 各足場オブジェクトに MovingPlatform コンポーネントを追加
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
