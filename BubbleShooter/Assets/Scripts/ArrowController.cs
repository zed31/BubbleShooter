using System;
using BSComponent;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    public static bool IsFireing = false;
    [SerializeField] private float m_speed = 4f;
    [SerializeField] private FirePointController m_controller;

    private float m_movement = 0f;
	
    void Start() {
        GetComponent<SpriteRenderer>().material.color = ComponentColorGenerator.Instance.GetColor();
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Shoot") && !IsFireing)
        {
            IsFireing = true;
            m_controller.Shoot();
        }
        m_movement = Input.GetAxisRaw("Horizontal") * m_speed;
    }

    void FixedUpdate() {
        transform.Rotate(new Vector3(0f, 0f, m_movement * Time.fixedDeltaTime));
    }
}
