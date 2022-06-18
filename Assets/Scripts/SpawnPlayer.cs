using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform SpawnGameObjects;

    private GameObject _spawnCharacter;
    private Vector3 _randomLocation;

    private PhotonView view;
    

    private void Start()
    {
        Vector3 _randomLocation = new Vector3(Random.Range(-300f, 300f) *0.01f, Random.Range(-100f,200f) * 0.01f ,5f);
        _spawnCharacter = PhotonNetwork.Instantiate(player.name, _randomLocation, Quaternion.identity);
        _spawnCharacter.transform.SetParent(SpawnGameObjects);
        view = GetComponent<PhotonView>();
    }

    public void SpawnRandomLocation()
    {
        _randomLocation = new Vector3(Random.Range(-300f, 300f) * 0.01f, Random.Range(-100f, 200f) * 0.01f, 5f);
        _spawnCharacter.transform.position = _randomLocation;     
    }
}