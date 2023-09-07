namespace overrideoperator
{
    class MyArr
    {
        public int x, y, z;

        public MyArr(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static bool operator ==(MyArr i, MyArr j)
        {
            if ((i.x == j.x) && (i.y == j.y) && (i.z == j.z))
                return true;
            return false;
        }

        public static bool operator !=(MyArr i, MyArr j)
        {
            if ((i.x != j.x) || (i.y != j.y) || (i.z != j.z))
                return true;
            return false;
        }
    }

    class Program{
        static void Main(string[] args)
        {
            MyArr arr1 = new MyArr(4, 5, 12);
            MyArr arr2 = new MyArr(4, 5, 12);
            if (arr1 == arr2)
            {
                Console.WriteLine("Объекты равны");
            }
            MyArr arr3 = new MyArr(4, 6, 12);
            MyArr arr4 = new MyArr(4, 5, 12);
            if (arr3 == arr4)
            {
                Console.WriteLine("Объекты равны");
            }
            else
            {
                Console.WriteLine("Объекты не равны");
            }
        }
    }
}