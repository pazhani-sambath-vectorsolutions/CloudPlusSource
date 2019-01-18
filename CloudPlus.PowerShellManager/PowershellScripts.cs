﻿namespace CloudPlus.PowerShell
{
    public static class PowershellScripts
    {
		#region User
		public static string GetUser = "User\\GetUser.ps1";
		public static string CreateUser = "User\\CreateUser.ps1";
        public static string UpdateUser = "User\\UpdateUser.ps1";
        public static string DeleteUser = "User\\DeleteUser.ps1";
        public static string SamAccountNameAvailable = "User\\SamAccountNameAvailable.ps1";
        public static string ChangeUserPassword = "User\\ChangeUserPassword.ps1";
        #endregion

        #region Company
        public static string CreateCompany = "Company\\CreateCompany.ps1";
        #endregion

        #region Office 365
        public static string SetUserImmutableId = "User\\SetUserImmutableId.ps1";
        public static string O365CreateUser = "User\\CreateUser.ps1";
        public static string HardDeleteUser = "User\\HardDeleteUser.ps1";
        public static string GetUserRoles = "User\\GetUserRoles.ps1";
        public static string AssignUserRoles = "User\\AssignUserRoles.ps1";
        public static string RemoveUserRoles = "User\\RemoveUserRoles.ps1";
        public static string GetCustomerIdByDomain = "Customer\\GetCustomerIdByDomain.ps1";
        public static string AddCustomerDomain = "Domain\\AddCustomerDomain.ps1";
        public static string RemoveCustomerDomain = "Domain\\RemoveCustomerDomain.ps1";
        public static string GetDomainTxtRecord = "Domain\\GetDomainTxtRecord.ps1";
        public static string FederateCustomerDomain = "Domain\\FederateCustomerDomain.ps1";
	    public static string UnfederateCustomerDomain = "Domain\\UnfederateCustomerDomain.ps1";
        public static string VerifyCustomerDomain = "Domain\\VerifyCustomerDomain.ps1";
        public static string IsDomainVerified = "Domain\\IsCustomerDomainVerified.ps1";
        public static string IsDomainFederated = "Domain\\IsCustomerDomainFederated.ps1";
        public static string GetTransitionMatchingData = "Transition\\GetTransitionMatchingData.ps1";
        #endregion
    }
}
