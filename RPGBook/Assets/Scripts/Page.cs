using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour {

    [HideInInspector]
    public List<AdventureButton> buttonChoices = new List<AdventureButton>();
    [HideInInspector]
    public string pageText;
    [HideInInspector]
    public string imageText;

    public Page(List<AdventureButton> buttonChoices, string pageText, string imageText)
    {
        this.buttonChoices = buttonChoices;
        this.pageText = pageText;
        this.imageText = imageText;
    }


}
