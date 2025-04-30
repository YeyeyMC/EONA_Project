using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private GameObject panel1;
    [SerializeField] private GameObject panel2;
    [SerializeField] private GameObject panel3;
    [SerializeField] private GameObject panel4;
    [SerializeField] private GameObject panelAct;
    [SerializeField] private GameObject panelRegMom;
    [SerializeField] private GameObject panelClaRec;

    public void OnEstructuraPressed()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    public void OnModoDeUsoPressed()
    {
        panel1.SetActive(false);
        panelAct.SetActive(true);
    }
    public void OnChipPressed()
    {
        panel2.SetActive(false);
        panel3.SetActive(true);
    }
    public void OnRegHormonasPressed()
    {
        panel3.SetActive(false);
        panel4.SetActive(true);
    }
    public void OnRegMomentoPressed()
    {
        panelAct.SetActive(false);
        panelRegMom.SetActive(true);
    }
    public void OnClaRecuerdosPressed()
    {
        panelRegMom.SetActive(false);
        panelClaRec.SetActive(true);
    }
}
