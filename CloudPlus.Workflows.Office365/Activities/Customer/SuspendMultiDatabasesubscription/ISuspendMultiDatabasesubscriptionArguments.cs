﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPlus.Workflows.Office365.Activities.Customer.SuspendMultiDatabasesubscription
{
    public interface ISuspendMultiDatabasesubscriptionArguments
    {
        List<string> Office365SubscriptionIds { get; set; }
    }
}
