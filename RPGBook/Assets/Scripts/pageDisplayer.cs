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
    [SerializeField]
    Image image;
    [HideInInspector]
    public List<Page> listOfAllPages = new List<Page>();
    WritePages writePages;
    [SerializeField]
    ScrollRect scrollRect;
    public Sprite OtherSprite;
    [SerializeField]
    [Range(0,0.1f)]
    float textAppearingDelay = 0.1f;

    void Start () {
        writePages = GetComponent<WritePages>();
        //Loads all the written pages. All pages are written in the createAllPages function
        listOfAllPages = writePages.createAllPages();

        //Loads the first written page
        LoadPage(listOfAllPages[0]);
	}

    IEnumerator textAppearing(string pageText, Text textBox)
    {
        foreach (char c in pageText)
        {
            textBox.text += c;
            yield return new WaitForSeconds(textAppearingDelay);
        }
    }

    void destroyButtons()
    {
        //Destroys all temporary files from a deleted page, such as optionally images, and buttons.
        var temps = GameObject.FindGameObjectsWithTag("temp");
        foreach (GameObject t in temps)
        {
            Destroy(t);
        }
        scrollRect.normalizedPosition = new Vector2(0, 1);
    }

    void LoadPage(Page page)
    {
        //pageText.text = page.pageText;
        Text txt = Instantiate(pageText) as Text;
        txt.text = page.pageText;
        txt.transform.SetParent(panel);
        txt.transform.localScale = new Vector3(1, 1, 1);

        //Uncomment this is you want text appearing in real time.
        //StartCoroutine(textAppearing(page.pageText,txt));

        if (page.imageText != null)
        {
            //Instantiate the given image underneath the text

            string nameSpace = "Images/" + page.imageText;
            Image newImage = Instantiate(image) as Image;
            newImage.transform.SetParent(panel);
            newImage.transform.localScale = new Vector3(1, 1, 1);
            newImage.sprite = Resources.Load<Sprite>(nameSpace);
        }
        foreach (AdventureButton ab in page.buttonChoices)
        {
            //Makes a button, like the prefab, for each choice on the page
            Button newButton = Instantiate(button) as Button;
            AdventureButton adventureButton = newButton.GetComponent<AdventureButton>();
            adventureButton.text.text = ab.buttonText;
            adventureButton.associatedPage = ab.associatedPage;
            newButton.transform.SetParent(panel);
            newButton.transform.localScale = new Vector3(1, 1, 1);
            newButton.onClick.AddListener(() => buttonClicked(adventureButton.associatedPage));
            
        }

        Canvas.ForceUpdateCanvases();

    }

    void buttonClicked(Page page)
    {
        destroyButtons();
        LoadPage(page);
    }
	

	
}
