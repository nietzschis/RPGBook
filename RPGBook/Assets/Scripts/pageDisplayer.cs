using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pageDisplayer : MonoBehaviour {

    [SerializeField]
    Text pageText;
    [SerializeField]
    RectTransform panel;
    [SerializeField]
    Button button;
    [HideInInspector]
    public List<Page> listOfAllPages = new List<Page>();
    WritePages writePages;

    void Start () {
        writePages = GetComponent<WritePages>();
        //Loads all the written pages. All pages are written in the createAllPages function
        listOfAllPages = writePages.createAllPages();

        //Loads the first written page
        LoadPage(listOfAllPages[0]);
	}

    void destroyButtons()
    {
        Button[] buttons = panel.GetComponentsInChildren<Button>(true);
        foreach (Button b in buttons)
        {
            Destroy(b.gameObject);
        }
    }

    void LoadPage(Page page)
    {
        pageText.text = page.pageText;
        if (page.imageText != null)
        {
            //Instantiate the given image underneath the text

        }
        foreach (AdventureButton ab in page.buttonChoices)
        {
            Button newButton = Instantiate(button) as Button;

            AdventureButton adventureButton = newButton.GetComponent<AdventureButton>();
            adventureButton.text.text = ab.buttonText;
            adventureButton.associatedPage = ab.associatedPage;
            newButton.transform.SetParent(panel);
            newButton.transform.localScale = new Vector3(1, 1, 1);
            newButton.onClick.AddListener(() => buttonClicked(adventureButton.associatedPage));
        }

    }

    void buttonClicked(Page page)
    {
        destroyButtons();
        LoadPage(page);
    }
	

	
}
