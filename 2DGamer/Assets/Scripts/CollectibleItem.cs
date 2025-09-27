using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public string itemName;   // "Cherry" o "Kiwi"
    public int itemValue = 1; // cada item vale 1

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Name item " + itemName + " el valor es " + itemValue);

            // Actualizar el score
            Score.Instance.AddItem(itemName, itemValue);

            Destroy(gameObject);
        }
    }
}
