using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSceneTwo : MonoBehaviour
{
    public Animator player_animator;
    public GameObject player_position;
    bool way_check = true;



    void Start()
    {
        player_animator = GetComponent<Animator>();
        player_animator.Play("player_idle");
    }




    private void OnMouseDown()
    {
        player_animator.Play("player_run");
    }


    private void OnMouseDrag()
    {
        Vector2 change_player_position;
        change_player_position = player_position.transform.position;


        if (way_check)
        {
            player_position.transform.localRotation = Quaternion.Euler(0, 0, 0);

            change_player_position.x = change_player_position.x + 0.02f;
            if (change_player_position.x >= 1f)
            {
                way_check= false;
            }
        }
        else if(way_check==false)
        {
            player_position.transform.localRotation = Quaternion.Euler(0,180,0);

            change_player_position.x = change_player_position.x - 0.02f;
            if (change_player_position.x <= -5f)
            {
                way_check = true;
            }
        }


        player_position.transform.position = change_player_position;
    }


        private void OnMouseUp()
    {
        player_animator.Play("player_idle");
    }

}
