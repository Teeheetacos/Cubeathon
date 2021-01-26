using UnityEngine;

public class Player_Collision : MonoBehaviour
{

    public Player_Movement movement;

    void OnCollisionEnter (Collision collision_Info)
    {
        if (collision_Info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }

}
