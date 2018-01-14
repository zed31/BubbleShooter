using UnityEngine;

public class FirePointController : MonoBehaviour {

    [SerializeField] private GameObject m_bulletRef;
    private Color32 m_color;

    public void SetColor(Color32 color)
    {
        m_color = color;
    }

    public void Shoot()
    {
        GameObject Bubble = Instantiate(m_bulletRef, transform.position, transform.rotation);
        Bubble.GetComponent<SpriteRenderer>().material.color = m_color;
        Bubble.GetComponent<BubbleShoot>().SetDirection(new Vector2(transform.position.x, 1f).normalized);
    }
}
