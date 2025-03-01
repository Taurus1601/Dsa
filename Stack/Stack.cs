using System;

namespace dsaAndDaa.Stack
{
    public class CustomStack{
        private List<int> _stack {get;}
        private int _top {get; set;}
        
        public CustomStack(){
            _stack = new List<int>();
            _top = -1;
        }
        public void push(int element){
            _stack.Add(element);
            Console.WriteLine($"Element{element} was succesfully added!!");
        }

        public int pop (){
            int _to_return =  _stack[_stack.Count];
            _stack.Remove(_stack[_stack.Count]);
            return _to_return;
        }

        public void show(){
            foreach(int element in _stack){
                Console.Write(element) ;
                Console.Write("  ");
            }
        }

        public static void Main(string[] args){
            Console.WriteLine("Welcome to Stack Operations!!");
            CustomStack newStack = new CustomStack();
            Console.WriteLine("Current Stack is Empty ..Add Elements First");
            Console.WriteLine("How many Elments do you want to add ??");

            var n = int.Parse(Console.ReadLine());

            for (int i =0;i<n ; i++)
            {
                
            }

        }
    }
}