using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TE_CSharp

{
    internal class Collection
    {
        //dictionary
        public static void Main()
        { 
            Dictionary<string, string> My_dict = new Dictionary<string, string>();
            My_dict.Add("s1", "Allu Arjun");
            My_dict.Add("s2", "Nani");
            My_dict.Add("s3", "Dulkhar Salman");
            Console.WriteLine("Dictionary");
            foreach (KeyValuePair<string, string> element in My_dict)
            {
                Console.WriteLine("key: {0} and value:{1} ", element.Key, element.Value);
            }
            Console.WriteLine("------------------------------------------------------------");
            //hashtag
            Hashtable my_hashtable = new Hashtable();
            my_hashtable.Add("S1", "Allu Arjun");
            my_hashtable.Add("S2", "Nani");
            my_hashtable.Add("S3", "Dulkhar Salman");
            Console.WriteLine("Hashtable");
            foreach (DictionaryEntry element in my_hashtable)
            {
                Console.WriteLine("key: {0} and value:{1} ", element.Key, element.Value);
            }
            Console.ReadKey();
        }
    }
}