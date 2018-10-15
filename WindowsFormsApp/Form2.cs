using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp.Form2;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        //https://www.dotnetperls.com/ilist
        private void IListButon(object sender, EventArgs e)
        {
            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            Display(array);

            List<int> list = new List<int>();
            list.Add(5);
            list.Add(7);
            list.Add(9);
            Display(list);
        }

        static void Display(IList<int> list)
        {
            Console.WriteLine("Count: {0}", list.Count);
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
        }

        //https://www.dotnetperls.com/ienumerable
        private void IEnumerableButton(object sender, EventArgs e)
        {
            IEnumerable<int> result = from value in Enumerable.Range(1, 7)
                                      select value;

            // Iterare in colectia de tip IEnumerable
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }

            // Extension methods on IEnumerable<int>
            double average = result.Average();
            Console.WriteLine("Media aritmetica a numerelor din colectie este: " + average);

            // Extension methods can convert IEnumerable<int>
            List<int> list = result.ToList();
            int[] array = result.ToArray();
        }

        //https://www.kenneth-truyers.net/2016/05/12/yield-return-in-c/
        // Fiecare iteratie a buclei foreach cheama metoda iteratoare pana intalneste instructiunea yield return.
        // In acest moment valoarea este returnata catre apelant si valoarea din functia de iterare este salvata.
        // Executia se reia de la valoarea respectiva data urmatoare cand functia de iterare este chemata.
        // Aceasta continua pana la epuizarea yield return-urilor.
        private void YieldReturnButton(object sender, EventArgs e)
        {
            IEnumerable<int> GenerateWithYield()
            {
                var i = 0;
                while (true)
                    yield return ++i;
            }

            foreach (var number in GenerateWithYield().Take(5))
                Console.WriteLine(number);
        }

        private void YieldReturnMultipleIterationsButton(object sender, EventArgs e)
        {
            IEnumerable<int> GetNumbersGreaterThan3(List<int> numbers)
            {
                foreach (var nr in numbers)
                {
                    if (nr > 3)
                        yield return nr;
                }
            }
            foreach (var nr in GetNumbersGreaterThan3(new List<int> { 1, 2, 3, 4, 5 }))
                Console.WriteLine(nr);
        }

        //http://www.tutorialsteacher.com/csharp/csharp-generics
        private void Generics1IntButton(object sender, EventArgs e)
        {
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            int val = intGenericClass.genericMethod(200);
        }

        private void Generics2StringButon(object sender, EventArgs e)
        {
            MyGenericClass<string> strGenericClass = new MyGenericClass<string>("Hello Generic World");

            strGenericClass.genericProperty = "This is a generic property example.";
            string result = strGenericClass.genericMethod("Generic Parameter");
        }

        private void GenericDelegate1IntButton(object sender, EventArgs e)
        {
            GenericDelegate genericDelegate = new GenericDelegate();

            GenericDelegate.add<int> sum = genericDelegate.AddNumber;

            Console.WriteLine(sum(10, 20));
        }

        private void GenericDelegate2StringButton(object sender, EventArgs e)
        {
            GenericDelegate genericDelegate = new GenericDelegate();

            GenericDelegate.add<string> conct = genericDelegate.Concate;

            Console.WriteLine(genericDelegate.Concate("Hello, buey ", "World!!"));
        }

        

        private void LinQButton(object sender, EventArgs e)
        {
            IEnumerable<int> result = (from value in Enumerable.Range(1, 20) where value%2 == 0
                                      select value).Skip(3).Take(5);

            
            if (result.Any(v => v > 10))
            {
                Console.WriteLine("Sunt valori care indeplinesc conditiile selectiei si sunt mai mari decat 10");
            }
            else
            {
                Console.WriteLine("Conditiile selectiei nu pot fi indeplinite si/sau valorile nu depasesc valoarea 10");
            }

            //Technical task 8: You have a type that is IEnumerable<string> items, make it so that
            //it display all members in the following expression Console.Writeline(items)
            //https://stackoverflow.com/questions/35206799/getting-all-elements-from-an-ienumerable

            IEnumerable<string> items = new string[] { "unu", "doi", "trei" };

            items = new WriteEnum { Items = items };

            Console.WriteLine(items);


            if (result.All(v => v > 5))
            {
                foreach (var value in result)
                {
                    Console.WriteLine(value);
                }
            }
            
        }

        

        private void LinQSingleExampleButton(object sender, EventArgs e)
        {
            var result = (from value in Enumerable.Range(1, 20)
                                       where value % 17 == 0
                                       select value).Single();

            Console.WriteLine(result);
        }

        private void LinQFirstExampleButton(object sender, EventArgs e)
        {
            var result = (from value in Enumerable.Range(1, 20)
                          where value % 5 == 0
                          select value).First();

            Console.WriteLine(result);
        }

        //http://www.tutorialsteacher.com/csharp/csharp-extension-method
        private void ExtensionMethodButton(object sender, EventArgs e)
        {
            IEnumerable<int> result = from value in Enumerable.Range(1, 20)
                                      where value % 2 == 0
                                      select value;

            foreach (var value in result)
            {
                if (value.IsDividedBy(4))
                {
                    Console.WriteLine(value);
                }
            }
            
        }

        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
        private void BoxingUnboxingButton(object sender, EventArgs e)
        {
            List<object> items = new List<object>() { "unu", "doi", "trei" };

            items.Add("patru");

            for (int j = 5; j < 10; j++)
            {
                items.Add(j);
            }

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            var sum = 0;

            for (var i = 0; i < items.Count; i++)
            {
                if (items[i].GetType() == typeof(int))
                {
                    sum += (int)items[i] ^ 2;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }

        //https://www.youtube.com/watch?v=5C7W98VVI88
        private void ExplicitInterfaceImplementationButton(object sender, EventArgs e)
        {
            ImpVsExpIntImp x = new ImpVsExpIntImp();

            x.InterfaceMethod();
            ((I1)x).InterfaceMethod();
            ((I2)x).InterfaceMethod();

        }
    }

    //http://www.tutorialsteacher.com/csharp/csharp-generics
    class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }

    class GenericDelegate
    {
        public delegate T add<T>(T param1, T param2);
        
        public int AddNumber(int val1, int val2)
        {
            return val1 + val2;
        }

        public string Concate(string str1, string str2)
        {
            return str1 + str2;
        }
    }

    public static class ExtensionMethod
    {
        public static bool IsDividedBy(this int i, int value)
        {
            return i%value==0;
        }
    }

    public class ImpVsExpIntImp: I1, I2
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("Implicit Interface Method");
        }

        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Explicit Interface Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Explicit Interface Method");
        }
    }

    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }

    class WriteEnum : IEnumerable<string>
    {
        public IEnumerable<string> Items { get; set; }
        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            
            string output = String.Join(",", Items);
           
            return output;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
