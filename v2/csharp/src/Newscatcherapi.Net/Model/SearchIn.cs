/*
 * NewsCatcher News API V2
 *
 * NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python) 
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: team@newscatcherapi.com
 * Generated by: https://konfigthis.com
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Newscatcherapi.Net.Client.OpenAPIDateConverter;

namespace Newscatcherapi.Net.Model
{
    /// <summary>
    /// Defines search_in
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchIn
    {
        /// <summary>
        /// Enum Title for value: title
        /// </summary>
        [EnumMember(Value = "title")]
        Title = 1,

        /// <summary>
        /// Enum Summary for value: summary
        /// </summary>
        [EnumMember(Value = "summary")]
        Summary = 2,

        /// <summary>
        /// Enum TitleSummary for value: title_summary
        /// </summary>
        [EnumMember(Value = "title_summary")]
        TitleSummary = 3

    }

}