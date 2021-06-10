using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_app
{
    public static class MemberDataSource
    {
        public static List<Member> Members;


        static MemberDataSource()
        {
            Members = InitializeMembers();
        }



        static List<Member> InitializeMembers()
        {
            return new List<Member>()
            {
                new Member(1,"Sedanur Samur"),
                new Member(2,"Şenay Tuncel")

            };
        }
    }
}