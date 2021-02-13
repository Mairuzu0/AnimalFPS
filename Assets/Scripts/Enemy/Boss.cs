using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] GameObject bossHealthUI;
    [SerializeField] GameObject portal;

    private EnemyHealth bossHealth;
    private Transform target;
    private MusicPlayer musicPlayer;
    //How far away from target
    private float distanceToTarget = Mathf.Infinity;

    private float chaseRange = 50f;
    private bool hasStarted = false;

    private void Start()
    {
        bossHealth = GetComponent<EnemyHealth>();
        target = FindObjectOfType<PlayerHealth>().transform;
        musicPlayer = FindObjectOfType<MusicPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget < chaseRange)
        {

            if (hasStarted == false)
            {
                hasStarted = true;
                bossHealthUI.SetActive(true);
                musicPlayer.ChangeMusic(MusicPlayer.musicStates.Tense);
            }
        }
        else { return; }
    }

    private void OnDisable()
    {
        if (bossHealthUI != null) { bossHealthUI.SetActive(false); }
        if (musicPlayer != null) { musicPlayer.ChangeMusic(MusicPlayer.musicStates.Normal); }
        if (portal != null) { portal.SetActive(true); }
    }

}
