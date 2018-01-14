using UnityEngine;

public class BubbleShoot : MonoBehaviour {

    private Rigidbody2D m_rigidbody2D;
    private float m_speed = 50f;

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
