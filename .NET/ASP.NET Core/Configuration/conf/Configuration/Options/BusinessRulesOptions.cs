using System;

namespace conf.Configuration.Options
{
    /// <summary>
    /// Options for business rule options which are to be read from Configuration.
    /// </summary>
    public class BusinessRulesOptions
    {
        public string AutomaticRegisterVehicles { get; set; }

        public string UsersCanDeleteVehicles { get; set; }
    }
}
