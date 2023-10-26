using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPages : MonoBehaviour
{
    public GameObject[] openTabs;
    public GameObject[] closedTabs;

    private void Start()
    {

    }

    public void openPage(int openTab) 
    {
        for (int i = 0; i < openTabs.Length; i++) 
        {

            closedTabs[i].SetActive(true);
            if (openTab == -1) 
            {
                closedTabs[i].SetActive(true);
                openTabs[i].SetActive(false);
            }

            else if (i <= openTab)
            {
                openTabs[i].SetActive(true);
                closedTabs[i].SetActive(false);
            }
            else
            {
                closedTabs[i].SetActive(true);
                openTabs[i].SetActive(false);
            }
        }
    }
}
