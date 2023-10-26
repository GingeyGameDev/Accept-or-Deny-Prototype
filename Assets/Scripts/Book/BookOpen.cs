using UnityEngine;


public class BookOpen : MonoBehaviour
{
    public static GameObject giveback;

    public GameObject outside;
    public GameObject book;
    public GameObject button;

    BookPages bookPages;

    private void Start()
    {
        bookPages = book.GetComponent<BookPages>();
    }

    public void OnButtonClicked() 
    {
        book.SetActive(true);
        button.SetActive(false);
        outside.SetActive(true);

        giveback = GameObject.FindGameObjectWithTag("GiveBack");
        giveback.SetActive(false);

        bookPages.openPage(-1);
    }

    

}
