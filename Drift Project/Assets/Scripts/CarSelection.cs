using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    //private int currentCar;
    public int index;

    private void Start()
    {
        SaveManager.instance.currentCar = index;
        //currentCar = SaveManager.instance.currentCar;
        //SelectCar(currentCar);
    }

    //private void SelectCar (int index)
    //{
    //    //previousButton.interactable = (index != 0);
    //    //nextButton.interactable = (index != transform.childCount-1);

    //    for (int i=0; i < transform.childCount; i++)
    //    {
    //        transform.GetChild(i).gameObject.SetActive(i == index);
    //    }
    //}

    //public void ChangeCar (int change)
    //{
    //    currentCar += change;

    //    if (currentCar > transform.childCount - 1)
    //        currentCar = 0;
    //    else if (currentCar < 0)
    //        currentCar = transform.childCount - 1;

    //    SaveManager.instance.currentCar = currentCar;
    //    SaveManager.instance.Save();

    //    SelectCar(currentCar);
    //}
}
