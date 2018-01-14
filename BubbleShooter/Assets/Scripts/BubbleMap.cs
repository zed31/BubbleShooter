using System.Linq;
using BSComponent;
using UnityEngine;

public class BubbleMap : MonoBehaviour {

    [SerializeField] private GameObject m_gameObjectRef;

    private BubbleContainer m_bubbles = new BubbleContainer();

    private float m_startX = -2.95f;
    private float m_startY = 4.61f;
    private float m_scale = 0.40f;

    ~BubbleMap()
    {
        Debug.Log("Bubble map destructor");
    }

    void InsertRowOnTop()
    {
        foreach (var j in Enumerable.Range(0, 16))
        {
            m_bubbles.Push(m_startX, m_startY, m_gameObjectRef);
            m_startX += m_scale;
        }
    }

    public GameObject Find(Vector2 position)
    {
        return m_bubbles.GetBubbleFromPosition(position);
    }

	// Use this for initialization
	void Awake() {
        foreach (var i in Enumerable.Range(0, 14)) {
            InsertRowOnTop();
            m_startX = -2.95f;
            m_startY -= m_scale;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
