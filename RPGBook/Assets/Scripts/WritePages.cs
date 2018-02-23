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


        //Page 0. First page. 
        listOfAllPages.Add(createPage("Welcome!"+ System.Environment.NewLine + @"I hope you have prepared for this journey you're about to take.
 These lands are wide, and the roads are long. Dangers are easy to find, and perhaps inevitable.
 What will it take for the adventurous mind to be satisfied? Which skill set will bring the wanderer through the journey?", "skull"));


        //Page 1. First choice to page 0.
        listOfAllPages.Add(createPage(@"This is the second page. You're on your way!", "bag2"));
        listOfAllPages[0].buttonChoices.Add(new AdventureButton(listOfAllPages[1], "This is your first choice!"));
        listOfAllPages[1].buttonChoices.Add(new AdventureButton(listOfAllPages[0], "Go back to the menu!"));


        //Page 2. Second choice to page 0.
        listOfAllPages.Add(createPage(@"This is the third page. You're on your way!", "helmet"));
        listOfAllPages[0].buttonChoices.Add(new AdventureButton(listOfAllPages[2], "This is your second choice!"));

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
