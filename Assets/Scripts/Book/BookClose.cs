using UnityEngine;

public class BookClose : MonoBehaviour
{
    

    public GameObject outside;
    public GameObject book;
    public GameObject button;
    public GameObject giveback;

    public void OnMouseDown()
    { 

        book.SetActive(false);
        button.SetActive(true);
        outside.SetActive(false);

        
        giveback.SetActive(true);

    }
}
