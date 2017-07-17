using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Translate
    {
        public Translate()
        {
        }

        public virtual string UserInterface(int Code)
        {
            return null;
        }

        public virtual string Map(int Code)
        {
            return null;
        }

        public virtual string Item(int Code)
        {
            return null;
        }

        public virtual string Monster(int Code)
        {
            return null;
        }

        public virtual string NPC(int Code)
        {
            return null;
        }

        public virtual string Skill(int Code)
        {
            return null;
        }
    }

    #region Korean
    public class Korean : Translate
    {
        public override string UserInterface(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string Map(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string Item(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string Monster(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string NPC(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string Skill(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }
    }
    #endregion
    #region English
    public class English : Translate
    {
        public override string UserInterface(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string Map(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string Item(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string Monster(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string NPC(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }

        public override string Skill(int Code)
        {
            switch (Code)
            {
                case 0: return null;
            }

            return null;
        }
    }
    #endregion
}
