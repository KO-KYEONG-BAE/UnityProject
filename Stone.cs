using UnityEngine;

public class Stone : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 2;
    }
    private bool isActivated = false;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Road") && !isActivated)
        {
            // Road랑 닿은 경우: 이제 trigger 모드로 전환
            GetComponent<Rigidbody2D>().gravityScale = 0;
            GetComponent<Collider2D>().isTrigger = true;
            isActivated = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActivated && collision.CompareTag("Player"))
        {
            // Player 충돌 시: Life 깎고, Stone 파괴
            Player player = collision.GetComponent<Player>();
            if (player != null)
            {
                player.Hit();
            }
            Destroy(gameObject);
        }
    }
}