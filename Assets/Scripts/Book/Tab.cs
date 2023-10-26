using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tab : MonoBehaviour
{

  

    public int tabNum;
    static BookPages bookPages;


    private void Start()
    {
       
        bookPages = GameObject.FindGameObjectWithTag("Book").GetComponent<BookPages>();
    }

    public void Clicked()
    {
        Debug.Log(tabNum);

        bookPages.openPage(tabNum);
    }
}
