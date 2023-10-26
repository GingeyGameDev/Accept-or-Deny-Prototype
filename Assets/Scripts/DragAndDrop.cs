using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    SpriteRenderer sprite;

   static int counter;

    int instanceNum;

    void Awake()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();


        instanceNum = counter++;
        sprite.sortingOrder = instanceNum;
    }

    private bool isDragging;

    private void OnMouseDown()
    {
        isDragging = true;

        GameObject[] documents = GameObject.FindGameObjectsWithTag("Documents");

        for (int i = 0; i < documents.Length; i++) 
        { 
            if (documents[i].GetComponent<SpriteRenderer>().sortingOrder >= sprite.sortingOrder)
            {
                sprite.sortingOrder++;
                documents[i].GetComponent<SpriteRenderer>().sortingOrder--;
            }
        }
    }


    private void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging) 
        {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);

        }



    }
}
