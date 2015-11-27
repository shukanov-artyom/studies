using System;
using System.Collections.Generic;
using System.Linq;
using Search.Utils;

namespace Search
{
    public static class Program
    {
        private static readonly char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        private const int maxN = 3000;

        public static void Main(string[] args)
        {
            Random rnd = new Random(1000002);
            Random rndDouble = new Random(123456);

            List<Item> testData = new List<Item>();
            while (testData.Count < maxN)
            {
                Item item = new Item()
                            {
                                Key = rnd.Next(maxN),
                                Value = alpha[rndDouble.Next(26)].ToString()
                            };
                if (testData.Any(d => d.Key == item.Key))
                {
                    continue;
                }
                testData.Add(item);
            }

            List<ISymbolTable> tables = new List<ISymbolTable>()
                                        {
                                            new PrimitiveSymbolTable(),
                                            new IndexedKeySymbolTable(maxN),
                                            new ConsequentialSearchSymbolTable(maxN),
                                            new BinarySearchSymbolTable(maxN),
                                            new InterpolationalSearchSymbolTable(maxN),
                                            new BstSymbolTable(),
                                            new RbSymbolTable(),
                                            new DynamicHashtableSymbolTable(maxN+maxN),
                                            new DstSymbolTable(),
                                            //new RandomizedBstSymbolTable(),
                                            //new TrieSymbolTable()
                                            new DotNetDictionarySymbolTable(),
                                            new DotNetSortedDictionarySymbolTable(),
                                            //new TstSymbolTable(),
                                            //new PatriciaTreeSymbolTable()
                                            new BTreeSymbolTable()
                                        };

            foreach (ISymbolTable symbolTable in tables)
            {
                DoTest(testData, symbolTable);
            }
            Console.Read();

            TextIndexiationTest();
        }

        private static void TextIndexiationTest()
        {
            string text = @"ИЗВЛЕЧЕНИЯ 
      (Собранные Младшим Помощником библиотекаря) 
      Читатель сможет убедиться, что этот бедняга Младший Помощник, немудрящий буквоед и книжный червь, перерыл целые ватиканские библиотеки и все лавки букинистов на свете в поисках любых - хотя бы случайных - упоминаний о китах, которые могли только встретиться ему в каких бы то ни было книгах, от священных до богохульных. И потому не следует во всех случаях понимать эти беспорядочные китовые цитаты, хотя и несомненно подлинные, за святое и неоспоримое евангелие цетологии. Это вовсе не так. Отрывки из трудов всех этих древних авторов и упоминаемых здесь поэтов представляют для нас интерес и ценность лишь постольку, поскольку они дают нам общий взгляд с птичьего полета на все то, что только ни было когда-либо, в любой связи и по любому поводу, сказано, придумано, упомянуто и спето о Левиафане всеми нациями и поколениями, включая теперешние. 
      Итак, прощай, бедняга Младший Помощник, чьим комментатором я выступаю. Ты принадлежишь к тому безрадостному племени, которое в этом мире никаким вином не согреть и для кого даже белый херес оказался бы слишком розовым и крепким; но с такими, как ты, приятно иногда посидеть вдвоем, чувствуя себя тоже несчастным и одиноким, и, упиваясь пролитыми слезами, проникаться дружелюбием к своему собеседнику; и хочется сказать вам прямо, без обиняков, пока глаза наши мокры, а стаканы сухи и на сердце - сладкая печаль: Бросьте вы это дело. Младшие Помощники! Ведь чем больше усилий будете вы прилагать к тому, чтобы угодить миру, тем меньше благодарности вы дождетесь! Эх, если б мог я очистить для вас Хэмптон-Корт или Тюильрийский дворец! Но глотайте скорее ваши слезы и вскиньте голову, воспарите духом! выше, выше, на самый топ грот-мачты! ибо товарищи ваши, опередившие вас, освобождают для вас семиэтажные небеса, изгоняя прочь перед вашим приходом истинных баловней - Гавриила, Михаила и Рафаила. Здесь мы только чокаемся разбитыми сердцами - там вы сможете сдвинуть разом свои небьющиеся кубки!";
        }

        private static void DoTest(List<Item> testData, ISymbolTable symbolTable)
        {
            Stack<Item> inserted = new Stack<Item>(testData.Count);
            Random r = new Random(DateTime.Now.Millisecond);
            DateTime start = DateTime.Now;
            foreach (Item item in testData)
            {
                symbolTable.Insert(item);
                inserted.Push(item);
            }
            foreach (Item item in inserted.Reverse())
            {
                Item found = symbolTable.Search(item.Key);
                if (!found.Value.Equals(item.Value))
                {
                    throw new Exception();
                }
            }
            for (int i = 0; i < testData.Count; i++)
            {
                int randomIndex = r.Next(testData.Count);
                Item searched = testData[randomIndex];
                Item found = symbolTable.Search(searched.Key);
                if (!found.Value.Equals(searched.Value))
                {
                    throw new Exception();
                }
            }
            DateTime finish = DateTime.Now;
            TimeSpan span = finish - start;
            Console.WriteLine("Timing for {0}: {1} ms", symbolTable.GetType(), span.TotalMilliseconds);
        }
    }
}
