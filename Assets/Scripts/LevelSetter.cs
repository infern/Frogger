using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSetter : MonoBehaviour
{
    public void LoadLevel(int a)
    {
        if (a == 1) Level1();
        else if (a == 2) Level2();
        else if (a == 3) Level3();
        else
        {
            GameController.Instance.levelNumber = 1;
            Level1();
        }

    }

    public void Level1()
    {
        //Road Zones

        GameController.Instance.zones[0].spawn.spawnOffset = 0;
        GameController.Instance.zones[0].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[0].spawn.objectSpeed = 3;
        GameController.Instance.zones[0].spawn.spawnCount = 4;

        GameController.Instance.zones[1].spawn.spawnOffset = 3;
        GameController.Instance.zones[1].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[1].spawn.objectSpeed = 3;
        GameController.Instance.zones[1].spawn.spawnCount = 4;

        GameController.Instance.zones[2].spawn.spawnOffset = 0;
        GameController.Instance.zones[2].spawn.objectOffset = 5.12f;
        GameController.Instance.zones[2].spawn.objectSpeed = 2;
        GameController.Instance.zones[2].spawn.spawnCount = 4;

        GameController.Instance.zones[3].spawn.spawnOffset = 4.37f;
        GameController.Instance.zones[3].spawn.objectOffset = 10.3f;
        GameController.Instance.zones[3].spawn.objectSpeed = 4;
        GameController.Instance.zones[3].spawn.spawnCount = 2;


        GameController.Instance.zones[4].spawn.spawnOffset = 0;
        GameController.Instance.zones[4].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[4].spawn.objectSpeed = 2;
        GameController.Instance.zones[4].spawn.spawnCount = 4;


        //River Zones

        GameController.Instance.zones[6].spawn.spawnOffset = 0;
        GameController.Instance.zones[6].spawn.objectOffset = 3.52f;
        GameController.Instance.zones[6].spawn.objectSpeed = 2;
        GameController.Instance.zones[6].spawn.spawnCount = 6;


        GameController.Instance.zones[7].spawn.spawnOffset = 0;
        GameController.Instance.zones[7].spawn.objectOffset = 3.06f;
        GameController.Instance.zones[7].spawn.objectSpeed = 1;
        GameController.Instance.zones[7].spawn.spawnCount = 8;

        GameController.Instance.zones[8].spawn.spawnOffset = 8.36f;
        GameController.Instance.zones[8].spawn.objectOffset = 6.82f;
        GameController.Instance.zones[8].spawn.objectSpeed = 2;
        GameController.Instance.zones[8].spawn.spawnCount = 3;

        GameController.Instance.zones[9].spawn.spawnOffset = 4.37f;
        GameController.Instance.zones[9].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[9].spawn.objectSpeed = 1;
        GameController.Instance.zones[9].spawn.spawnCount = 4;

        GameController.Instance.zones[10].spawn.spawnOffset = 0;
        GameController.Instance.zones[10].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[10].spawn.objectSpeed = 1.7f;
        GameController.Instance.zones[10].spawn.spawnCount = 3;
    }
    public void Level2()
    {
        //Road Zones

        GameController.Instance.zones[0].spawn.spawnOffset = 0;
        GameController.Instance.zones[0].spawn.objectOffset = 4.5f;
        GameController.Instance.zones[0].spawn.objectSpeed = 3.3f;
        GameController.Instance.zones[0].spawn.spawnCount = 5;

        GameController.Instance.zones[1].spawn.spawnOffset = 3;
        GameController.Instance.zones[1].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[1].spawn.objectSpeed = 3.3f;
        GameController.Instance.zones[1].spawn.spawnCount = 4;


        GameController.Instance.zones[2].spawn.spawnOffset = 0;
        GameController.Instance.zones[2].spawn.objectOffset = 4.12f;
        GameController.Instance.zones[2].spawn.objectSpeed = 3;
        GameController.Instance.zones[2].spawn.spawnCount = 6;

        GameController.Instance.zones[3].spawn.spawnOffset = 4.37f;
        GameController.Instance.zones[3].spawn.objectOffset = 8.3f;
        GameController.Instance.zones[3].spawn.objectSpeed = 4;
        GameController.Instance.zones[3].spawn.spawnCount = 3;

        GameController.Instance.zones[4].spawn.spawnOffset = 0;
        GameController.Instance.zones[4].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[4].spawn.objectSpeed = 3.5f;
        GameController.Instance.zones[4].spawn.spawnCount = 4;

        //River Zones

        GameController.Instance.zones[6].spawn.spawnOffset = 0;
        GameController.Instance.zones[6].spawn.objectOffset = 6.52f;
        GameController.Instance.zones[6].spawn.objectSpeed = 2.4f;
        GameController.Instance.zones[6].spawn.spawnCount = 4;

        GameController.Instance.zones[7].spawn.spawnOffset = 0;
        GameController.Instance.zones[7].spawn.objectOffset = 3.06f;
        GameController.Instance.zones[7].spawn.objectSpeed = 1.5f;
        GameController.Instance.zones[7].spawn.spawnCount = 8;

        GameController.Instance.zones[8].spawn.spawnOffset = 8.36f;
        GameController.Instance.zones[8].spawn.objectOffset = 6.82f;
        GameController.Instance.zones[8].spawn.objectSpeed = 2.5f;
        GameController.Instance.zones[8].spawn.spawnCount = 3;

        GameController.Instance.zones[9].spawn.spawnOffset = 4.37f;
        GameController.Instance.zones[9].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[9].spawn.objectSpeed = 1.2f;
        GameController.Instance.zones[9].spawn.spawnCount = 4;

        GameController.Instance.zones[10].spawn.spawnOffset = 0;
        GameController.Instance.zones[10].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[10].spawn.objectSpeed = 1.7f;
        GameController.Instance.zones[10].spawn.spawnCount = 3;
    }
    public void Level3()
    {
        //Road Zones

        GameController.Instance.zones[0].spawn.spawnOffset = 0;
        GameController.Instance.zones[0].spawn.objectOffset = 3.5f;
        GameController.Instance.zones[0].spawn.objectSpeed = 3.5f;
        GameController.Instance.zones[0].spawn.spawnCount = 7;

        GameController.Instance.zones[1].spawn.spawnOffset = 3;
        GameController.Instance.zones[1].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[1].spawn.objectSpeed = 3.7f;
        GameController.Instance.zones[1].spawn.spawnCount = 3;


        GameController.Instance.zones[2].spawn.spawnOffset = 0;
        GameController.Instance.zones[2].spawn.objectOffset = 4.12f;
        GameController.Instance.zones[2].spawn.objectSpeed = 3.5f;
        GameController.Instance.zones[2].spawn.spawnCount = 6;

        GameController.Instance.zones[3].spawn.spawnOffset = 4.37f;
        GameController.Instance.zones[3].spawn.objectOffset = 8.3f;
        GameController.Instance.zones[3].spawn.objectSpeed = 5.5f;
        GameController.Instance.zones[3].spawn.spawnCount = 3;

        GameController.Instance.zones[4].spawn.spawnOffset = 0;
        GameController.Instance.zones[4].spawn.objectOffset = 5.5f;
        GameController.Instance.zones[4].spawn.objectSpeed = 3.7f;
        GameController.Instance.zones[4].spawn.spawnCount = 5;

        //River Zones

        GameController.Instance.zones[6].spawn.spawnOffset = 0;
        GameController.Instance.zones[6].spawn.objectOffset = 6.52f;
        GameController.Instance.zones[6].spawn.objectSpeed = 2.6f;
        GameController.Instance.zones[6].spawn.spawnCount = 4;

        GameController.Instance.zones[7].spawn.spawnOffset = 0;
        GameController.Instance.zones[7].spawn.objectOffset = 2.56f;
        GameController.Instance.zones[7].spawn.objectSpeed = 1.7f;
        GameController.Instance.zones[7].spawn.spawnCount = 6;

        GameController.Instance.zones[8].spawn.spawnOffset = 8.36f;
        GameController.Instance.zones[8].spawn.objectOffset = 6.82f;
        GameController.Instance.zones[8].spawn.objectSpeed = 2.5f;
        GameController.Instance.zones[8].spawn.spawnCount = 3;

        GameController.Instance.zones[9].spawn.spawnOffset = 4.37f;
        GameController.Instance.zones[9].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[9].spawn.objectSpeed = 1.6f;
        GameController.Instance.zones[9].spawn.spawnCount = 4;

        GameController.Instance.zones[10].spawn.spawnOffset = 0;
        GameController.Instance.zones[10].spawn.objectOffset = 6.5f;
        GameController.Instance.zones[10].spawn.objectSpeed = 2f;
        GameController.Instance.zones[10].spawn.spawnCount = 2;
    }



}
