using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject[] ballPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject ballPrefab = Instantiate(ballPrefabs[0]);
        ballPrefab.transform.position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
