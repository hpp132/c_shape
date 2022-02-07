using System;
namespace c_shape
{
    public class test
    {
        public test()
        {

        }
        protected double width;
        protected double height;
        public void setWidth(double w) {
            width = w;
        }
        public void setHeight(double h)
        {
            height = h;
        }
        public double getArea()
        {
            return width * height;
        }
        public void display()
        {
            Console.WriteLine("width:{0}, height:{1}", width, height);
            Console.Write("面积是:{0}", getArea());
        }

    }

    public class helloWorld
    {
        static void Main()
        {
            Console.WriteLine("hello world !");
            test t = new test();
            t.setWidth(10);
            t.setHeight(20);
            t.display();
            Console.ReadKey();
        }
    }
}
