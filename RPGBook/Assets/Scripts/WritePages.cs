using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WritePages : MonoBehaviour {

    pageDisplayer pDisplayer;

    private void Start()
    {
        pDisplayer = GetComponent<pageDisplayer>();    
    }
    public List<Page> createAllPages()
    {
        List<Page> listOfAllPages = new List<Page>();
        //All the pages in the game is written in this function

        //Page 0 
        listOfAllPages.Add(createPage("a\nb\nc\nd\ne\nf\ng\nh\ni\nj\nk\nl\nm\nn\no\np\nq\nr\ns\n\n\nt\nu", null));

        //Page 1
        listOfAllPages.Add(createPage("This is the second page.\nYou're on your way!", null));
        listOfAllPages[0].buttonChoices.Add(new AdventureButton(listOfAllPages[1], "Go to the next page!"));

        return listOfAllPages;

    }

    Page createPage(string pageText, string imageText)
    {
        //Adds an empty list of choice buttons for the new page
        List<AdventureButton> firstChoices = new List<AdventureButton>();

        //Adds an image to the new page, if an image was given as an argument
        Page page = (imageText == null) ? new Page(firstChoices, pageText, null) : new Page(firstChoices, pageText, imageText);

        return page;
    }
}
