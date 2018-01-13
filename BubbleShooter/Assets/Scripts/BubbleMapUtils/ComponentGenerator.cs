using System.Collections.Generic;
using UnityEngine;

namespace BSComponent
{
    public class ComponentGenerator {

        public GameObject Generate(float x, float y, GameObject refObject){
            GameObject gameObj = MonoBehaviour.Instantiate(refObject, new Vector2(x, y), Quaternion.identity);
            gameObj.GetComponent<SpriteRenderer>().material.color = ComponentColorGenerator.Instance.GetColor();
            return gameObj;
        }
    }
}
