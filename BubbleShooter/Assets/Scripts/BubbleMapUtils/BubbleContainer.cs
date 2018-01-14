using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace BSComponent {
    public class BubbleContainer {
        private List<GameObject> m_gameObjects = new List<GameObject>(510);
        private ComponentGenerator m_componentFactory = new ComponentGenerator();

        public BubbleContainer()
        {
            for (var i = 0; i < m_gameObjects.Capacity; ++i)
            {
                m_gameObjects.Add(null);
            }
        }

        ~BubbleContainer()
        {
            Debug.Log("BUBBLE CONTAINER DESTRUCTOR");
        }

        public void Dump()
        {
            Debug.Log("----------------------DUMPING CONTAINER");
            foreach (var it in m_gameObjects)
            {
                Debug.Log(it);
            }
        }

        public GameObject GetBubbleFromPosition(Vector2 pos)
        {
            return m_gameObjects.Find(bubble => bubble && Mathf.Approximately(bubble.transform.position.x, pos.x) && Mathf.Approximately(bubble.transform.position.y, pos.y));
        }

        public void Push(float x, float y, GameObject refGameObject) {
            m_gameObjects.Add(m_componentFactory.Generate(x, y, refGameObject));
        }
    }

}