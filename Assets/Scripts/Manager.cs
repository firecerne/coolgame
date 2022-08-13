using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<Element> builtInElements;
    // Start is called before the first frame update

    void Start()
    {
        foreach (Element element in builtInElements)
        {
            ElementHandlers.AddToElements(element);
        }

        UIHandler.UpdateDropdowns();
    }
    public void CreateElement()
    {

        UIHandler.CreateElement();
        
    }


}
