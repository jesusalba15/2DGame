using UnityEngine;

[SerializeField]
public class CollectorItem : MonoBehaviour
{
    public string itemName;
    public int itemValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colission)
    {
        if (colission.CompareTag("Player"))
        {
            Debug.Log("Item collected: " + itemName + " with value: " + itemValue);
           
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}

