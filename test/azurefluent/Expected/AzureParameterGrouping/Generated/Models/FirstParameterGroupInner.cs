// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AzureParameterGrouping.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for a set of operations, such as:
    /// ParameterGrouping_PostMultiParamGroups,
    /// ParameterGrouping_PostSharedParameterGroupObject.
    /// </summary>
    public partial class FirstParameterGroupInner
    {
        /// <summary>
        /// Initializes a new instance of the FirstParameterGroupInner class.
        /// </summary>
        public FirstParameterGroupInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirstParameterGroupInner class.
        /// </summary>
        /// <param name="queryOne">Query parameter with default</param>
        public FirstParameterGroupInner(string headerOne = default(string), int? queryOne = default(int?))
        {
            HeaderOne = headerOne;
            QueryOne = queryOne;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public string HeaderOne { get; set; }

        /// <summary>
        /// Gets or sets query parameter with default
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int? QueryOne { get; set; }

    }
}
