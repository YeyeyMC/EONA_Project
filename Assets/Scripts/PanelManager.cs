using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private GameObject one;
    [SerializeField] private GameObject two;
    [SerializeField] private GameObject three;
    [SerializeField] private GameObject four;
    [SerializeField] private GameObject five;
    [SerializeField] private GameObject six;
    [SerializeField] private GameObject seven;
    [SerializeField] private GameObject eight;
    [SerializeField] private GameObject nine;
    [SerializeField] private GameObject ten;
    [SerializeField] private GameObject eleven;
    [SerializeField] private GameObject twelve;
    [SerializeField] private GameObject thirteen;
    [SerializeField] private GameObject fourteen;

    public void OnOneToTwo()
    {
        one.SetActive(false);
        two.SetActive(true);
    }
    public void OnOneToFive()
    {
        one.SetActive(false);
        five.SetActive(true);
    }
    public void OnTwoToThree()
    {
        two.SetActive(false);
        three.SetActive(true);
    }
    public void OnThreeToFour()
    {
        three.SetActive(false);
        four.SetActive(true);
    }
    public void OnFiveToSix()
    {
        five.SetActive(false);
        six.SetActive(true);
    }
    public void OnSixToSeven()
    {
        six.SetActive(false);
        seven.SetActive(true);
    }

    public void OnSevenToEight()
    {
        seven.SetActive(false);
        eight.SetActive(true);
    }

    public void OnEightToNine()
    {
        eight.SetActive(false);
        nine.SetActive(true);
    }

    public void OnTwoToOne()
    {
        two.SetActive(false);
        one.SetActive(true);
    }

    public void OnTwoToTwelve()
    {
        two.SetActive(false);
        twelve.SetActive(true);
    }

    public void OnTwelveToTen()
    {
        twelve.SetActive(false);
        ten.SetActive(true);
    }
    public void OnTwelveToFour()
    {
        twelve.SetActive(false);
        four.SetActive(true);
    }

    public void OnThreeToTen()
    {
        three.SetActive(false);
        ten.SetActive(true);
    }

    public void OnThreeToEleven()
    {
        three.SetActive(false);
        eleven.SetActive(true);
    }

    public void OnThreeToThirteen()
    {
        three.SetActive(false);
        thirteen.SetActive(true);
    }

    public void OnTwelveToFourteen()
    {
        twelve.SetActive(false);
        fourteen.SetActive(true);
    }
}
