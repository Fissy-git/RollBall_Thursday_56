using TMPro;
using UnityEngine;

public class GoalArea : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI displayText;
   // public GameObject GoalText;

    private AudioSource audioSource;
    public AudioClip[] seAudioClips;

    private void Start()
    {
        displayText.text = "";
       // GoalText.SetActive(false);
    }
    private void SEPlay(int i)
    {
        if (audioSource == null)
        { 
            audioSource = this.gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = seAudioClips[i];
        audioSource.Play();
        Debug.Log("Se");
    }

 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Goal!");
            displayText.text = "GOAL!";
            SEPlay(0);
           // GoalText.SetActive(true);
        }
    }

}
