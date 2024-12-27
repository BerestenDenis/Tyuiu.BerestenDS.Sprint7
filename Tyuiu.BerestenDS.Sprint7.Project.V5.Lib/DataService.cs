namespace Tyuiu.BerestenDS.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        static double[] RemoveLastElement(double[] array)
        {

            if (array.Length == 0)
            {
                return array;
            }

            double[] newArray = new double[array.Length - 1];

            Array.Copy(array, newArray, array.Length - 1);

            return newArray;
        }

        public double FindMiddleValue(double[] array)
        {
            array = RemoveLastElement(array);
            return Math.Round(array.Sum() / (array.Length), 3);
        }

        public double FindTotalValue(double[] array)
        {
            array = RemoveLastElement(array);
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return Math.Round(result, 3);
        }

        public double FindMinValue(double[] array)
        {
            return array.Min();
        }

        public double FindMaxValue(double[] array)
        {
            return array.Max();
        }
    }
}
