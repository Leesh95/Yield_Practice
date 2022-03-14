public class Agency
{
    public Car[] Cars;
    //
    public IEnumerator<Car> GetEnumerator()
    {
        foreach (var car in Cars)
            yield return car;
    }
    //
    public IEnumerable<Car> GetCars(int modelYear)
    {
        foreach (var car in Cars)
        {
            if (car.ModelYear == modelYear)
                yield return car;
        }
    }
    //
    public IEnumerable<Car> GetCars(string maker)
    {
        foreach (var car in Cars)
        {
            if (car.Maker == maker)
                yield return car;
        }
    }
}
