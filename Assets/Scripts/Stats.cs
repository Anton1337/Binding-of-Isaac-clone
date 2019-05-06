using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats {

    public int MoveSpeed {
        get { return _moveSpeed; }
    }
    public int Damage {
        get { return _damage; }
    }
    public int ShotSpeed {
        get { return _shotSpeed; }
    }
    public int MaxHealth {
        get { return _maxHealth; }
    }

    private int _moveSpeed;
    private int _damage;
    private int _shotSpeed;
    private int _maxHealth;

    public Stats() {
        _moveSpeed = 5;
        _damage = 1;
        _shotSpeed = 1;
        _maxHealth = 5;

    }
}
