using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floatbutton : MonoBehaviour
{
    [SerializeField] Transform targetOnModel;
    
    RectTransform rectTransform;
    Image image;


    public float showDistance;
    public Camera m_MainCamera;
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    private void Update()
    {


        var screenPoint = m_MainCamera.WorldToScreenPoint(targetOnModel.position);
        GetComponent<RectTransform>().position=screenPoint;
        var viewPortPoint =m_MainCamera.WorldToViewportPoint(targetOnModel.position);
        var distanceFromCenter = Vector2.Distance(viewPortPoint,Vector2.one*0.5f);
        var show = distanceFromCenter<showDistance;
        image.enabled =show;
    }


}
