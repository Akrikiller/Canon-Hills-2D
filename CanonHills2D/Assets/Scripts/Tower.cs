using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tower : StandartBuilding 
{
	private enum Projectile{STANDART_PROJECTILE};
	private Projectile projectile = Projectile.STANDART_PROJECTILE;

	public Tower(string id, string name, int currentLvl, int maxLvl): base(id, name,currentLvl, maxLvl,BuildingType.TOWER) {

}

    // Start is called before the first frame update
    void Start()
    {
    	currentHp =1000;
    maxHp = 1000;

        Debug.Log(currentHp+"  "+ buildingType);
    }

    // Update is called once per frame
    void Update()
    {
        currentHp--;
        Slider healthSlider = GameObject.Find("healthSlider").GetComponent<Slider>(); 
    	healthSlider.value = maxHp-currentHp;

    }
}
