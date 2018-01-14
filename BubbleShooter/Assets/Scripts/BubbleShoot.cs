using UnityEngine;

public class BubbleShoot : MonoBehaviour {

    [SerializeField] private GameObject m_bubbleMap;
    private Rigidbody2D m_rigidbody2D;
    private float m_speed = 15f;

    void OnTriggerEnter2D(Collider2D colliderHitten)
    {
        if (colliderHitten.tag == "Bubble")
        {
            Debug.Log("Bubble HITTEN");
            BubbleMap BBMap = m_bubbleMap.GetComponent<BubbleMap>();
            Debug.Log("LOOKING FOR POSITION: " + new Vector2(colliderHitten.GetComponent<Transform>().position.x, colliderHitten.GetComponent<Transform>().position.y));
            GameObject bubbleHitten = BBMap.Find(new Vector2(colliderHitten.GetComponent<Transform>().position.x, colliderHitten.GetComponent<Transform>().position.y));
            if (bubbleHitten == null)
            {
                Debug.Log("BUBBLE NOT FOUND");
            } else
            {
                Debug.Log("Bubble found: " + bubbleHitten.tag);
            }
            ArrowController.IsFireing = false;
            //Destroy(gameObject);
        }

    }

    public void Normalize()
    {
        m_rigidbody2D.velocity = m_rigidbody2D.velocity.normalized * m_speed;
    }

    public void SetDirection(Vector2 direction)
    {
        m_rigidbody2D.velocity = direction;
        Normalize();
    }

    void Awake()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Normalize();
    }
}
