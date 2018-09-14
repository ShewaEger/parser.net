using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet.Model;

namespace parser.net
{
	class Check
	{
		virtual public bool CheckString(string a){
			return false;
		}
		virtual public bool CheckGroup(VkNet.Model.Group g){
			return false;
		}
	}

	class CheckWithoutPhoto: Check{
		public override bool CheckString(string a)
		{
			return a == "/images/community_50.png";
		}

		public override bool CheckGroup(Group g)
		{
			if (g.Cover.Enabled.HasValue)
				return !g.Cover.Enabled.Value;
			else
				return false;
		}

	}
	
	class CheckWithPhoto: Check{
		public override bool CheckString(string a)
		{
			return a != "/images/community_50.png";
		}
		public override bool CheckGroup(Group g)
		{
			if (g.Cover.Enabled.HasValue)
				return g.Cover.Enabled.Value;
			else
				return false;
		}
	}
}


