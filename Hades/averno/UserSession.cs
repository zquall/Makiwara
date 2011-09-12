using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hades.averno
{
    class UserSession
    {
        private int _UserId;
        public UserSession (int userId)
	    {
            _UserId = userId;
	    }
        public int UserId { get { return _UserId; } }

    }
}
