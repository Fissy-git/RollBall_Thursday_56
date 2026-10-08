using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerHp : MonoBehaviour
{

    private int playerHp;
    private int maxPlayerHp = 3;
    [SerializeField]
    private TextMeshProUGUI displayPlayerHp;
    [SerializeField]
    private TextMeshProUGUI gOText;

    private void Start()
    {
        playerHp = maxPlayerHp;
        displayPlayerHp.text = $"HP:{playerHp}";

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("damage");
            playerHp -= 1;
            displayPlayerHp.text = $"HP:{playerHp}";
            if(playerHp == 0)
            {
                Destroy(other.gameObject);
                gOText.text = "GameOver";
            }

        }
    }
}
