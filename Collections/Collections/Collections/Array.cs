namespace Collection.Collections
{
    /// Array

    // int[] array = new int[size];
    // - hes specific number of items
    // - if we create an empty array all items will be 0 by default
    // = read and write is constant in time complexity
    // = index starts at 0
    // = Length field stores length of the array

    /// 2D Array

    // int[,] array2d = new int[sizeX, sizeY];
    // - all fields are initializes to 0 by defaul
    // - Length - returns sizeX * sizeY !!!
    // - if we want to get specific dimension length we need to use GetLength(value) vaule 0 means X dimension, value 1 means Y dimension

    //  int[,] kinosal = new int[,]
    //  {
    //      { 0, 0, 0, 0, 1 },
    //      { 0, 0, 0, 1, 1 },
    //      { 0, 0, 1, 1, 1 },
    //      { 0, 0, 0, 1, 1 },
    //      { 0, 0, 0, 0, 1 }
    //  };

    /// 3D array
    //   int[,,] array3d = new int[sizeX, sizeY, sizeZ];
    //   - Length - returns sizeX * sizeX * sizeY * sizeZ
    //   - to get Z dimension Length we can use GetLength(value) - value 2 means Z dimension

    /// Jagged Array
    //   int[][] jaggedArray = new int[value][]; - this value represents number of items in first array and that each item is also an array
    //   int[][] jaggedArray = new int[][]
    //   {
    //       new int[] {15, 2, 8, 5, 3},
    //       new int[] { 3, 3, 7 },
    //       new int[] { 9, 1, 16, 13 },
    //       new int[] { },
    //       new int[] { 5 }
    //    };
}