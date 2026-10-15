using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerHp : MonoBehaviour
{

    private int playerHp;
    private int maxPlayerHp = 3;

    private void Start()
    {
        playerHp = maxPlayerHp;

    }
   
    public void Damage()
    {
        playerHp -= 1;
        Debug.Log(playerHp);

        if (playerHp == 0 )
        {
            Destroy(this.gameObject);
        }
    }
}
