using System;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    [SerializeField] private float m_speed = 4f;
    private Rigidbody2D m_rigidbody;
    private float m_movement = 0f;
	
    void Start() {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update () {
        m_movement = Input.GetAxisRaw("Horizontal") * m_speed;
    }

    void FixedUpdate() {
        if (Math.Abs(m_rigidbody.rotation + m_movement * Time.fixedDeltaTime) < 75f) {
            m_rigidbody.MoveRotation(m_rigidbody.rotation + m_movement * Time.fixedDeltaTime);
        }
    }
}
