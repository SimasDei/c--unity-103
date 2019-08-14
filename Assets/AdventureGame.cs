using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Lorem ipsum dolor sit amet," +
            " consectetur adipiscing elit. Morbi ultricies tortor sodales gravida luctus." +
            " Mauris nec tristique nibh, aliquam dignissim orci. Morbi ac luctus tellus." +
            " Nunc eget purus auctor elit euismod pharetra. Mauris aliquet tortor ut ipsum consequat," +
            " non laoreet leo faucibus. Fusce ultricies, velit ac euismod scelerisque, ante turpis euismod dolor," +
            " at facilisis ante leo in lectus. Curabitur ac est porttitor, ultricies mi et, malesuada risus.";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
