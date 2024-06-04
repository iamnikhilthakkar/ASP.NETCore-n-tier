using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionPulse.Core.Model.Common
{
    /// <summary>
    /// Response wrapper object
    /// </summary>
    public class BaseResponse<T>
    {
        /// <summary>
        /// Response Data
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Response Code
        /// </summary>
        public int ResponseCode { get; set; } = 200;

        /// <summary>
        /// Response Message or exception
        /// </summary>
        public string Message { get; set; }
    }

    /// <summary>
    /// Response wrapper object
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// Response Data
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Response Code
        /// </summary>
        public int ResponseCode { get; set; } = 200;

        /// <summary>
        /// Response Message or exception
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Response ID of record
        /// </summary>
        public long ID { get; set; }
    }
}
