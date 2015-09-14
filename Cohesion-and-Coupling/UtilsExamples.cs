using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(GetFile.GetFileExtension("example"));
            Console.WriteLine(GetFile.GetFileExtension("example.pdf"));
            Console.WriteLine(GetFile.GetFileExtension("example.new.pdf"));

            Console.WriteLine(GetFile.GetFileNameWithoutExtension("example"));
            Console.WriteLine(GetFile.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(GetFile.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                CalcDistances.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                CalcDistances.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", CalcDistances.CalcVolume(5,6,7));
            Console.WriteLine("Diagonal XYZ = {0:f2}", CalcDistances.CalcDiagonalXYZ(3,4,5));
            Console.WriteLine("Diagonal XY = {0:f2}", CalcDistances.CalcDiagonalXY(3, 4));
            Console.WriteLine("Diagonal XZ = {0:f2}", CalcDistances.CalcDiagonalXZ(3, 4));
            Console.WriteLine("Diagonal YZ = {0:f2}", CalcDistances.CalcDiagonalYZ(3, 4));
        }
    }
}
