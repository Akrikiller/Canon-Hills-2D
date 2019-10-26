using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartBuilding : MonoBehaviour
{

	private string id;
	private string name;
	private int currentLvl;
	private int maxLvl;
	public enum BuildingType{TOWER, WALL, ECO};
	private BuildingType buildingType;
	public int currentHp = 1000;
	public int maxHp = 1000;

	public StandartBuilding(string id, string name, int currentLvl, int maxLvl, BuildingType buildingType){
		this.id = id;
		this.name = name;
		this.currentLvl = currentLvl;
		this.maxLvl = maxLvl;
		this.buildingType = buildingType;

	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
