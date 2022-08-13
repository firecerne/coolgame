using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler
{
    static List<Element> elements = new List<Element>();
    static List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
    static Dropdown dropdownA;
    static Dropdown dropdownB;
    static InputField input;

    public static void UpdateDropdowns()
    {
        dropdownA = GameObject.Find("Element A").GetComponent<Dropdown>();
        dropdownB = GameObject.Find("Element B").GetComponent<Dropdown>();
        dropdownA.ClearOptions();
        dropdownB.ClearOptions();
        elements = ElementHandlers.elements;
        options = new List<Dropdown.OptionData>();
        foreach (Element element in elements)
        {
            Dropdown.OptionData optionData = new Dropdown.OptionData();
            optionData.text = element.name;
            options.Add(optionData);
        }

        dropdownA.AddOptions(options);
        dropdownB.AddOptions(options);
    }

    public static void CreateElement()
    {

        string nameA = options[dropdownA.value].text;
        string nameB = options[dropdownB.value].text;

        Element a = ElementHandlers.SearchByName(nameA);
        Element b = ElementHandlers.SearchByName(nameB);

        input = GameObject.Find("Name").GetComponent<InputField>();

        Element c = ElementHandlers.CombineTwoElements(a, b, input.text);

        ElementHandlers.AddToElements(c);

    } 
}
