using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField]
    private UIScript UIScript;

    [SerializeField]
    private GameObject[] objects;
    void Start()
    {
        for(int i = 0; i < UIScript.amountOfObjects; i++)
        {
        Vector2 randomPositionCoin = new (Random.Range(-2,2.6f), Random.Range(-4.8f,4.8f));
        GameObject obj = Instantiate(objects[0]);
        obj.transform.position = randomPositionCoin;
        Vector2 randomPositionSpike = new (Random.Range(-2,2.6f), Random.Range(-4.8f,4.8f));
        GameObject objSpike = Instantiate(objects[1]);
        objSpike.transform.position = randomPositionSpike;
        }
    }
}
