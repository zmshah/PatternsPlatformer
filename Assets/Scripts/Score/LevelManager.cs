// Written by bhavani

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public Transform respawnpoint;
    public GameObject playerprefab;

    public CinemachineVirtualCameraBase cam;


    private void Awake()
    {
        instance = this;
    }

    // resets the player position to start 
    public void Respawn()
    {
        GameObject player = Instantiate(playerprefab, respawnpoint.position, Quaternion.identity);
        cam.Follow = player.transform;
        SceneManager.LoadScene(sceneName: "SampleScene", mode: LoadSceneMode.Single);
    }
}