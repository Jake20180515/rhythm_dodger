using UnityEngine;
using System.Collections;




public class MoveMap : MonoBehaviour
{
    public GameObject tile;
    private int tileNum = 5;

    struct TileStruct
    {
        public GameObject obj;
        public Transform tf;
        public bool active;
        public Vector2 pos;
    }
    private TileStruct[] tiles;

    private Vector3 tileCenterVec;
    private float tileGap = 18f;
    private float tileEndPoint = -50f;

    private Vector3 tempVec;

    private float speed = 18f;
    private int lastTileNum = 0;

    private void Awake()
    {
        tileCenterVec = new Vector3(-20, -1.6f, 0);
        CreateTiles();
    }

    private void FixedUpdate()
    {
        for(int i=0; i<tileNum; i++)
        {
            tiles[i].pos.x -= speed * Time.deltaTime;
            if(tiles[i].pos.x > tileEndPoint)
            {
                tiles[i].tf.position = tiles[i].pos;
            }
            else
            {
                tiles[i].pos = tiles[lastTileNum].pos;
                tiles[i].pos.x += tileGap;
                if(lastTileNum > i)
                {
                    tiles[i].pos.x -= speed * Time.deltaTime;
                }
                tiles[i].tf.position = tiles[i].pos;
                lastTileNum = i;
            }
        }
    }


    void CreateTiles()
    {
        tempVec = tileCenterVec;

        tiles = new TileStruct[tileNum];
        for(int i=0; i<tileNum; i++)
        {
            tiles[i].obj = Instantiate(tile, tempVec, Quaternion.identity) as GameObject;
            tiles[i].tf = tiles[i].obj.transform;
            tiles[i].pos = tiles[i].tf.position;
            tiles[i].active = true;

            tempVec.x += tileGap;
        }
        lastTileNum = 4;
    }

}