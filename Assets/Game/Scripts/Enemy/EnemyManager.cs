using System;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{
  private Enemy[,] enemies = new Enemy[11, 5];

  private void Awake()
  {
    for (int i = 0; i < enemies.Rank; i++)
    {
    }
  }
}

public class Enemy
{
}
