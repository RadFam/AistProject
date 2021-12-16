using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="WorldMaps", menuName="ScriptableObjects/WorldMap", order=1)]
public class WorldMaps : ScriptableObject 
{
	public List<WorldMapInfo> mapData;
}

[System.Serializable]
public class WorldMapInfo
{
	public string mainName;
	public string subName;
	public Sprite bigMap;
	public Sprite subBtnMap;
}
