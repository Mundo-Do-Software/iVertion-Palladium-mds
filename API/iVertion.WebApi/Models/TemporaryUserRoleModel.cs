using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iVertion.WebApi.Models
{
    public class TemporaryUserRoleModel
    {
        /// <summary>
        /// A role registered in the Identity roles.
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// An existing username on Identity.
        /// </summary>
        public string? UserName { get; set; }
        /// <summary>
        /// The start date of the temporary user role.
        /// </summary>
        /// <value></value>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// The end date of the temporary user role.
        /// </summary>
        /// <value></value>
        public DateTime ExpirationDate { get; set; }
    }
}