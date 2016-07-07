using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts.Walls_And_Regulations
{
    public class SliderController : MonoBehaviour
    {
        private static double progress;
        private  static Slider slider;

        public  double Progress
        {
            get { return slider.value; }
        }

        public void Start()
        {
            slider = this.GetComponent<Slider>();
            StartCoroutine(IncreaseSliderValue());
        }

        public void Update()
        {

        }

        public static IEnumerator IncreaseSliderValue()
        {
            //TOIMPLEMENT IS DEAD
            while (true)
            {
                yield return new WaitForSeconds(1);
                slider.value += Time.deltaTime;
            }
        }
    }
}
