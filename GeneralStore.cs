using System;
using System.Collections.Generic;
using System.Linq;

namespace ACM
{
    public class GeneralStore{
        private Dictionary<string, int> _numberOfProductsInAStore { get; set;}

        public void SetNumberOfProductsInAStore()
        {
            var tallies = new Dictionary<string, int>();
            tallies.Add("moll", 5);
            tallies.Add("toll", 15);
            tallies.Add("boll", 54);

            _numberOfProductsInAStore = tallies;

            // retreaving items from a dictionary
            Console.WriteLine(tallies["sds"]);
        }

        // using collections initializers 
        public void SetNumberOfProductsInAStoreInit()
        {
            var tallies = new Dictionary<string, int>(){
                {"moll", 5},
                {"toll", 15},
                {"boll", 54}
            };
            _numberOfProductsInAStore = tallies;
        }

        // collections can also be of objects
        

        //iterating through elements of a dictionary
        public void CommentOnFigures()
        {
            foreach(var store in _numberOfProductsInAStore.Keys)
            {
                var figure = _numberOfProductsInAStore[store];
                if(figure >= 10){
                    Console.WriteLine("Thats a good number");
                } else
                {
                    Console.WriteLine("Need for more work");
                }
            }
        }

        // using interfaces as return types
        public IEnumerable<Double> GetStoreNumbers(){
            // returning an enumerable is a promise to provide readonly sequence/immutable comllection

            var numbers = new List<Double>();
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            return numbers;
        }

        //Defining an iterator with yield
        public IEnumerable<string> CountOneByOne(){
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"We've reached count: {i}");
                yield return $"{i}";
            }
        }

        public IEnumerable<string> WhichLooksLike(){
            var myList = new List<string>();
            var zeroQuery = from v in myList
                                        where v.Contains("mmmi")
                                        select v;
            return myList;                                        
        }

        // using lambda expressions
        public IEnumerable<string> WhichLooksLike2(){
            var myList = new List<string>();
            var zeroQuery = CountOneByOne();
            return zeroQuery.Where(v => v.Contains("jj"));                                        
        }
    }   
}