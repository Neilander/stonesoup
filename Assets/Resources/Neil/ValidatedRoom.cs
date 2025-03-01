using System;
using UnityEngine;

public class ValidatedRoom : Room
{
    
    public RoomExitMatrix matrix;


    public override Room createRoom(ExitConstraint requiredExits)
    {
        return base.createRoom(requiredExits);
    }

    public bool meetConstraint(ExitConstraint requiredExits)
    {
        return true;
    }
}


