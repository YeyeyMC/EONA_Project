using UnityEngine;
using UnityEngine.UI;

public class ReturnManager : MonoBehaviour
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

    public void OnTwoToOne()
    {
        two.SetActive(false);
        one.SetActive(true);
    }

    public void OnFiveToOne()
    {
        five.SetActive(false);
        one.SetActive(true);
    }

    public void OnThreeToTwo()
    {
        three.SetActive(false);
        two.SetActive(true);
    }

    public void OnFourToThree()
    {
        four.SetActive(false);
        three.SetActive(true);
    }

    public void OnSixToFive()
    {
        six.SetActive(false);
        five.SetActive(true);
    }

    public void OnSevenToSix()
    {
        seven.SetActive(false);
        six.SetActive(true);
    }

    public void OnEightToSeven()
    {
        eight.SetActive(false);
        seven.SetActive(true);
    }

    public void OnNineToEight()
    {
        nine.SetActive(false);
        eight.SetActive(true);
    }

    public void OnTwelveToTwo()
    {
        twelve.SetActive(false);
        two.SetActive(true);
    }

    public void OnTenToTwelve()
    {
        ten.SetActive(false);
        twelve.SetActive(true);
    }

    public void OnFourToTwelve()
    {
        four.SetActive(false);
        twelve.SetActive(true);
    }

    public void OnTenToThree()
    {
        ten.SetActive(false);
        three.SetActive(true);
    }

    public void OnElevenToThree()
    {
        eleven.SetActive(false);
        three.SetActive(true);
    }

    public void OnThirteenToThree()
    {
        thirteen.SetActive(false);
        three.SetActive(true);
    }

    public void OnFourteenToTwelve()
    {
        fourteen.SetActive(false);
        twelve.SetActive(true);
    }
}
