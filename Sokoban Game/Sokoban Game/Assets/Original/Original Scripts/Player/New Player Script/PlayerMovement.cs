using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class PlayerMovement : MonoBehaviour
{

    public bool Move(Vector2 Direction)
    {
        if (Mathf.Abs(Direction.x) < 0.5)
        {
            Direction.x = 0;
        }
        else
        {
            Direction.y = 0;
        }

        Direction.Normalize();
        if (blocked(transform.position, Direction))
        {
            return false;
        }
        else
        {
            transform.Translate(Direction);
            return true;
        }
    }

    bool blocked(Vector3 position, Vector2 direction)
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction;
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (var wall in walls)
        {
            if (wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y)
            {
                return true;
            }
        }

        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (var box in boxes)
        {
            if (box.transform.position.x == newPos.x && box.transform.position.y == newPos.y)
            {
                Box bx = box.GetComponent<Box>();
                if (bx && bx.Move(direction))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        return false;
    }

}
