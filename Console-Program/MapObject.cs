public class MapObject
{
    (int, int) position; //Just 2D

    static int count = 0;

    public MapObject((int, int) position)
    {
        count++;

        this.position = position;

    }

    public static int getCount()
    {
        return count;
    }

    public (int, int) getPosition()
    {
        return position;
    }
}
