using System.Text.Json.Serialization;
public class MapObject
{
    [JsonInclude] private int[] position = new int[2];

    static int count = 0;

    public MapObject(int[] position)
    {
        count++;

        this.position = position;

    }

    public static int getCount()
    {
        return count;
    }

    public int[] getPosition()
    {
        return position;
    }
}
