public class Car
{
    public int ModelYear { get; set; }
    public string Maker { get; set; }
    //
    public override string ToString()
    {
        return $"{ ModelYear } , { Maker }";
    }
}
