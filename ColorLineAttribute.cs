using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorLineAttribute : PropertyAttribute {

    public Color lineColor;

	public ColorLineAttribute(float red, float blue, float green)
    {
        lineColor = new Vector4(red, blue, green, 1);
    }
}

[CustomPropertyDrawer(typeof(ColorLineAttribute))]
public class ColorLineDrawer : DecoratorDrawer
{
    ColorLineAttribute myColorAttr
    {
        get {return ((ColorLineAttribute)attribute); }
    }
    public override float GetHeight()
    {
        return base.GetHeight();
    }
    public override void OnGUI(Rect position)
    {
        position.y += position.height/2;
        position.height = 1;
        EditorGUI.DrawRect(position, myColorAttr.lineColor);
    }
}
