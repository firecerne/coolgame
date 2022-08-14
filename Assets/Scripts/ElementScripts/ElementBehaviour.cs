using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementBehaviour : MonoBehaviour
{

    public Element element;
    public GameObject infoPanel;
    public Text proportions;
    public Text properties;
    public Text attributes;
    public Text name;

    void Awake()
    {
        OnCreation();
    }
    public void OnCreation()
    {
        gameObject.GetComponent<SpriteRenderer>().color = element.color;
        infoPanel = GameObject.Find("InfosPanel");
        proportions = GameObject.Find("Proportions").GetComponent<Text>();
        properties = GameObject.Find("Properties").GetComponent<Text>();
        attributes = GameObject.Find("Attributes").GetComponent<Text>();
        name = GameObject.Find("InfosPanel/Name").GetComponent<Text>();
        

    }

    void Start()
    { infoPanel.SetActive(false); }

    void OnMouseEnter()
    {
        OpenInformationPanel(); 
    }
    void OnMouseExit()
    {
        infoPanel.SetActive(false);
    }

    void OpenInformationPanel()
    {
        List<string> infos = UIHandler.GetInfos(element);
        infoPanel.SetActive(true);

        proportions.text = infos[0];
        attributes.text = infos[1];
        properties.text = infos[2];
        name.text = element.name;   

        infoPanel.GetComponent<Transform>().position = new Vector3(Input.mousePosition.x, Input.mousePosition.y - 100, 0) ;
        
    }



}
