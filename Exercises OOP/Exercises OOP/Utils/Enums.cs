namespace Exercises_OOP.Classes
{
    // If we ommits the [Flag] attribute when converting to string flag which equals to undefined number it will be represented as an int value
    // otherwise it will be concatenation of two flag strings i.e Brown, Black instead of 12 
    [Flags]
    enum EyeColor
    {
        Undefined           = 0,
        Blue                = 1,
        Green               = 2,
        Brown               = 4,
        Black               = 8,
        GreenBlue           = Green | Blue,
        BrownGreen          = Brown | Green,
    }

    enum HairColor
    {
        Undefined,
        Blond,
        Brown,
        Black,
        Redhead
    }
}