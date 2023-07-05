namespace GeometryLib;

public static class ShapeBuilder
{
    /// <summary>
    /// Возвращает объект производный от класса Shape в зависимости от количества полученных параметров 
    /// </summary>
    public static Shape? GetShape(params double[] parameters)
    {
        if (parameters?.Length == 1)
        {
            return new Сircle(parameters.First());
        }
        else if (parameters?.Length == 3)
        {
            return new Triangle(parameters[0], parameters[1], parameters[2]);
        }
        return null;
    }
}
