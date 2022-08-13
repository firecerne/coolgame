using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementHandlers
{
    public static List<Element> elements = new List<Element>();
    public static void AddToElements(Element element)
    {
        elements.Add(element);
        UIHandler.UpdateDropdowns();
    }

    public void RemoveElement(Element element)
    {
        elements.Remove(element);
        UIHandler.UpdateDropdowns();

    }

    public static Element SearchByName(string name)
    {
        for (int i = 0; i < elements.Count; i++)
        {
            if(elements[i].name == name)
            {
                return elements[i];
            }
        }

        return null;
    }

    public int NumberOfElements()
    { return elements.Count;}

    public static float NumberInBetween(double a, double b)
    { return (float)(a + (b - a) / 2); }

    public static Element CombineTwoElements(Element a, Element b, string name)
    {
        Element c = ScriptableObject.CreateInstance("Element") as Element;
        float water = NumberInBetween(a.waterPortion, b.waterPortion);
        float air = NumberInBetween(a.airPortion, b.airPortion);
        float earth = NumberInBetween(a.earthPortion, b.earthPortion);
        float fire = NumberInBetween(a.firePortion, b.firePortion);

        float r = NumberInBetween(a.color.r, b.color.r);
        float g = NumberInBetween(a.color.g, b.color.g);
        float bcolor = NumberInBetween(a.color.b, b.color.b);

        Color color = new Color(r, g ,bcolor);

        c.Init(water, earth, air, fire, color, name);
        return c; 
    }
}
