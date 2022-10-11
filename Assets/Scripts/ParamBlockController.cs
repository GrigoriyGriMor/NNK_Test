using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParamBlockController : MonoBehaviour
{
    [SerializeField] private TMP_Text t_name;
    [SerializeField] private TMP_Text t_number;
    [SerializeField] private TMP_Text t_series;

    public void Init(Parametrs data)
    {
        t_name.text = data.name;
        t_number.text = data.code2;
        t_series.text = data.code3;
    }
}
