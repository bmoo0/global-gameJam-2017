
using UnityEngine;

public class rest : MonoBehaviour
{
    public GameObject restObj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Destroy(restObj);
    }
}