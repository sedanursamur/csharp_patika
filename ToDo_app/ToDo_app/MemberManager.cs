using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_app
{
    public class MemberManager
    {

        public Member FindMember(int memberId)
        {
            return MemberDataSource.Members.FirstOrDefault(x => x.Id == memberId);
        }
    }
}
