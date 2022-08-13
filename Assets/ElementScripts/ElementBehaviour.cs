using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementBehaviour : MonoBehaviour
{

    public Element element;

    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = element.color;
    }

}
