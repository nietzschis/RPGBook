using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureButton : MonoBehaviour {

    
    public Page associatedPage;
    public Text text;
    public Button button;
    [HideInInspector]
    public string buttonText;

    public AdventureButton(Page associatedPage, string buttonText)
    {
        this.associatedPage = associatedPage;
        this.buttonText = buttonText;
    } 
}
