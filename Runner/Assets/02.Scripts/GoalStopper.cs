using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class GoalStopper : MonoBehaviour
{
    private int _grade;

    public void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Runner runner))
        {
            runner.Finish(_grade++);

        }
    }
}