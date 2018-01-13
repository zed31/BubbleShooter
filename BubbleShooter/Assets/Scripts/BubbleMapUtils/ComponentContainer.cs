using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace BubbleShooter {
    public class ComponentContainer {
        private List<GameObject> m_gameObjects = new List<GameObject>();
        private ComponentGenerator m_componentFactory = new ComponentGenerator();

        public void Push(float x, float y, GameObject refGameObject) {
            GameObject gameObj = m_componentFactory.Generate(x, y, refGameObject);
            m_gameObjects.Add(gameObj);
        }
    }

}