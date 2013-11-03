using UnityEngine;
using System.Collections;

[System.Serializable]
public class Dungeon_Room {

	public AABB boundary;
	public QuadTree quadtree;
	
	public Dungeon_Room (AABB b)
	{
		boundary = b;
	}

    public Dungeon_Room(AABB b, QuadTree q)
	{
		boundary = b;
		quadtree = q;
		quadtree.room = this;
	}
	
}
