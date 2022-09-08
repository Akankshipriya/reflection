using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace view_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection.MethodInfo");
            Type myType = Type.GetType("System.Reflection.FieldInfo");
            PropertyInfo myMethodInfo = myType.GetProperty("FieldType");
            Console.WriteLine(myType.FullName);
            MemberTypes myMemberTypes = myMethodInfo.MemberType;
            
            if (MemberTypes.Constructor == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type All");
            }
            else if (MemberTypes.Custom == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Custom");
            }
            else if (MemberTypes.Event == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Event");
            }
            else if (MemberTypes.Field == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Field");
            }
            else if (MemberTypes.Method == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Method");
            }
            else if (MemberTypes.Property == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Property");
            }
            else if (MemberTypes.TypeInfo == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type TypeInfo");
            }
            Console.ReadLine();
        }
    }
}
