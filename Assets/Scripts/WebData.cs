using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebData : MonoBehaviour
{
    private static string domain = "https://api.weather.yandex.ru/v2/forecast?";
    public static string Domain = domain;

    private static string header = "X-Yandex-API-Key";
    public static string Header = header;

    private static string ya_key = "ded36c79-57d8-4a8f-bbcc-d09ffa26a1fb";
    public static string Ya_Key = ya_key;
}

[System.Serializable]
public class Yandex_Meteo {
    public Yandex_Meteo_Place_info info;
    public Yandex_Meteo_Fact_Info fact;
}

[System.Serializable]
public class Yandex_Meteo_Place_info {
    public Yandex_Meteo_tz_Info tzinfo;
    public string url;
}

[System.Serializable]
public class Yandex_Meteo_tz_Info {
    public string name;
}

[System.Serializable]
public class Yandex_Meteo_Fact_Info {
    public int temp;
    public int feels_like;
    public string condition;
}

[System.Serializable]
public class Parametrs_Data
{
    public Parametrs[] data;
}

[System.Serializable]
public class Parametrs
{
    public string name;
    public string code2;
    public string code3;
}