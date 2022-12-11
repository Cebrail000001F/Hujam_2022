using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateProjectTile : MonoBehaviour
{
    private Camera _camera;
    private Vector3 _mousePos;
    
    void Start()
    {
        _camera = Camera.main;
    }


    void Update()
    {
        _mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = _mousePos - transform.position;
        //Atan2: x ve y bileşenleri ayrı ayrı vermemizi imkan tanıyan, bu sayede 0 ile bölünme gibi durumlarına önüne de geçerek tanjantın y/x şeklinde hesaplandığı durumlarda daha doğru sonuçlar almamızı sağlayan ters tan fonksiyonudur.

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
