using TMPro;
using UnityEngine;

public class DamageObj : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI _playerHp;
    [SerializeField]
    private TextMeshProUGUI _gameOverText;
   
    GameObject _player;
    PlayerHp playerHp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _gameOverText.text = "";
       
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _player = GameObject.Find("Ball");
            playerHp = _player.GetComponent<PlayerHp>();

            var Hp = other.GetComponent<PlayerHp>();
           if(playerHp != null )
            {
                playerHp.Damage();
              
            }
        }
    }
}
