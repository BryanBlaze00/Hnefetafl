using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    [Header("Core Objects")]
    [SerializeField] GameObject _kingPrefab;
    [SerializeField] GameObject _defenderPrefab;
    [SerializeField] GameObject _attackerPrefab;
    [SerializeField] GameObject _thronePrefab;
    [SerializeField] GameObject _exitPrefab;

    [Header("Parent Objects")]
    [SerializeField] GameObject _defParent;
    [SerializeField] GameObject _attParent;
    [SerializeField] GameObject _numParent;

    [Header("Numbers")]
    [SerializeField] GameObject _0;
    [SerializeField] GameObject _1;
    [SerializeField] GameObject _2;
    [SerializeField] GameObject _3;
    [SerializeField] GameObject _4;
    [SerializeField] GameObject _5;
    [SerializeField] GameObject _6;
    [SerializeField] GameObject _7;
    [SerializeField] GameObject _8;
    [SerializeField] GameObject _9;
    [SerializeField] GameObject _10;
    [SerializeField] GameObject _11;
    [SerializeField] GameObject _12;

    GridManager _gridManager;
    bool hasClickedPlay;

    /*void Awake()
    {

    }*/

    void Start()
    {
        _gridManager = FindAnyObjectByType<GridManager>();

        CreateKingAndThrone();
        CreateDefenders();
        CreateAttackers();
        CreateExits();
        SetupNumbers();

    }

    private void SetupNumbers()
    {
        InstantiateObjectWParent(_0, 0f, -1f, _numParent);
        InstantiateObjectWParent(_1, 1f, -1f, _numParent);
        InstantiateObjectWParent(_2, 2f, -1f, _numParent);
        InstantiateObjectWParent(_3, 3f, -1f, _numParent);
        InstantiateObjectWParent(_4, 4f, -1f, _numParent);
        InstantiateObjectWParent(_5, 5f, -1f, _numParent);
        InstantiateObjectWParent(_6, 6f, -1f, _numParent);
        InstantiateObjectWParent(_7, 7f, -1f, _numParent);
        InstantiateObjectWParent(_8, 8f, -1f, _numParent);
        InstantiateObjectWParent(_9, 9f, -1f, _numParent);
        InstantiateObjectWParent(_10, 10f, -1f, _numParent);
        InstantiateObjectWParent(_11, 11f, -1f, _numParent);
        InstantiateObjectWParent(_12, 12f, -1f, _numParent);

        InstantiateObjectWParent(_0, -1f, 0f, _numParent);
        InstantiateObjectWParent(_1, -1f, 1f, _numParent);
        InstantiateObjectWParent(_2, -1f, 2f, _numParent);
        InstantiateObjectWParent(_3, -1f, 3f, _numParent);
        InstantiateObjectWParent(_4, -1f, 4f, _numParent);
        InstantiateObjectWParent(_5, -1f, 5f, _numParent);
        InstantiateObjectWParent(_6, -1f, 6f, _numParent);
        InstantiateObjectWParent(_7, -1f, 7f, _numParent);
        InstantiateObjectWParent(_8, -1f, 8f, _numParent);
        InstantiateObjectWParent(_9, -1f, 9f, _numParent);
        InstantiateObjectWParent(_10, -1f, 10f, _numParent);
        InstantiateObjectWParent(_11, -1f, 11f, _numParent);
        InstantiateObjectWParent(_12, -1f, 12f, _numParent);
    }

    void CreateKingAndThrone()
    {
        GameObject spawnedKing = InstantiateObject(_kingPrefab, 6f, 6f);
        spawnedKing.name = "King";
        GameObject spawnedThrone = InstantiateObject(_thronePrefab, 6f, 6f);
        spawnedThrone.name = "Throne-Center_6-6";
    }

    void CreateDefenders()
    {
        InstantiateObjectWParent(_defenderPrefab, 4f, 6f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 5f, 7f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 5f, 6f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 5f, 5f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 6f, 8f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 6f, 7f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 6f, 5f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 6f, 4f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 7f, 7f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 7f, 6f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 7f, 5f, _defParent);
        InstantiateObjectWParent(_defenderPrefab, 8f, 6f, _defParent);
    }

    void CreateAttackers()
    {
        InstantiateObjectWParent(_attackerPrefab, 0f, 8f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 0f, 7f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 0f, 6f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 0f, 5f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 0f, 4f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 1f, 6f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 4f, 0f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 5f, 0f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 6f, 0f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 7f, 0f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 8f, 0f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 6f, 1f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 12f, 4f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 12f, 5f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 12f, 6f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 12f, 7f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 12f, 8f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 11f, 6f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 8f, 12f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 7f, 12f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 6f, 12f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 5f, 12f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 4f, 12f, _attParent);
        InstantiateObjectWParent(_attackerPrefab, 6f, 11f, _attParent);
    }

    void CreateExits()
    {
        GameObject spawnedExit;
        spawnedExit = InstantiateObject(_exitPrefab, 0f, 0f);
        spawnedExit.name = "Exit-BL_0-0";
        spawnedExit = InstantiateObject(_exitPrefab, 0f, 12f);
        spawnedExit.name = "Exit-TL_0-12";
        spawnedExit = InstantiateObject(_exitPrefab, 12f, 12f);
        spawnedExit.name = "Exit-TR_12-12";
        spawnedExit = InstantiateObject(_exitPrefab, 12f, 0f);
        spawnedExit.name = "Exit-BR_12-0";
    }

    /**
    * Method to instantiate an object to a given coordinate.
    **/
    GameObject InstantiateObject(GameObject prefabObject, float x, float y)
    {
        return Instantiate(prefabObject, new Vector3(x, y, 0f), Quaternion.identity);
    }

    /**
    * Method to instantiate an object to a given coordinate as a child with given parent object.
    **/
    GameObject InstantiateObjectWParent(GameObject prefabObject, float x, float y, GameObject parent)
    {
        return Instantiate(prefabObject, new Vector3(x, y, 0f), Quaternion.identity, parent.transform);
    }

}
