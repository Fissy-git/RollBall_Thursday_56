using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI gOText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gOText.text = "";
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("GameOver");
            gOText.text = "GameOver";
            Destroy(other.gameObject);
        }
    }
}
