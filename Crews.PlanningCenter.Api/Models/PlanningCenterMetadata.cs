﻿using System.Text.Json.Serialization;
using JsonApiFramework.JsonApi;

namespace Crews.PlanningCenter.Api;

/// <summary> 
/// Represents metadata returned in a Planning Center API response. 
/// </summary> 
public class PlanningCenterMetadata
{
	/// <summary> 
	/// Names of Planning Center data object types that can be included in the API response. 
	/// </summary> 
	[JsonPropertyName("can_include")] 
	public IEnumerable<string> CanInclude { get; init; } = []; 
 
	/// <summary> 
	/// Names of attributes of the current data object type that can be used for querying the collection of data objects. 
	/// </summary> 
	[JsonPropertyName("can_query_by")] 
	public IEnumerable<string> CanQueryBy { get; init; } = []; 
 
	/// <summary> 
	/// Names of properties that can be used to filter the collection of data objects. 
	/// </summary> 
	[JsonPropertyName("can_filter")] 
	public IEnumerable<string> CanFilter { get; init; } = []; 
 
	/// <summary> 
	/// Names of attributes of the current data object type that can be used for ordering the collection of data objects. 
	/// </summary> 
	[JsonPropertyName("can_order_by")] 
	public IEnumerable<string> CanOrderBy { get; init; } = []; 
 
	/// <summary> 
	/// The number of data objects returned in the current API response object. If this number is less than `TotalCount`, 
	/// modifying the page offset of the request will return a different subset of paginated objects from this total. 
	/// </summary> 
	[JsonPropertyName("count")] 
	public int? Count { get; init; } 
 
	/// <summary> 
	/// The total number of paginated data objects available based on the API request. If this number is greater than  
	/// `Count`, modifying the page offset of the request will return a different subset of paginated objects from this  
	/// total. 
	/// </summary> 
	[JsonPropertyName("total_count")] 
	public int? TotalCount { get; init; } 
 
	/// <summary> 
	/// The parent data object of the data object or collection of data objects in the current API response. 
	/// </summary> 
	[JsonPropertyName("parent")] 
	public ResourceIdentifier? Parent { get; init; } 
 
	/// <summary> 
	/// The next page of paginated data objects. 
	/// </summary> 
	[JsonPropertyName("next")] 
	public Page? Next { get; init; } 
 
	/// <summary> 
	/// The previous page of paginated data objects. 
	/// </summary> 
	[JsonPropertyName("prev")] 
	public Page? Prev { get; init; } 
 
	/// <summary> 
	/// Represents a page in a Planning Center API responses containing a paginated collection of data objects. 
	/// </summary> 
	public class Page { 
		/// <summary> 
		/// The index of the start of the page. 
		/// </summary> 
		[JsonPropertyName("offset")] 
		public required int Offset { get; init; } 
	} 
}