using System;

///<summary>Class which defines method Area.</summary>
class Shape
{
    ///<summary>Throws NotImplementedException with message "Area() is not implemented"</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>Subclass of Shape.</summary>
class Rectangle : Shape
{
    // Width of the Rectangle.
    private int width;
    // Height of the Rectangle.
    private int height;

    ///<summary>Gets or sets the width of the Rectangle. If value is less than 0, throws an error.</summary>
    public int Width
    {
        get { return width; }
        set {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }
    ///<summary>Gets or sets the height of the Rectangle. If value is less than 0, throws an error.</summary>
    public int Height
    {
        get { return height; }
        set {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
    ///<summary>Returns the area of the Rectangle.</summary>
    public new int Area()
    {
        return width * height;
    }
    ///<summary>Prints the string representation of the Rectangle.</summary>
    public override string ToString()
    {
        return (String.Format("[Rectangle] {0} / {1}", width, height));
    }
}