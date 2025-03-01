using dsaAndDaa.Arrays;

namespace dsaAndDaa {
    public class Program {
        public static void Main(String[] args)
        {
            int[] array = new int[] {1,2,3,4,5,6,7,8,9,10};
            CustomArrays myOwnArray = new CustomArrays(array);
            myOwnArray.pringIntArray();
        }
    }
}