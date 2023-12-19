namespace elementOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "asmaa", "ahmed", "hassan" };
                        //to return the first element in array
        var fElement=names.First();
            Console.WriteLine(fElement);

            //to return the  element in array with condition
            var element = names.First(a=>a.StartsWith("h"));
            Console.WriteLine(element);
            //to return the last element in array
            var Lelement = names.Last();
            Console.WriteLine(Lelement);


            //to return the  element in array with condition
            var Element = names.Last(a => a.StartsWith("h"));
            Console.WriteLine(Element);

        }
    }
}