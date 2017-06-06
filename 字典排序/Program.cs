using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字典排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, LevelGroup> dic = new Dictionary<int, 字典排序.LevelGroup>();
            dic.Add(1, new LevelGroup() { Level = 50, Group = 52 });
            dic.Add(2, new LevelGroup() { Level = 4, Group = 20 });
            dic.Add(3, new LevelGroup() { Level = 80, Group = 82 });
            dic.Add(5, new LevelGroup() { Level = 80, Group = 92 });
            dic.Add(4, new LevelGroup() { Level = 40, Group = 29 });
            dic.Add(6, new LevelGroup() { Level = 50, Group = 42 });
            dic.Add(7, new LevelGroup() { Level = 1, Group = 2 });
            var dicSort = from objDic in dic orderby objDic.Value.Level descending select objDic;
            List<KeyValuePair<int, LevelGroup>> lstorder = dic.OrderBy(c => c.Value.Level).ThenBy(c => c.Value.Group).ToList();
            foreach (var item in lstorder)
            {
                Console.WriteLine("键{0}Level{1}，Group{2}",item.Key,item.Value.Level,item.Value.Group);
            }
            Console.ReadKey();
        }
    }
    public class LevelGroup
    {
        public int Level { get; set; }
        public int Group { get; set; }
    }
}
