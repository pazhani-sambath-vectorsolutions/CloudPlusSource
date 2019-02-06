﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPlus.Workflows.Office365.Activities.UserGroup.RemoveDatabaseSecurityGroup
{
    public interface IRemoveDatabaseSecurityGroupArguments
    {
        string Office365CustomerId { get; set; }
        string SecurityGroupName { get; set; }
        string CustomerO365Domain { get; set; }
        string UserSMTPAddress { get; set; }
    }
}
