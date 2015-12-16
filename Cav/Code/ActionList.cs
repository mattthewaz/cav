using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cav.Code
{
    public class ActionListItem
    {
        public ActionList ActionList;
        public GameActionType Action;
    }

    public class ActionList
    {
        public List<ActionListItem> Actions;
        public ActionListType Type;
    }

    public enum ActionListType
    {
        AndOr,
        EitherOr,
        AndThen
    }
}