using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefabSpecialItem;

    public GameObject paddle;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawItem", 3);
    }

    protected void spawItem()
    {
        GameObject specialItem = Instantiate(prefabSpecialItem);
        specialItem.transform.position = new Vector2(UnityEngine.Random.Range(-7, 7), UnityEngine.Random.Range(1, -3));
    }

    public void onSpecialItemCollision(GameObject other)
    {
        Vector2 size = paddle.GetComponent<SpriteRenderer>().size;
        size.x += 3;

        paddle.GetComponent<SpriteRenderer>().size = size;
        paddle.GetComponent<CapsuleCollider2D>().size = size;

        Destroy(other.gameObject);

        Invoke("spawItem", 5);
    }

}