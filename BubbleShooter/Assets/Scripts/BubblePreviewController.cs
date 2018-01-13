using BSComponent;
using UnityEngine;

public class BubblePreviewController : MonoBehaviour {

    public static bool IsFireing = false;

    [SerializeField] private Vector2 m_force;
    [SerializeField] private GameObject m_arrow;

    private SpriteRenderer m_spriteRenderer;
    private Rigidbody2D m_rigidBody2D;

	// Use this for initialization
	void Start () {
        IsFireing = false;
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_rigidBody2D = GetComponent<Rigidbody2D>();
        m_rigidBody2D.Sleep();
        m_spriteRenderer.material.color = ComponentColorGenerator.Instance.GetColor();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Shoot"))
        {
            IsFireing = true;
        }
        if (IsFireing)
        {
            var ZDegValue = m_arrow.GetComponent<ArrowController>().GetAngle;
            Vector2 finalForce = new Vector2(m_force.x + Mathf.Cos(ZDegValue * (Mathf.PI / 180)), m_force.y + Mathf.Sin(ZDegValue * (Mathf.PI / 180)));
            m_rigidBody2D.AddForce(m_force);
            Debug.Log("Angle: " + ZDegValue + " position on y: " + transform.position.y);
        }
        else
        {
            transform.position = new Vector3(0, -4.6f, 0);
        }
	}
}
