using BSComponent;
using UnityEngine;

public class BubblePreviewController : MonoBehaviour {

    [SerializeField] private FirePointController m_firePoint;

    public void SetNewColor()
    {
        GetComponent<SpriteRenderer>().material.color = ComponentColorGenerator.Instance.GetColor();
        m_firePoint.SetColor(GetComponent<SpriteRenderer>().material.color);
    }

	// Use this for initialization
	void Start () {
        SetNewColor();
    }
}
