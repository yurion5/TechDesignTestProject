using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdClicker : MonoBehaviour
{

    public Animator bird_butt_animator;
    public GameObject player_object;
    Animator player_action;
    public int player_action_index;
    public AudioSource click_sound;


    void Start()
    {
        bird_butt_animator = GetComponent<Animator>();
        player_action = player_object.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        bird_butt_animator.Play("bird_cry");
        click_sound.Play();


        if (player_action_index == 1)
        {
            player_action.Play("player_jump");
        }
        else if (player_action_index == 2)
        {
            player_action.Play("player_run");
        }

    }

    private void OnMouseUp()
    {

        bird_butt_animator.Play("bird_stop");
        if (player_action_index == 2)
        {
            player_action.Play("player_idle");
        }

    }

    private void OnMouseOver()
    {
        if (player_action_index == 3)
        {
            bird_butt_animator.Play("bird_cry");
            player_action.Play("player_egg");
        }
    }
    private void OnMouseExit()
    {
            bird_butt_animator.Play("bird_stop");
    }
}
