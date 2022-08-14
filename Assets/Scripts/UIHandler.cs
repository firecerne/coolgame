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

        input = GameObject.Find("Panel/Name").GetComponent<InputField>();

        Element c = ElementHandlers.CombineTwoElements(a, b, input.text);

        ElementHandlers.AddToElements(c);

    } 

    public static List<string> GetInfos(Element element)
    {
        List<string> informations = new List<string>();

        string proportions = "Water : " + element.waterPortion + "%\n Earth : " + element.earthPortion + "% \n Fire : " + element.firePortion + "%\n Air : " + element.airPortion + "%";
        informations.Add(proportions);

        string properties = "Protection : " + element.protection + "\n Magicness : " + element.magic + " \n Solidity : " + element.solidity + "\n Sharpness : " + element.sharpness;
        informations.Add(properties);

        string attributes = "";
        if (element.hasLife) { attributes += "Alive, "; }
        if (element.isFireable) { attributes += "Burnable, "; }
        if (element.isLiquid) { attributes += "Liquid, "; }
        if (element.isSolid) { attributes += "Solid, "; }
        if (element.isGas) { attributes += "Gas, "; }
        informations.Add(attributes);

        return informations;
    }
}
