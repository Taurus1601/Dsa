namespace dsaAndDaa.Arrays{
    
    public class CustomArrays(int [] array)
    {
        public int [] arr {get;}  = array;


        public void pringIntArray(){
            foreach(int i in arr ){
                System.Console.WriteLine(i);
            }
        }
       
    }

}