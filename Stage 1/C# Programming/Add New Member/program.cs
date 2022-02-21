using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewMember              //Do not change the namespace name
{
    public class Club          //Do not change the class name
    {
        
        static Dictionary<int, string> groupInfo = new Dictionary<int, string>() { { 1, "Gold" }, { 2, "Silver" }, { 3, "Platinum" } };
        static Dictionary<int, List<String>> memberInfo = new Dictionary<int, List<String>>() {
                                    { 1, new List<string>(){ "Tom","Harry"} },
                                    { 2,new List<string>(){ "Sam","Peter"} },
                                    { 3,new List<string>(){ "Kim","Robert"} } };

        public static void Main(string[] args)        //Do not change the method signature
        {
            Console.WriteLine("Group Name :");
            string groupName = Console.ReadLine();
            Console.WriteLine("Member Name:");
            string memberName = Console.ReadLine();

            int groupKey = 0;
            foreach (var group in groupInfo)
            {
                if (group.Value == groupName)
                {
                    groupKey = group.Key;
                }
            }
            memberInfo[groupKey].Add(memberName);
            foreach (string member in memberInfo[groupKey])
            {
                Console.WriteLine(member);
            }
        }
    }
}
